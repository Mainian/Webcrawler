namespace Webcrawler
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
            this.comboBox_ScrapBehavior = new System.Windows.Forms.ComboBox();
            this.label_ScrapBehavior = new System.Windows.Forms.Label();
            this.comboBox_ScrapStyle = new System.Windows.Forms.ComboBox();
            this.label_ScrapStyle = new System.Windows.Forms.Label();
            this.textBox_URL = new System.Windows.Forms.TextBox();
            this.label_URL = new System.Windows.Forms.Label();
            this.textBox_OutputLocation = new System.Windows.Forms.TextBox();
            this.label_OutputLocation = new System.Windows.Forms.Label();
            this.button_Scrap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_ScrapBehavior
            // 
            this.comboBox_ScrapBehavior.FormattingEnabled = true;
            this.comboBox_ScrapBehavior.Location = new System.Drawing.Point(101, 12);
            this.comboBox_ScrapBehavior.Name = "comboBox_ScrapBehavior";
            this.comboBox_ScrapBehavior.Size = new System.Drawing.Size(171, 21);
            this.comboBox_ScrapBehavior.TabIndex = 0;
            // 
            // label_ScrapBehavior
            // 
            this.label_ScrapBehavior.AutoSize = true;
            this.label_ScrapBehavior.Location = new System.Drawing.Point(12, 15);
            this.label_ScrapBehavior.Name = "label_ScrapBehavior";
            this.label_ScrapBehavior.Size = new System.Drawing.Size(80, 13);
            this.label_ScrapBehavior.TabIndex = 1;
            this.label_ScrapBehavior.Text = "Scrap Behavior";
            // 
            // comboBox_ScrapStyle
            // 
            this.comboBox_ScrapStyle.FormattingEnabled = true;
            this.comboBox_ScrapStyle.Location = new System.Drawing.Point(101, 39);
            this.comboBox_ScrapStyle.Name = "comboBox_ScrapStyle";
            this.comboBox_ScrapStyle.Size = new System.Drawing.Size(171, 21);
            this.comboBox_ScrapStyle.TabIndex = 2;
            // 
            // label_ScrapStyle
            // 
            this.label_ScrapStyle.AutoSize = true;
            this.label_ScrapStyle.Location = new System.Drawing.Point(12, 42);
            this.label_ScrapStyle.Name = "label_ScrapStyle";
            this.label_ScrapStyle.Size = new System.Drawing.Size(63, 13);
            this.label_ScrapStyle.TabIndex = 3;
            this.label_ScrapStyle.Text = "Scrap Items";
            // 
            // textBox_URL
            // 
            this.textBox_URL.Location = new System.Drawing.Point(101, 66);
            this.textBox_URL.Name = "textBox_URL";
            this.textBox_URL.Size = new System.Drawing.Size(171, 20);
            this.textBox_URL.TabIndex = 4;
            // 
            // label_URL
            // 
            this.label_URL.AutoSize = true;
            this.label_URL.Location = new System.Drawing.Point(12, 69);
            this.label_URL.Name = "label_URL";
            this.label_URL.Size = new System.Drawing.Size(29, 13);
            this.label_URL.TabIndex = 5;
            this.label_URL.Text = "URL";
            // 
            // textBox_OutputLocation
            // 
            this.textBox_OutputLocation.Location = new System.Drawing.Point(101, 92);
            this.textBox_OutputLocation.Name = "textBox_OutputLocation";
            this.textBox_OutputLocation.Size = new System.Drawing.Size(171, 20);
            this.textBox_OutputLocation.TabIndex = 6;
            // 
            // label_OutputLocation
            // 
            this.label_OutputLocation.AutoSize = true;
            this.label_OutputLocation.Location = new System.Drawing.Point(12, 99);
            this.label_OutputLocation.Name = "label_OutputLocation";
            this.label_OutputLocation.Size = new System.Drawing.Size(83, 13);
            this.label_OutputLocation.TabIndex = 7;
            this.label_OutputLocation.Text = "Output Location";
            // 
            // button_Scrap
            // 
            this.button_Scrap.Location = new System.Drawing.Point(197, 118);
            this.button_Scrap.Name = "button_Scrap";
            this.button_Scrap.Size = new System.Drawing.Size(75, 23);
            this.button_Scrap.TabIndex = 8;
            this.button_Scrap.Text = "Scrap";
            this.button_Scrap.UseVisualStyleBackColor = true;
            this.button_Scrap.Click += new System.EventHandler(this.button_Scrap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 150);
            this.Controls.Add(this.button_Scrap);
            this.Controls.Add(this.label_OutputLocation);
            this.Controls.Add(this.textBox_OutputLocation);
            this.Controls.Add(this.label_URL);
            this.Controls.Add(this.textBox_URL);
            this.Controls.Add(this.label_ScrapStyle);
            this.Controls.Add(this.comboBox_ScrapStyle);
            this.Controls.Add(this.label_ScrapBehavior);
            this.Controls.Add(this.comboBox_ScrapBehavior);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_ScrapBehavior;
        private System.Windows.Forms.Label label_ScrapBehavior;
        private System.Windows.Forms.ComboBox comboBox_ScrapStyle;
        private System.Windows.Forms.Label label_ScrapStyle;
        private System.Windows.Forms.TextBox textBox_URL;
        private System.Windows.Forms.Label label_URL;
        private System.Windows.Forms.TextBox textBox_OutputLocation;
        private System.Windows.Forms.Label label_OutputLocation;
        private System.Windows.Forms.Button button_Scrap;

    }
}

