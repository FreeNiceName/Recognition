namespace Recognition
{
    partial class TakePhotoDialog
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
            this.pbWebcam = new System.Windows.Forms.PictureBox();
            this.btTakePhoto = new System.Windows.Forms.Button();
            this.cbDevice = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbWebcam)).BeginInit();
            this.SuspendLayout();
            // 
            // pbWebcam
            // 
            this.pbWebcam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbWebcam.Location = new System.Drawing.Point(12, 50);
            this.pbWebcam.Name = "pbWebcam";
            this.pbWebcam.Size = new System.Drawing.Size(400, 300);
            this.pbWebcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWebcam.TabIndex = 0;
            this.pbWebcam.TabStop = false;
            // 
            // btTakePhoto
            // 
            this.btTakePhoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btTakePhoto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btTakePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btTakePhoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btTakePhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTakePhoto.Location = new System.Drawing.Point(12, 356);
            this.btTakePhoto.Name = "btTakePhoto";
            this.btTakePhoto.Size = new System.Drawing.Size(400, 60);
            this.btTakePhoto.TabIndex = 5;
            this.btTakePhoto.Text = "Take a photo";
            this.btTakePhoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTakePhoto.UseVisualStyleBackColor = false;
            this.btTakePhoto.Click += new System.EventHandler(this.btTakePhoto_Click);
            // 
            // cbDevice
            // 
            this.cbDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDevice.FormattingEnabled = true;
            this.cbDevice.Location = new System.Drawing.Point(12, 12);
            this.cbDevice.Name = "cbDevice";
            this.cbDevice.Size = new System.Drawing.Size(400, 32);
            this.cbDevice.TabIndex = 6;
            this.cbDevice.SelectedIndexChanged += new System.EventHandler(this.cbDevice_SelectedIndexChanged);
            // 
            // TakePhotoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 425);
            this.Controls.Add(this.cbDevice);
            this.Controls.Add(this.btTakePhoto);
            this.Controls.Add(this.pbWebcam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TakePhotoDialog";
            this.Text = "Photo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TakePhotoForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbWebcam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWebcam;
        private System.Windows.Forms.Button btTakePhoto;
        private System.Windows.Forms.ComboBox cbDevice;
    }
}