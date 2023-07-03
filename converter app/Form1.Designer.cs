namespace converter_app
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_celsius = new System.Windows.Forms.TextBox();
            this.txt_celcius = new System.Windows.Forms.TextBox();
            this.txt_kelvin = new System.Windows.Forms.TextBox();
            this.btn_ferhenheight = new System.Windows.Forms.Button();
            this.btn_kelvin = new System.Windows.Forms.Button();
            this.btn_celsius = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.PictureBox();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Name = "label2";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Name = "label3";
            this.label3.UseWaitCursor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Name = "label4";
            this.label4.UseWaitCursor = true;
            // 
            // txt_celsius
            // 
            resources.ApplyResources(this.txt_celsius, "txt_celsius");
            this.txt_celsius.Name = "txt_celsius";
            this.txt_celsius.UseWaitCursor = true;
            // 
            // txt_celcius
            // 
            resources.ApplyResources(this.txt_celcius, "txt_celcius");
            this.txt_celcius.Name = "txt_celcius";
            this.txt_celcius.UseWaitCursor = true;
            // 
            // txt_kelvin
            // 
            resources.ApplyResources(this.txt_kelvin, "txt_kelvin");
            this.txt_kelvin.Name = "txt_kelvin";
            this.txt_kelvin.UseWaitCursor = true;
            // 
            // btn_ferhenheight
            // 
            this.btn_ferhenheight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ferhenheight.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_ferhenheight.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_ferhenheight, "btn_ferhenheight");
            this.btn_ferhenheight.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_ferhenheight.Name = "btn_ferhenheight";
            this.btn_ferhenheight.UseVisualStyleBackColor = false;
            this.btn_ferhenheight.UseWaitCursor = true;
            this.btn_ferhenheight.Click += new System.EventHandler(this.btn_ferhenheight_Click);
            // 
            // btn_kelvin
            // 
            this.btn_kelvin.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.btn_kelvin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_kelvin.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_kelvin.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_kelvin, "btn_kelvin");
            this.btn_kelvin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_kelvin.Name = "btn_kelvin";
            this.btn_kelvin.UseVisualStyleBackColor = false;
            this.btn_kelvin.UseWaitCursor = true;
            this.btn_kelvin.Click += new System.EventHandler(this.btn_kelvin_Click);
            // 
            // btn_celsius
            // 
            this.btn_celsius.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_celsius.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_celsius.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_celsius, "btn_celsius");
            this.btn_celsius.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_celsius.Name = "btn_celsius";
            this.btn_celsius.UseVisualStyleBackColor = false;
            this.btn_celsius.UseWaitCursor = true;
            this.btn_celsius.Click += new System.EventHandler(this.btn_celsius_Click);
            // 
            // Refresh
            // 
            this.Refresh.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            resources.ApplyResources(this.Refresh, "Refresh");
            this.Refresh.Name = "Refresh";
            this.Refresh.TabStop = false;
            this.Refresh.UseWaitCursor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // ComboBox1
            // 
            resources.ApplyResources(this.ComboBox1, "ComboBox1");
            this.ComboBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ComboBox1.Items.AddRange(new object[] {
            resources.GetString("ComboBox1.Items"),
            resources.GetString("ComboBox1.Items1"),
            resources.GetString("ComboBox1.Items2"),
            resources.GetString("ComboBox1.Items3")});
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.UseWaitCursor = true;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.btn_celsius);
            this.Controls.Add(this.btn_kelvin);
            this.Controls.Add(this.btn_ferhenheight);
            this.Controls.Add(this.txt_kelvin);
            this.Controls.Add(this.txt_celcius);
            this.Controls.Add(this.txt_celsius);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Tag = "";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_celsius;
        private System.Windows.Forms.TextBox txt_celcius;
        private System.Windows.Forms.TextBox txt_kelvin;
        private System.Windows.Forms.Button btn_ferhenheight;
        private System.Windows.Forms.Button btn_kelvin;
        private System.Windows.Forms.Button btn_celsius;
        private new System.Windows.Forms.PictureBox Refresh;
        private System.Windows.Forms.ComboBox ComboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

