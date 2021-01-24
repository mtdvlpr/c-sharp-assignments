namespace Assignment1
{
    partial class TrainDisplay
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
            this.lblRailwayTrack = new System.Windows.Forms.Label();
            this.lblCurrentStation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRailwayTrack
            // 
            this.lblRailwayTrack.AutoSize = true;
            this.lblRailwayTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRailwayTrack.Location = new System.Drawing.Point(229, 81);
            this.lblRailwayTrack.Name = "lblRailwayTrack";
            this.lblRailwayTrack.Size = new System.Drawing.Size(27, 25);
            this.lblRailwayTrack.TabIndex = 7;
            this.lblRailwayTrack.Text = "...";
            // 
            // lblCurrentStation
            // 
            this.lblCurrentStation.AutoSize = true;
            this.lblCurrentStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStation.Location = new System.Drawing.Point(229, 42);
            this.lblCurrentStation.Name = "lblCurrentStation";
            this.lblCurrentStation.Size = new System.Drawing.Size(27, 25);
            this.lblCurrentStation.TabIndex = 6;
            this.lblCurrentStation.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Railway Track:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current Station:";
            // 
            // TrainDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 147);
            this.Controls.Add(this.lblRailwayTrack);
            this.Controls.Add(this.lblCurrentStation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TrainDisplay";
            this.Text = "TrainDisplay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrainDisplay_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRailwayTrack;
        private System.Windows.Forms.Label lblCurrentStation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}