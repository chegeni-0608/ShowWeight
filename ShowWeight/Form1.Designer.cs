namespace ShowWeight
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.btnShowWeight = new System.Windows.Forms.Button();
            this.btnChangeBGColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChangeColor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(257, 41);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "لطفا وزن خود را وارد کنید :";
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtWeight.ForeColor = System.Drawing.Color.Yellow;
            this.txtWeight.Location = new System.Drawing.Point(69, 38);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(163, 20);
            this.txtWeight.TabIndex = 1;
            // 
            // btnShowWeight
            // 
            this.btnShowWeight.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnShowWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnShowWeight.Location = new System.Drawing.Point(69, 83);
            this.btnShowWeight.Name = "btnShowWeight";
            this.btnShowWeight.Size = new System.Drawing.Size(163, 23);
            this.btnShowWeight.TabIndex = 2;
            this.btnShowWeight.Text = "نمایش وزن";
            this.btnShowWeight.UseVisualStyleBackColor = false;
            this.btnShowWeight.Click += new System.EventHandler(this.btnShowWeight_Click);
            // 
            // btnChangeBGColor
            // 
            this.btnChangeBGColor.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnChangeBGColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChangeBGColor.Location = new System.Drawing.Point(69, 127);
            this.btnChangeBGColor.Name = "btnChangeBGColor";
            this.btnChangeBGColor.Size = new System.Drawing.Size(162, 23);
            this.btnChangeBGColor.TabIndex = 3;
            this.btnChangeBGColor.Text = "تغییر رنگ پس زمینه";
            this.btnChangeBGColor.UseVisualStyleBackColor = false;
            this.btnChangeBGColor.Click += new System.EventHandler(this.btnChangeBGColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(267, 167);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "وارد کردن رنگ پس زمینه :";
            // 
            // txtChangeColor
            // 
            this.txtChangeColor.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtChangeColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtChangeColor.Location = new System.Drawing.Point(69, 164);
            this.txtChangeColor.Name = "txtChangeColor";
            this.txtChangeColor.Size = new System.Drawing.Size(162, 20);
            this.txtChangeColor.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(418, 193);
            this.Controls.Add(this.txtChangeColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChangeBGColor);
            this.Controls.Add(this.btnShowWeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "نمایش وزن";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnShowWeight;
        private System.Windows.Forms.Button btnChangeBGColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChangeColor;
    }
}

