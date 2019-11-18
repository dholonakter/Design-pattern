namespace DPRWeek1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.LBxRdmList = new System.Windows.Forms.ListBox();
            this.LBxSortedList = new System.Windows.Forms.ListBox();
            this.GBxStrategy = new System.Windows.Forms.GroupBox();
            this.RBtnFCFS = new System.Windows.Forms.RadioButton();
            this.RBtnSSTF = new System.Windows.Forms.RadioButton();
            this.TCounter = new System.Windows.Forms.Timer(this.components);
            this.RBtnSDS = new System.Windows.Forms.RadioButton();
            this.BtnRun = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.TxtBxMover = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GBxStrategy.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBxRdmList
            // 
            this.LBxRdmList.FormattingEnabled = true;
            this.LBxRdmList.Location = new System.Drawing.Point(12, 12);
            this.LBxRdmList.Name = "LBxRdmList";
            this.LBxRdmList.Size = new System.Drawing.Size(66, 420);
            this.LBxRdmList.TabIndex = 0;
            // 
            // LBxSortedList
            // 
            this.LBxSortedList.FormattingEnabled = true;
            this.LBxSortedList.Location = new System.Drawing.Point(225, 12);
            this.LBxSortedList.Name = "LBxSortedList";
            this.LBxSortedList.Size = new System.Drawing.Size(66, 420);
            this.LBxSortedList.TabIndex = 1;
            // 
            // GBxStrategy
            // 
            this.GBxStrategy.Controls.Add(this.RBtnSDS);
            this.GBxStrategy.Controls.Add(this.RBtnSSTF);
            this.GBxStrategy.Controls.Add(this.RBtnFCFS);
            this.GBxStrategy.Location = new System.Drawing.Point(354, 12);
            this.GBxStrategy.Name = "GBxStrategy";
            this.GBxStrategy.Size = new System.Drawing.Size(200, 100);
            this.GBxStrategy.TabIndex = 2;
            this.GBxStrategy.TabStop = false;
            this.GBxStrategy.Text = "Strategy";
            // 
            // RBtnFCFS
            // 
            this.RBtnFCFS.AutoSize = true;
            this.RBtnFCFS.Location = new System.Drawing.Point(25, 20);
            this.RBtnFCFS.Name = "RBtnFCFS";
            this.RBtnFCFS.Size = new System.Drawing.Size(127, 17);
            this.RBtnFCFS.TabIndex = 0;
            this.RBtnFCFS.TabStop = true;
            this.RBtnFCFS.Text = "First Come First Serve";
            this.RBtnFCFS.UseVisualStyleBackColor = true;
            this.RBtnFCFS.CheckedChanged += new System.EventHandler(this.RBtnFCFS_CheckedChanged);
            // 
            // RBtnSSTF
            // 
            this.RBtnSSTF.AutoSize = true;
            this.RBtnSSTF.Location = new System.Drawing.Point(25, 44);
            this.RBtnSSTF.Name = "RBtnSSTF";
            this.RBtnSSTF.Size = new System.Drawing.Size(140, 17);
            this.RBtnSSTF.TabIndex = 1;
            this.RBtnSSTF.TabStop = true;
            this.RBtnSSTF.Text = "Shortest Seek Time First";
            this.RBtnSSTF.UseVisualStyleBackColor = true;
            this.RBtnSSTF.CheckedChanged += new System.EventHandler(this.RBtnSSTF_CheckedChanged);
            // 
            // RBtnSDS
            // 
            this.RBtnSDS.AutoSize = true;
            this.RBtnSDS.Location = new System.Drawing.Point(25, 68);
            this.RBtnSDS.Name = "RBtnSDS";
            this.RBtnSDS.Size = new System.Drawing.Size(134, 17);
            this.RBtnSDS.TabIndex = 2;
            this.RBtnSDS.TabStop = true;
            this.RBtnSDS.Text = "SCAN Disk Scheduling";
            this.RBtnSDS.UseVisualStyleBackColor = true;
            this.RBtnSDS.CheckedChanged += new System.EventHandler(this.RBtnSDS_CheckedChanged);
            // 
            // BtnRun
            // 
            this.BtnRun.Location = new System.Drawing.Point(354, 118);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(200, 23);
            this.BtnRun.TabIndex = 3;
            this.BtnRun.Text = "RUN";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(354, 147);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(200, 23);
            this.BtnStop.TabIndex = 4;
            this.BtnStop.Text = "STOP";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // TxtBxMover
            // 
            this.TxtBxMover.Location = new System.Drawing.Point(104, 67);
            this.TxtBxMover.Name = "TxtBxMover";
            this.TxtBxMover.ReadOnly = true;
            this.TxtBxMover.Size = new System.Drawing.Size(100, 20);
            this.TxtBxMover.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "-->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBxMover);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.GBxStrategy);
            this.Controls.Add(this.LBxSortedList);
            this.Controls.Add(this.LBxRdmList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GBxStrategy.ResumeLayout(false);
            this.GBxStrategy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBxRdmList;
        private System.Windows.Forms.ListBox LBxSortedList;
        private System.Windows.Forms.GroupBox GBxStrategy;
        private System.Windows.Forms.RadioButton RBtnSDS;
        private System.Windows.Forms.RadioButton RBtnSSTF;
        private System.Windows.Forms.RadioButton RBtnFCFS;
        private System.Windows.Forms.Timer TCounter;
        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.TextBox TxtBxMover;
        private System.Windows.Forms.Label label1;
    }
}

