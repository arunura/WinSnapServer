namespace WinSnapServer
{
    partial class WindowSelectorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowSelectorForm));
            this.pictureBoxSnap = new System.Windows.Forms.PictureBox();
            this.buttonSnap = new System.Windows.Forms.Button();
            this.listBoxSnap = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHandle = new System.Windows.Forms.TextBox();
            this.buttonSnapHandle = new System.Windows.Forms.Button();
            this.checkBoxForceMDI = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.urlStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.requestCountStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.wakeupStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnap)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxSnap
            // 
            this.pictureBoxSnap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSnap.Location = new System.Drawing.Point(325, 12);
            this.pictureBoxSnap.Name = "pictureBoxSnap";
            this.pictureBoxSnap.Size = new System.Drawing.Size(640, 431);
            this.pictureBoxSnap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSnap.TabIndex = 0;
            this.pictureBoxSnap.TabStop = false;
            // 
            // buttonSnap
            // 
            this.buttonSnap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSnap.Location = new System.Drawing.Point(12, 457);
            this.buttonSnap.Name = "buttonSnap";
            this.buttonSnap.Size = new System.Drawing.Size(138, 29);
            this.buttonSnap.TabIndex = 2;
            this.buttonSnap.Text = "Collect Window Snaps";
            this.buttonSnap.UseVisualStyleBackColor = true;
            this.buttonSnap.Click += new System.EventHandler(this.buttonSnap_Click);
            // 
            // listBoxSnap
            // 
            this.listBoxSnap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxSnap.FormattingEnabled = true;
            this.listBoxSnap.Location = new System.Drawing.Point(12, 10);
            this.listBoxSnap.Name = "listBoxSnap";
            this.listBoxSnap.Size = new System.Drawing.Size(296, 433);
            this.listBoxSnap.TabIndex = 3;
            this.listBoxSnap.SelectedIndexChanged += new System.EventHandler(this.listBoxSnap_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(668, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Handle:";
            // 
            // textBoxHandle
            // 
            this.textBoxHandle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHandle.Location = new System.Drawing.Point(718, 461);
            this.textBoxHandle.Name = "textBoxHandle";
            this.textBoxHandle.Size = new System.Drawing.Size(160, 20);
            this.textBoxHandle.TabIndex = 5;
            // 
            // buttonSnapHandle
            // 
            this.buttonSnapHandle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSnapHandle.Location = new System.Drawing.Point(885, 457);
            this.buttonSnapHandle.Name = "buttonSnapHandle";
            this.buttonSnapHandle.Size = new System.Drawing.Size(79, 27);
            this.buttonSnapHandle.TabIndex = 6;
            this.buttonSnapHandle.Text = "Snap";
            this.buttonSnapHandle.UseVisualStyleBackColor = true;
            this.buttonSnapHandle.Click += new System.EventHandler(this.buttonSnapHandle_Click);
            // 
            // checkBoxForceMDI
            // 
            this.checkBoxForceMDI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxForceMDI.AutoSize = true;
            this.checkBoxForceMDI.Checked = true;
            this.checkBoxForceMDI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxForceMDI.Location = new System.Drawing.Point(325, 463);
            this.checkBoxForceMDI.Name = "checkBoxForceMDI";
            this.checkBoxForceMDI.Size = new System.Drawing.Size(124, 17);
            this.checkBoxForceMDI.TabIndex = 7;
            this.checkBoxForceMDI.Text = "Force MDI Capturing";
            this.checkBoxForceMDI.UseVisualStyleBackColor = true;
            this.checkBoxForceMDI.CheckedChanged += new System.EventHandler(this.checkBoxForceMDI_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.Location = new System.Drawing.Point(166, 457);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(142, 29);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Clear Snaps";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.urlStatusLabel,
            this.toolStripStatusLabel1,
            this.requestCountStatusLabel,
            this.toolStripStatusLabel3,
            this.wakeupStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 496);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(975, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel2.Text = "Server URL: ";
            // 
            // urlStatusLabel
            // 
            this.urlStatusLabel.Name = "urlStatusLabel";
            this.urlStatusLabel.Size = new System.Drawing.Size(81, 17);
            this.urlStatusLabel.Text = "urlStatusLabel";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(122, 17);
            this.toolStripStatusLabel1.Text = "Snap Requests Count:";
            // 
            // requestCountStatusLabel
            // 
            this.requestCountStatusLabel.Name = "requestCountStatusLabel";
            this.requestCountStatusLabel.Size = new System.Drawing.Size(36, 17);
            this.requestCountStatusLabel.Text = "None";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(139, 17);
            this.toolStripStatusLabel3.Text = "Wakeup Requests Count:";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // wakeupStatusLabel
            // 
            this.wakeupStatusLabel.Name = "wakeupStatusLabel";
            this.wakeupStatusLabel.Size = new System.Drawing.Size(13, 17);
            this.wakeupStatusLabel.Text = "0";
            // 
            // WindowSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 518);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.checkBoxForceMDI);
            this.Controls.Add(this.buttonSnapHandle);
            this.Controls.Add(this.textBoxHandle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSnap);
            this.Controls.Add(this.buttonSnap);
            this.Controls.Add(this.pictureBoxSnap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "WindowSelectorForm";
            this.Text = "Window Snap Server";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnap)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSnap;
        private System.Windows.Forms.Button buttonSnap;
        private System.Windows.Forms.ListBox listBoxSnap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHandle;
        private System.Windows.Forms.Button buttonSnapHandle;
        private System.Windows.Forms.CheckBox checkBoxForceMDI;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel urlStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel requestCountStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel wakeupStatusLabel;
    }
}

