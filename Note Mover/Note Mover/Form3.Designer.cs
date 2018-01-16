namespace Note_Mover
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtColorBtn = new System.Windows.Forms.Button();
            this.BgImage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BgColorBtn = new System.Windows.Forms.Button();
            this.TitleForm = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Text Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Change Background Color";
            // 
            // TxtColorBtn
            // 
            this.TxtColorBtn.Location = new System.Drawing.Point(175, 81);
            this.TxtColorBtn.Name = "TxtColorBtn";
            this.TxtColorBtn.Size = new System.Drawing.Size(56, 23);
            this.TxtColorBtn.TabIndex = 6;
            this.TxtColorBtn.Text = "Change";
            this.TxtColorBtn.UseVisualStyleBackColor = true;
            this.TxtColorBtn.Click += new System.EventHandler(this.TxtColorBtn_Click);
            // 
            // BgImage
            // 
            this.BgImage.Location = new System.Drawing.Point(275, 156);
            this.BgImage.Name = "BgImage";
            this.BgImage.Size = new System.Drawing.Size(59, 23);
            this.BgImage.TabIndex = 7;
            this.BgImage.Text = "Change";
            this.BgImage.UseVisualStyleBackColor = true;
            this.BgImage.Click += new System.EventHandler(this.BgImage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Change Background/Wallpaper";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Change Theme (Coming soon)";
            // 
            // BgColorBtn
            // 
            this.BgColorBtn.Location = new System.Drawing.Point(237, 118);
            this.BgColorBtn.Name = "BgColorBtn";
            this.BgColorBtn.Size = new System.Drawing.Size(59, 23);
            this.BgColorBtn.TabIndex = 10;
            this.BgColorBtn.Text = "Change";
            this.BgColorBtn.UseVisualStyleBackColor = true;
            this.BgColorBtn.Click += new System.EventHandler(this.BgColorBtn_Click);
            // 
            // TitleForm
            // 
            this.TitleForm.AutoSize = true;
            this.TitleForm.BackColor = System.Drawing.Color.Transparent;
            this.TitleForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleForm.ForeColor = System.Drawing.SystemColors.Control;
            this.TitleForm.Location = new System.Drawing.Point(117, 24);
            this.TitleForm.Name = "TitleForm";
            this.TitleForm.Size = new System.Drawing.Size(130, 20);
            this.TitleForm.TabIndex = 11;
            this.TitleForm.Text = "Theme Options";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(382, 226);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(99, 23);
            this.ResetBtn.TabIndex = 12;
            this.ResetBtn.Text = "Reset to Default";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Note_Mover.Properties.Resources.Maroon3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(493, 261);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.TitleForm);
            this.Controls.Add(this.BgColorBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BgImage);
            this.Controls.Add(this.TxtColorBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Theme Changer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TxtColorBtn;
        private System.Windows.Forms.Button BgImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BgColorBtn;
        private System.Windows.Forms.Label TitleForm;
        private System.Windows.Forms.Button ResetBtn;
    }
}