namespace WindowsFormsApp1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_celsius = new System.Windows.Forms.Button();
            this.btn_kelvin = new System.Windows.Forms.Button();
            this.btn_fahrenheight = new System.Windows.Forms.Button();
            this.txt_fahrenheight = new System.Windows.Forms.TextBox();
            this.txt_celsius = new System.Windows.Forms.TextBox();
            this.txt_kelvin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(36, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kelvin\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(37, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ferhenheight";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(37, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Celsius";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_celsius
            // 
            this.btn_celsius.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_celsius.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_celsius.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_celsius.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_celsius.Location = new System.Drawing.Point(328, 219);
            this.btn_celsius.Name = "btn_celsius";
            this.btn_celsius.Size = new System.Drawing.Size(150, 52);
            this.btn_celsius.TabIndex = 13;
            this.btn_celsius.Text = "convert";
            this.btn_celsius.UseVisualStyleBackColor = false;
            this.btn_celsius.Click += new System.EventHandler(this.btn_celsius_Click);
            // 
            // btn_kelvin
            // 
            this.btn_kelvin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_kelvin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kelvin.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kelvin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_kelvin.Location = new System.Drawing.Point(328, 343);
            this.btn_kelvin.Name = "btn_kelvin";
            this.btn_kelvin.Size = new System.Drawing.Size(150, 47);
            this.btn_kelvin.TabIndex = 14;
            this.btn_kelvin.Text = "convert";
            this.btn_kelvin.UseVisualStyleBackColor = false;
            this.btn_kelvin.Click += new System.EventHandler(this.btn_kelvin_Click);
            // 
            // btn_fahrenheight
            // 
            this.btn_fahrenheight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fahrenheight.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fahrenheight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_fahrenheight.Location = new System.Drawing.Point(527, 155);
            this.btn_fahrenheight.Name = "btn_fahrenheight";
            this.btn_fahrenheight.Size = new System.Drawing.Size(150, 44);
            this.btn_fahrenheight.TabIndex = 15;
            this.btn_fahrenheight.Text = "convert";
            this.btn_fahrenheight.UseVisualStyleBackColor = true;
            this.btn_fahrenheight.Click += new System.EventHandler(this.btn_fahrenheight_Click);
            // 
            // txt_fahrenheight
            // 
            this.txt_fahrenheight.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fahrenheight.Location = new System.Drawing.Point(36, 120);
            this.txt_fahrenheight.Multiline = true;
            this.txt_fahrenheight.Name = "txt_fahrenheight";
            this.txt_fahrenheight.Size = new System.Drawing.Size(247, 52);
            this.txt_fahrenheight.TabIndex = 16;
            this.txt_fahrenheight.TextChanged += new System.EventHandler(this.txt_fahrenheight_TextChanged);
            // 
            // txt_celsius
            // 
            this.txt_celsius.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_celsius.Location = new System.Drawing.Point(36, 222);
            this.txt_celsius.Multiline = true;
            this.txt_celsius.Name = "txt_celsius";
            this.txt_celsius.Size = new System.Drawing.Size(246, 48);
            this.txt_celsius.TabIndex = 17;
            this.txt_celsius.TextChanged += new System.EventHandler(this.txt_celsius_TextChanged);
            // 
            // txt_kelvin
            // 
            this.txt_kelvin.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kelvin.Location = new System.Drawing.Point(36, 343);
            this.txt_kelvin.Multiline = true;
            this.txt_kelvin.Name = "txt_kelvin";
            this.txt_kelvin.Size = new System.Drawing.Size(245, 49);
            this.txt_kelvin.TabIndex = 18;
            this.txt_kelvin.TextChanged += new System.EventHandler(this.txt_kelvin_TextChanged);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.medicine_thermometre_blue_background_copy_space_text_stock_photo_macro_medicine_thermometre_181656307;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(820, 472);
            this.Controls.Add(this.txt_kelvin);
            this.Controls.Add(this.txt_celsius);
            this.Controls.Add(this.txt_fahrenheight);
            this.Controls.Add(this.btn_fahrenheight);
            this.Controls.Add(this.btn_kelvin);
            this.Controls.Add(this.btn_celsius);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ODEL SOFTWARES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_celsius;
        private System.Windows.Forms.Button btn_kelvin;
        private System.Windows.Forms.Button btn_fahrenheight;
        private System.Windows.Forms.TextBox txt_fahrenheight;
        private System.Windows.Forms.TextBox txt_celsius;
        private System.Windows.Forms.TextBox txt_kelvin;
    }
}

