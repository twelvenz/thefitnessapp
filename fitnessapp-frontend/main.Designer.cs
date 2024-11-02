namespace FitnessApp
{
    partial class main
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
            this.btnChest = new System.Windows.Forms.Button();
            this.btnLeg = new System.Windows.Forms.Button();
            this.btnArms = new System.Windows.Forms.Button();
            this.btnShoulder = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChest
            // 
            this.btnChest.Location = new System.Drawing.Point(249, 172);
            this.btnChest.Name = "btnChest";
            this.btnChest.Size = new System.Drawing.Size(188, 72);
            this.btnChest.TabIndex = 0;
            this.btnChest.Text = "Chest";
            this.btnChest.UseVisualStyleBackColor = true;
            this.btnChest.Click += new System.EventHandler(this.btnChest_Click);
            // 
            // btnLeg
            // 
            this.btnLeg.Location = new System.Drawing.Point(568, 172);
            this.btnLeg.Name = "btnLeg";
            this.btnLeg.Size = new System.Drawing.Size(188, 72);
            this.btnLeg.TabIndex = 1;
            this.btnLeg.Text = "Leg";
            this.btnLeg.UseVisualStyleBackColor = true;
            this.btnLeg.Click += new System.EventHandler(this.btnLeg_Click);
            // 
            // btnArms
            // 
            this.btnArms.Location = new System.Drawing.Point(249, 300);
            this.btnArms.Name = "btnArms";
            this.btnArms.Size = new System.Drawing.Size(188, 72);
            this.btnArms.TabIndex = 2;
            this.btnArms.Text = "Arms";
            this.btnArms.UseVisualStyleBackColor = true;
            this.btnArms.Click += new System.EventHandler(this.btnArms_Click);
            // 
            // btnShoulder
            // 
            this.btnShoulder.Location = new System.Drawing.Point(568, 300);
            this.btnShoulder.Name = "btnShoulder";
            this.btnShoulder.Size = new System.Drawing.Size(188, 72);
            this.btnShoulder.TabIndex = 3;
            this.btnShoulder.Text = "Shoulder";
            this.btnShoulder.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(249, 437);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(188, 72);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnAb
            // 
            this.btnAb.Location = new System.Drawing.Point(568, 437);
            this.btnAb.Name = "btnAb";
            this.btnAb.Size = new System.Drawing.Size(188, 72);
            this.btnAb.TabIndex = 5;
            this.btnAb.Text = "Ab";
            this.btnAb.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 657);
            this.Controls.Add(this.btnAb);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnShoulder);
            this.Controls.Add(this.btnArms);
            this.Controls.Add(this.btnLeg);
            this.Controls.Add(this.btnChest);
            this.Name = "main";
            this.Text = "Fitness App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChest;
        private System.Windows.Forms.Button btnLeg;
        private System.Windows.Forms.Button btnArms;
        private System.Windows.Forms.Button btnShoulder;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAb;
    }
}

