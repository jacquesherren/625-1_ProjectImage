namespace projectImageEdgeDetection
{
    partial class MainForm
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
            this.pictureBoxImageSource = new System.Windows.Forms.PictureBox();
            this.pictureBoxNewImage = new System.Windows.Forms.PictureBox();
            this.buttonLapiacian = new System.Windows.Forms.Button();
            this.buttonOtherMethod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImageSource
            // 
            this.pictureBoxImageSource.Image = global::projectImageEdgeDetection.Properties.Resources.source;
            this.pictureBoxImageSource.InitialImage = null;
            this.pictureBoxImageSource.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxImageSource.Name = "pictureBoxImageSource";
            this.pictureBoxImageSource.Size = new System.Drawing.Size(512, 341);
            this.pictureBoxImageSource.TabIndex = 0;
            this.pictureBoxImageSource.TabStop = false;
            // 
            // pictureBoxNewImage
            // 
            this.pictureBoxNewImage.Location = new System.Drawing.Point(611, 12);
            this.pictureBoxNewImage.Name = "pictureBoxNewImage";
            this.pictureBoxNewImage.Size = new System.Drawing.Size(512, 341);
            this.pictureBoxNewImage.TabIndex = 1;
            this.pictureBoxNewImage.TabStop = false;
            // 
            // buttonLapiacian
            // 
            this.buttonLapiacian.Location = new System.Drawing.Point(530, 12);
            this.buttonLapiacian.Name = "buttonLapiacian";
            this.buttonLapiacian.Size = new System.Drawing.Size(75, 35);
            this.buttonLapiacian.TabIndex = 2;
            this.buttonLapiacian.Text = "Lapiacian 3x3";
            this.buttonLapiacian.UseVisualStyleBackColor = true;
            this.buttonLapiacian.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOtherMethod
            // 
            this.buttonOtherMethod.Location = new System.Drawing.Point(530, 53);
            this.buttonOtherMethod.Name = "buttonOtherMethod";
            this.buttonOtherMethod.Size = new System.Drawing.Size(75, 38);
            this.buttonOtherMethod.TabIndex = 3;
            this.buttonOtherMethod.Text = "otherMethod";
            this.buttonOtherMethod.UseVisualStyleBackColor = true;
            this.buttonOtherMethod.Click += new System.EventHandler(this.buttonOtherMethod_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 362);
            this.Controls.Add(this.buttonOtherMethod);
            this.Controls.Add(this.buttonLapiacian);
            this.Controls.Add(this.pictureBoxNewImage);
            this.Controls.Add(this.pictureBoxImageSource);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImageSource;
        private System.Windows.Forms.PictureBox pictureBoxNewImage;
        private System.Windows.Forms.Button buttonOtherMethod;
        private System.Windows.Forms.Button buttonLapiacian;
    }
}

