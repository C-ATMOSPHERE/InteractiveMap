namespace InteractiveMap
{
    partial class InfoWindow
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
            this.InfoImage = new System.Windows.Forms.PictureBox();
            this.InfoText = new System.Windows.Forms.TextBox();
            this.InfoCaption = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InfoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoImage
            // 
            this.InfoImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.InfoImage.Location = new System.Drawing.Point(12, 12);
            this.InfoImage.Name = "InfoImage";
            this.InfoImage.Size = new System.Drawing.Size(817, 225);
            this.InfoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InfoImage.TabIndex = 0;
            this.InfoImage.TabStop = false;
            this.InfoImage.Click += new System.EventHandler(this.InfoImage_Click);
            // 
            // InfoText
            // 
            this.InfoText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.InfoText.Cursor = System.Windows.Forms.Cursors.Default;
            this.InfoText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.InfoText.Location = new System.Drawing.Point(12, 278);
            this.InfoText.Multiline = true;
            this.InfoText.Name = "InfoText";
            this.InfoText.ReadOnly = true;
            this.InfoText.Size = new System.Drawing.Size(817, 137);
            this.InfoText.TabIndex = 1;
            this.InfoText.Text = "<b>Cтарокрымский</b> литературно-художественный музей";
            // 
            // InfoCaption
            // 
            this.InfoCaption.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.InfoCaption.AutoSize = true;
            this.InfoCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoCaption.Location = new System.Drawing.Point(12, 240);
            this.InfoCaption.Name = "InfoCaption";
            this.InfoCaption.Size = new System.Drawing.Size(97, 35);
            this.InfoCaption.TabIndex = 2;
            this.InfoCaption.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(817, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InfoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 460);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InfoCaption);
            this.Controls.Add(this.InfoText);
            this.Controls.Add(this.InfoImage);
            this.Name = "InfoWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InfoWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InfoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox InfoImage;
        private System.Windows.Forms.TextBox InfoText;
        private System.Windows.Forms.Label InfoCaption;
        private System.Windows.Forms.Button button1;
    }
}