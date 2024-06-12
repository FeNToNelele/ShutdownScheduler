namespace ShutdownScheduler
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.lblText = new System.Windows.Forms.Label();
            this.nudHr = new System.Windows.Forms.NumericUpDown();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.lblHr = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.btnSchedule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblText.Location = new System.Drawing.Point(70, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(94, 18);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Shutdown at:";
            // 
            // nudHr
            // 
            this.nudHr.Location = new System.Drawing.Point(47, 30);
            this.nudHr.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudHr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudHr.Name = "nudHr";
            this.nudHr.Size = new System.Drawing.Size(39, 20);
            this.nudHr.TabIndex = 1;
            this.nudHr.ValueChanged += new System.EventHandler(this.nudHr_ValueChanged);
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(124, 30);
            this.nudMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(39, 20);
            this.nudMin.TabIndex = 2;
            this.nudMin.ValueChanged += new System.EventHandler(this.nudMin_ValueChanged);
            // 
            // lblHr
            // 
            this.lblHr.AutoSize = true;
            this.lblHr.Location = new System.Drawing.Point(92, 32);
            this.lblHr.Name = "lblHr";
            this.lblHr.Size = new System.Drawing.Size(16, 13);
            this.lblHr.TabIndex = 3;
            this.lblHr.Text = "hr";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(169, 32);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(23, 13);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "min";
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(47, 56);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(145, 23);
            this.btnSchedule.TabIndex = 5;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(238, 89);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblHr);
            this.Controls.Add(this.nudMin);
            this.Controls.Add(this.nudHr);
            this.Controls.Add(this.lblText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Scheduler";
            ((System.ComponentModel.ISupportInitialize)(this.nudHr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.NumericUpDown nudHr;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Label lblHr;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Button btnSchedule;
    }
}

