namespace UserControl_AnalogClock
{
    partial class AnalogClock
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.clockTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// clockTimer
			// 
			this.clockTimer.Enabled = true;
			this.clockTimer.Interval = 1000;
			this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
			// 
			// AnalogClock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.DoubleBuffered = true;
			this.Name = "AnalogClock";
			this.Size = new System.Drawing.Size(171, 173);
			this.Load += new System.EventHandler(this.AnalogClock_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.AnalogClock_Paint);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer clockTimer;
    }
}
