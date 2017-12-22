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
            this.ButtonLaplacian = new System.Windows.Forms.Button();
            this.ButtonOtherMethod = new System.Windows.Forms.Button();
            this.ButtonLoadImage = new System.Windows.Forms.Button();
            this.ButtonSaveImage = new System.Windows.Forms.Button();
            this.TxtBoxNewName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImageSource
            // 
            this.pictureBoxImageSource.InitialImage = null;
            this.pictureBoxImageSource.Location = new System.Drawing.Point(12, 61);
            this.pictureBoxImageSource.Name = "pictureBoxImageSource";
            this.pictureBoxImageSource.Size = new System.Drawing.Size(240, 180);
            this.pictureBoxImageSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImageSource.TabIndex = 0;
            this.pictureBoxImageSource.TabStop = false;
            // 
            // pictureBoxNewImage
            // 
            this.pictureBoxNewImage.Location = new System.Drawing.Point(276, 61);
            this.pictureBoxNewImage.Name = "pictureBoxNewImage";
            this.pictureBoxNewImage.Size = new System.Drawing.Size(640, 480);
            this.pictureBoxNewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNewImage.TabIndex = 1;
            this.pictureBoxNewImage.TabStop = false;
            // 
            // ButtonLaplacian
            // 
            this.ButtonLaplacian.Location = new System.Drawing.Point(276, 12);
            this.ButtonLaplacian.Name = "ButtonLaplacian";
            this.ButtonLaplacian.Size = new System.Drawing.Size(75, 43);
            this.ButtonLaplacian.TabIndex = 2;
            this.ButtonLaplacian.Text = "Lapiacian 3x3";
            this.ButtonLaplacian.UseVisualStyleBackColor = true;
            this.ButtonLaplacian.Click += new System.EventHandler(this.ButtonLaplacian_Click);
            // 
            // ButtonOtherMethod
            // 
            this.ButtonOtherMethod.Location = new System.Drawing.Point(357, 12);
            this.ButtonOtherMethod.Name = "ButtonOtherMethod";
            this.ButtonOtherMethod.Size = new System.Drawing.Size(75, 43);
            this.ButtonOtherMethod.TabIndex = 3;
            this.ButtonOtherMethod.Text = "Set green color filter";
            this.ButtonOtherMethod.UseVisualStyleBackColor = true;
            this.ButtonOtherMethod.Click += new System.EventHandler(this.ButtonOtherMethod_Click);
            // 
            // ButtonLoadImage
            // 
            this.ButtonLoadImage.Location = new System.Drawing.Point(12, 12);
            this.ButtonLoadImage.Name = "ButtonLoadImage";
            this.ButtonLoadImage.Size = new System.Drawing.Size(75, 43);
            this.ButtonLoadImage.TabIndex = 4;
            this.ButtonLoadImage.Text = "Load Image";
            this.ButtonLoadImage.UseVisualStyleBackColor = true;
            this.ButtonLoadImage.Click += new System.EventHandler(this.ButtonLoadImage_Click);
            // 
            // ButtonSaveImage
            // 
            this.ButtonSaveImage.Location = new System.Drawing.Point(841, 12);
            this.ButtonSaveImage.Name = "ButtonSaveImage";
            this.ButtonSaveImage.Size = new System.Drawing.Size(75, 43);
            this.ButtonSaveImage.TabIndex = 5;
            this.ButtonSaveImage.Text = "Save Image";
            this.ButtonSaveImage.UseVisualStyleBackColor = true;
            this.ButtonSaveImage.Click += new System.EventHandler(this.ButtonSaveImage_Click);
            // 
            // TxtBoxNewName
            // 
            this.TxtBoxNewName.Location = new System.Drawing.Point(723, 24);
            this.TxtBoxNewName.Name = "TxtBoxNewName";
            this.TxtBoxNewName.Size = new System.Drawing.Size(112, 20);
            this.TxtBoxNewName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter the new Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxNewName);
            this.Controls.Add(this.ButtonSaveImage);
            this.Controls.Add(this.ButtonLoadImage);
            this.Controls.Add(this.ButtonOtherMethod);
            this.Controls.Add(this.ButtonLaplacian);
            this.Controls.Add(this.pictureBoxNewImage);
            this.Controls.Add(this.pictureBoxImageSource);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImageSource;
        private System.Windows.Forms.PictureBox pictureBoxNewImage;
        private System.Windows.Forms.Button ButtonOtherMethod;
        private System.Windows.Forms.Button ButtonLaplacian;
        private System.Windows.Forms.Button ButtonLoadImage;
        private System.Windows.Forms.Button ButtonSaveImage;
        private System.Windows.Forms.TextBox TxtBoxNewName;
        private System.Windows.Forms.Label label1;
    }
}

