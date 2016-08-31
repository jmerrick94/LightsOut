namespace LightsOut
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.lblLightsOut = new System.Windows.Forms.Label();
            this.LightBulb = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LightBulb)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLightsOut
            // 
            this.lblLightsOut.AutoSize = true;
            this.lblLightsOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLightsOut.ForeColor = System.Drawing.Color.Red;
            this.lblLightsOut.Location = new System.Drawing.Point(143, 42);
            this.lblLightsOut.Name = "lblLightsOut";
            this.lblLightsOut.Size = new System.Drawing.Size(167, 33);
            this.lblLightsOut.TabIndex = 0;
            this.lblLightsOut.Text = "Lights Out!";
            // 
            // LightBulb
            // 
            this.LightBulb.Image = ((System.Drawing.Image)(resources.GetObject("LightBulb.Image")));
            this.LightBulb.Location = new System.Drawing.Point(91, 42);
            this.LightBulb.Name = "LightBulb";
            this.LightBulb.Size = new System.Drawing.Size(46, 48);
            this.LightBulb.TabIndex = 1;
            this.LightBulb.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "By Jordan Merrick";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Turn all the lights out (black) to win the game!";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(165, 176);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 211);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LightBulb);
            this.Controls.Add(this.lblLightsOut);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.LightBulb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLightsOut;
        private System.Windows.Forms.PictureBox LightBulb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
    }
}