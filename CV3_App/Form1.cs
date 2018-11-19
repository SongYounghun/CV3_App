using AsynchronousGrab;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV3_App
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// The VimbaHelper (see VimbaHelper Class)
        /// </summary>
        private VimbaHelper m_VimbaHelper = null;

        /// <summary>
        /// Flag to indicate if the camera is acquiring images
        /// </summary>
        private bool m_Acquiring = false;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the CameraListChanged event
        /// </summary>
        /// <param name="sender">The Sender</param>
        /// <param name="args">The EventArgs</param>
        private void OnCameraListChanged(object sender, EventArgs args)
        {
            // Start an asynchronous invoke in case this method was not
            // called by the GUI thread.
            if (InvokeRequired == true)
            {
                BeginInvoke(new CameraListChangedHandler(this.OnCameraListChanged), sender, args);
                return;
            }

            if (null != m_VimbaHelper)
            {
                try
                {
                    UpdateCameraList();

                    LogMessage("Camera list updated.");
                }
                catch (Exception exception)
                {
                    LogError("Could not update camera list. Reason: " + exception.Message);
                }
            }
        }

        /// <summary>
        /// Handles the FrameReceived event
        /// </summary>
        /// <param name="sender">The Sender</param>
        /// <param name="args">The FrameEventArgs</param>
        private void OnFrameReceived(object sender, FrameEventArgs args)
        {
            // Start an async invoke in case this method was not
            // called by the GUI thread.
            if (InvokeRequired == true)
            {
                BeginInvoke(new FrameReceivedHandler(this.OnFrameReceived), sender, args);
                return;
            }

            if (true == m_Acquiring)
            {
                Mat img = BitmapConverter.ToMat(new Bitmap(args.Image));
                img = img.CvtColor(ColorConversionCodes.RGB2GRAY);
                Mat colorMapImg = new Mat();
                Cv2.ApplyColorMap(img, colorMapImg, ColormapTypes.Jet);
                //Cv2.ImShow("Jet", colorMapImg);

                // Display image
                //Image image = args.Image;
                Image image = BitmapConverter.ToBitmap(colorMapImg);
                if (null != image)
                {
                    m_PictureBox.Image = image;
                }
                else
                {
                    LogMessage("An acquisition error occurred. Reason: " + args.Exception.Message);

                    try
                    {
                        try
                        {
                            // Start asynchronous image acquisition (grab) in selected camera
                            m_VimbaHelper.StopContinuousImageAcquisition();
                        }
                        finally
                        {
                            m_Acquiring = false;
                            UpdateControls();
                            m_CameraList.Enabled = true;
                        }

                        LogMessage("Asynchronous image acquisition stopped.");
                    }
                    catch (Exception exception)
                    {
                        LogError("Error while stopping asynchronous image acquisition. Reason: " + exception.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Update the camera List in the UI
        /// </summary>
        private void UpdateCameraList()
        {
            // Remember the old selection (if there was any)y
            CameraInfo oldSelectedItem = m_CameraList.SelectedItem as CameraInfo;
            m_CameraList.Items.Clear();

            List<CameraInfo> cameras = m_VimbaHelper.CameraList;

            CameraInfo newSelectedItem = null;
            foreach (CameraInfo cameraInfo in cameras)
            {
                m_CameraList.Items.Add(cameraInfo);

                if (null == newSelectedItem)
                {
                    // At least select the first camera
                    newSelectedItem = cameraInfo;
                }
                else if (null != oldSelectedItem)
                {
                    // If the previous selected camera is still available
                    // then prefer this camera.
                    if (string.Compare(newSelectedItem.ID, cameraInfo.ID, StringComparison.Ordinal) == 0)
                    {
                        newSelectedItem = cameraInfo;
                    }
                }
            }

            // If available select a camera and adjust the status of the "Start acquisition" button
            if (null != newSelectedItem)
            {
                m_CameraList.SelectedItem = newSelectedItem;
                m_AcquireButton.Enabled = true;
            }
            else
            {
                m_AcquireButton.Enabled = false;
            }
        }

        /// <summary>
        /// Updates the state of the Acquisition and Trigger controls
        /// </summary>
        private void UpdateControls()
        {
            if (true == m_Acquiring)
            {
                m_AcquireButton.Text = "Stop image acquisition";
                m_AcquireButton.Enabled = true;
            }
            else
            {
                m_AcquireButton.Text = "Start image acquisition";

                CameraInfo cameraInfo = m_CameraList.SelectedItem as CameraInfo;
                if (null != cameraInfo)
                {
                    // Enable button if a camera is selected
                    m_AcquireButton.Enabled = true;
                }
                else
                {
                    // Disable button if no camera is selected
                    m_AcquireButton.Enabled = false;
                }
            }

            if (m_VimbaHelper.IsTriggerAvailable)
            {
                if (false == m_Acquiring)
                {
                    m_SoftwareTriggerCheckbox.Enabled = m_AcquireButton.Enabled;
                    m_SoftwareTriggerButton.Enabled = false;
                }
                else
                {
                    m_SoftwareTriggerCheckbox.Enabled = false;
                    m_SoftwareTriggerButton.Enabled = m_SoftwareTriggerCheckbox.Checked;
                }
            }
            else
            {
                m_SoftwareTriggerCheckbox.Checked = false;
                m_SoftwareTriggerCheckbox.Enabled = false;
            }
        }

        /// <summary>
        /// Add log message to logging list box
        /// </summary>
        /// <param name="message">The message</param>
        private void LogMessage(string message)
        {
            if (null == message)
            {
                throw new ArgumentNullException("message");
            }

            int index = m_LogList.Items.Add(string.Format("{0:yyyy-MM-dd HH:mm:ss.fff}: {1}", DateTime.Now, message));
            m_LogList.TopIndex = index;
        }

        /// <summary>
        /// Add an error log message and show an error message box
        /// </summary>
        /// <param name="message">The message</param>
        private void LogError(string message)
        {
            LogMessage(message);

            MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Start up Vimba SDK         
                VimbaHelper vimbaHelper = new VimbaHelper();
                vimbaHelper.Startup(this.OnCameraListChanged);
                m_VimbaHelper = vimbaHelper;

                Text = String.Format("{0} (Vimba .NET API Version {1})", Text, m_VimbaHelper.GetVersion());
                try
                {
                    UpdateCameraList();
                    UpdateControls();
                }
                catch (Exception exception)
                {
                    LogError("Could not update camera list. Reason: " + exception.Message);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void m_AcquireButton_Click(object sender, EventArgs e)
        {
            if (false == m_Acquiring)
            {
                try
                {
                    // Determine selected camera
                    CameraInfo selectedItem = m_CameraList.SelectedItem as CameraInfo;
                    if (null == selectedItem)
                    {
                        throw new NullReferenceException("No camera selected.");
                    }

                    // Open the camera if it was not opened before
                    m_VimbaHelper.OpenCamera(selectedItem.ID);

                    // Start asynchronous image acquisition (grab) in selected camera
                    m_VimbaHelper.StartContinuousImageAcquisition(this.OnFrameReceived);

                    m_Acquiring = true;
                    UpdateControls();

                    // Disable the camera list to inhibit changing the camera
                    m_CameraList.Enabled = false;

                    LogMessage("Asynchronous image acquisition started.");
                }
                catch (Exception exception)
                {
                    LogError("Could not start asynchronous image acquisition. Reason: " + exception.Message);
                }
            }
            else
            {
                try
                {
                    try
                    {
                        // Start asynchronous image acquisition (grab) in selected camera
                        m_VimbaHelper.StopContinuousImageAcquisition();
                    }
                    finally
                    {
                        m_Acquiring = false;
                        UpdateControls();
                    }

                    LogMessage("Asynchronous image acquisition stopped.");
                }
                catch (Exception exception)
                {
                    LogError("Error while stopping asynchronous image acquisition. Reason: " + exception.Message);
                }

                // Re-enable the camera list
                m_CameraList.Enabled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (null != m_VimbaHelper)
            {
                try
                {
                    try
                    {
                        // Shutdown Vimba SDK when application exits
                        m_VimbaHelper.Shutdown();
                    }
                    finally
                    {
                        m_VimbaHelper = null;
                    }
                }
                catch (Exception exception)
                {
                    LogError("Could not shutdown Vimba API. Reason: " + exception.Message);
                }
            }
        }

        private void m_PictureBox_Paint(object sender, PaintEventArgs e)
        {
            VimbaHelper.ImageInUse = true;
        }

        private void m_CameraList_Click(object sender, EventArgs e)
        {
            // Close the camera if it was opened
            m_VimbaHelper.CloseCamera();

            // Determine selected camera
            CameraInfo selectedItem = m_CameraList.SelectedItem as CameraInfo;
            if (null == selectedItem)
            {
                throw new NullReferenceException("No camera selected.");
            }

            // Open selected camera
            m_VimbaHelper.OpenCamera(selectedItem.ID);

            UpdateControls();

            // In case that the check box is still checked, enable the software trigger
            if (m_VimbaHelper.IsTriggerAvailable)
            {
                m_VimbaHelper.EnableSoftwareTrigger(m_SoftwareTriggerCheckbox.Checked);
            }
        }

        private void m_SoftwareTriggerButton_Click(object sender, EventArgs e)
        {

        }

        private void button_test_Click(object sender, EventArgs e)
        {
            Mat img = BitmapConverter.ToMat(new Bitmap(m_PictureBox.Image));
            img = img.CvtColor(ColorConversionCodes.RGB2GRAY);
            Mat colorMapImg = new Mat();
            Cv2.ApplyColorMap(img, colorMapImg, ColormapTypes.Jet);
            Cv2.ImShow("Jet", colorMapImg);            
        }
    }
}
