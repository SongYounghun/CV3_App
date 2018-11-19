namespace CV3_App
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.m_SoftwareTriggerCheckbox = new System.Windows.Forms.CheckBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.m_CameraListTable = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.m_CameraList = new System.Windows.Forms.ListBox();
            this.m_AcquireButton = new System.Windows.Forms.Button();
            this.m_SoftwareTriggerTable = new System.Windows.Forms.TableLayoutPanel();
            this.m_SoftwareTriggerButton = new System.Windows.Forms.Button();
            this.m_DisplayPanel = new System.Windows.Forms.Panel();
            this.m_PictureBox = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.m_LogTable = new System.Windows.Forms.TableLayoutPanel();
            this.m_LogList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_test = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.m_CameraListTable.SuspendLayout();
            this.m_SoftwareTriggerTable.SuspendLayout();
            this.m_DisplayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.m_LogTable.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_SoftwareTriggerCheckbox
            // 
            this.m_SoftwareTriggerCheckbox.AutoSize = true;
            this.m_SoftwareTriggerCheckbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_SoftwareTriggerCheckbox.Enabled = false;
            this.m_SoftwareTriggerCheckbox.Location = new System.Drawing.Point(24, 3);
            this.m_SoftwareTriggerCheckbox.Name = "m_SoftwareTriggerCheckbox";
            this.m_SoftwareTriggerCheckbox.Size = new System.Drawing.Size(15, 23);
            this.m_SoftwareTriggerCheckbox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.m_SoftwareTriggerCheckbox, "When checked, the acquisition of a single frame gets triggered by a click on the " +
        "button.");
            this.m_SoftwareTriggerCheckbox.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.m_CameraListTable);
            this.splitContainer2.Panel1MinSize = 100;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.m_DisplayPanel);
            this.splitContainer2.Panel2MinSize = 100;
            this.splitContainer2.Size = new System.Drawing.Size(1021, 535);
            this.splitContainer2.SplitterDistance = 217;
            this.splitContainer2.TabIndex = 0;
            // 
            // m_CameraListTable
            // 
            this.m_CameraListTable.ColumnCount = 1;
            this.m_CameraListTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.m_CameraListTable.Controls.Add(this.label1, 0, 0);
            this.m_CameraListTable.Controls.Add(this.m_CameraList, 0, 1);
            this.m_CameraListTable.Controls.Add(this.m_AcquireButton, 0, 2);
            this.m_CameraListTable.Controls.Add(this.m_SoftwareTriggerTable, 0, 3);
            this.m_CameraListTable.Location = new System.Drawing.Point(0, 0);
            this.m_CameraListTable.Name = "m_CameraListTable";
            this.m_CameraListTable.RowCount = 4;
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 430F));
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.m_CameraListTable.Size = new System.Drawing.Size(198, 515);
            this.m_CameraListTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cameras:";
            // 
            // m_CameraList
            // 
            this.m_CameraList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_CameraList.FormattingEnabled = true;
            this.m_CameraList.IntegralHeight = false;
            this.m_CameraList.ItemHeight = 12;
            this.m_CameraList.Location = new System.Drawing.Point(0, 15);
            this.m_CameraList.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.m_CameraList.Name = "m_CameraList";
            this.m_CameraList.Size = new System.Drawing.Size(198, 427);
            this.m_CameraList.TabIndex = 1;
            this.m_CameraList.Click += new System.EventHandler(this.m_CameraList_Click);
            // 
            // m_AcquireButton
            // 
            this.m_AcquireButton.AutoSize = true;
            this.m_AcquireButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_AcquireButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_AcquireButton.Enabled = false;
            this.m_AcquireButton.Location = new System.Drawing.Point(5, 445);
            this.m_AcquireButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.m_AcquireButton.Name = "m_AcquireButton";
            this.m_AcquireButton.Size = new System.Drawing.Size(188, 22);
            this.m_AcquireButton.TabIndex = 3;
            this.m_AcquireButton.Text = "Start image acquisition";
            this.m_AcquireButton.UseVisualStyleBackColor = true;
            this.m_AcquireButton.Click += new System.EventHandler(this.m_AcquireButton_Click);
            // 
            // m_SoftwareTriggerTable
            // 
            this.m_SoftwareTriggerTable.AutoSize = true;
            this.m_SoftwareTriggerTable.ColumnCount = 2;
            this.m_SoftwareTriggerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.875F));
            this.m_SoftwareTriggerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.125F));
            this.m_SoftwareTriggerTable.Controls.Add(this.m_SoftwareTriggerCheckbox, 0, 0);
            this.m_SoftwareTriggerTable.Controls.Add(this.m_SoftwareTriggerButton, 1, 0);
            this.m_SoftwareTriggerTable.Location = new System.Drawing.Point(3, 470);
            this.m_SoftwareTriggerTable.Name = "m_SoftwareTriggerTable";
            this.m_SoftwareTriggerTable.RowCount = 1;
            this.m_SoftwareTriggerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.m_SoftwareTriggerTable.Size = new System.Drawing.Size(192, 29);
            this.m_SoftwareTriggerTable.TabIndex = 4;
            // 
            // m_SoftwareTriggerButton
            // 
            this.m_SoftwareTriggerButton.AutoSize = true;
            this.m_SoftwareTriggerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_SoftwareTriggerButton.Enabled = false;
            this.m_SoftwareTriggerButton.Location = new System.Drawing.Point(45, 3);
            this.m_SoftwareTriggerButton.Name = "m_SoftwareTriggerButton";
            this.m_SoftwareTriggerButton.Size = new System.Drawing.Size(144, 23);
            this.m_SoftwareTriggerButton.TabIndex = 1;
            this.m_SoftwareTriggerButton.Text = "Software Trigger";
            this.m_SoftwareTriggerButton.UseVisualStyleBackColor = true;
            this.m_SoftwareTriggerButton.Click += new System.EventHandler(this.m_SoftwareTriggerButton_Click);
            // 
            // m_DisplayPanel
            // 
            this.m_DisplayPanel.AutoScroll = true;
            this.m_DisplayPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_DisplayPanel.Controls.Add(this.m_PictureBox);
            this.m_DisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_DisplayPanel.Location = new System.Drawing.Point(0, 0);
            this.m_DisplayPanel.Name = "m_DisplayPanel";
            this.m_DisplayPanel.Size = new System.Drawing.Size(800, 535);
            this.m_DisplayPanel.TabIndex = 3;
            // 
            // m_PictureBox
            // 
            this.m_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.m_PictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.m_PictureBox.Name = "m_PictureBox";
            this.m_PictureBox.Size = new System.Drawing.Size(796, 531);
            this.m_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.m_PictureBox.TabIndex = 2;
            this.m_PictureBox.TabStop = false;
            this.m_PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.m_PictureBox_Paint);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.m_LogTable);
            this.splitContainer1.Panel2MinSize = 50;
            this.splitContainer1.Size = new System.Drawing.Size(1021, 684);
            this.splitContainer1.SplitterDistance = 535;
            this.splitContainer1.TabIndex = 10;
            // 
            // m_LogTable
            // 
            this.m_LogTable.ColumnCount = 1;
            this.m_LogTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.m_LogTable.Controls.Add(this.m_LogList, 0, 1);
            this.m_LogTable.Controls.Add(this.label2, 0, 0);
            this.m_LogTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_LogTable.Location = new System.Drawing.Point(0, 0);
            this.m_LogTable.Name = "m_LogTable";
            this.m_LogTable.RowCount = 2;
            this.m_LogTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.m_LogTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.m_LogTable.Size = new System.Drawing.Size(1021, 145);
            this.m_LogTable.TabIndex = 4;
            // 
            // m_LogList
            // 
            this.m_LogList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_LogList.FormattingEnabled = true;
            this.m_LogList.IntegralHeight = false;
            this.m_LogList.ItemHeight = 12;
            this.m_LogList.Location = new System.Drawing.Point(0, 12);
            this.m_LogList.Margin = new System.Windows.Forms.Padding(0);
            this.m_LogList.Name = "m_LogList";
            this.m_LogList.Size = new System.Drawing.Size(1021, 133);
            this.m_LogList.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Log messages:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_test);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 684);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1021, 46);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1015, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Programming example to demonstrate how to acquire images asynchronously (grab) wi" +
    "th VimbaNET.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_test
            // 
            this.button_test.Location = new System.Drawing.Point(946, 23);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(75, 23);
            this.button_test.TabIndex = 6;
            this.button_test.Text = "Test";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 730);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.m_CameraListTable.ResumeLayout(false);
            this.m_CameraListTable.PerformLayout();
            this.m_SoftwareTriggerTable.ResumeLayout(false);
            this.m_SoftwareTriggerTable.PerformLayout();
            this.m_DisplayPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.m_LogTable.ResumeLayout(false);
            this.m_LogTable.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox m_SoftwareTriggerCheckbox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel m_CameraListTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox m_CameraList;
        private System.Windows.Forms.Button m_AcquireButton;
        private System.Windows.Forms.TableLayoutPanel m_SoftwareTriggerTable;
        private System.Windows.Forms.Button m_SoftwareTriggerButton;
        private System.Windows.Forms.Panel m_DisplayPanel;
        private System.Windows.Forms.PictureBox m_PictureBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel m_LogTable;
        private System.Windows.Forms.ListBox m_LogList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_test;
    }
}

