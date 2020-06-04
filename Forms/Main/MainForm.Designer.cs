namespace Recognition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btFingerprint = new System.Windows.Forms.Button();
            this.lbChoose = new System.Windows.Forms.Label();
            this.btFace = new System.Windows.Forms.Button();
            this.btIris = new System.Windows.Forms.Button();
            this.panelPhotoUpload = new System.Windows.Forms.Panel();
            this.btTakePhoto = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.btPhotoUpload = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.panelResult = new System.Windows.Forms.Panel();
            this.lbResult = new System.Windows.Forms.Label();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.btResultBack = new System.Windows.Forms.Button();
            this.panelPhotoUpload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panelResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btFingerprint
            // 
            this.btFingerprint.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btFingerprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btFingerprint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btFingerprint.Image = ((System.Drawing.Image)(resources.GetObject("btFingerprint.Image")));
            this.btFingerprint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFingerprint.Location = new System.Drawing.Point(15, 91);
            this.btFingerprint.Name = "btFingerprint";
            this.btFingerprint.Size = new System.Drawing.Size(237, 76);
            this.btFingerprint.TabIndex = 1;
            this.btFingerprint.Text = "fingerprint recognition";
            this.btFingerprint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btFingerprint.UseVisualStyleBackColor = false;
            this.btFingerprint.Click += new System.EventHandler(this.btFingerprint_Click);
            // 
            // lbChoose
            // 
            this.lbChoose.AutoSize = true;
            this.lbChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbChoose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbChoose.Location = new System.Drawing.Point(11, 30);
            this.lbChoose.Name = "lbChoose";
            this.lbChoose.Size = new System.Drawing.Size(240, 40);
            this.lbChoose.TabIndex = 0;
            this.lbChoose.Text = "Choose one of the biometric \r\nauthentification methods";
            this.lbChoose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btFace
            // 
            this.btFace.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btFace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btFace.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btFace.Image = ((System.Drawing.Image)(resources.GetObject("btFace.Image")));
            this.btFace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFace.Location = new System.Drawing.Point(15, 191);
            this.btFace.Name = "btFace";
            this.btFace.Size = new System.Drawing.Size(237, 76);
            this.btFace.TabIndex = 2;
            this.btFace.Text = "face recognition";
            this.btFace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btFace.UseVisualStyleBackColor = false;
            this.btFace.Click += new System.EventHandler(this.btFace_Click);
            // 
            // btIris
            // 
            this.btIris.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btIris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btIris.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btIris.Image = ((System.Drawing.Image)(resources.GetObject("btIris.Image")));
            this.btIris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIris.Location = new System.Drawing.Point(15, 291);
            this.btIris.Name = "btIris";
            this.btIris.Size = new System.Drawing.Size(237, 76);
            this.btIris.TabIndex = 3;
            this.btIris.Text = "iris recognition";
            this.btIris.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btIris.UseVisualStyleBackColor = false;
            this.btIris.Click += new System.EventHandler(this.btIris_Click);
            // 
            // panelPhotoUpload
            // 
            this.panelPhotoUpload.Controls.Add(this.btTakePhoto);
            this.panelPhotoUpload.Controls.Add(this.btBack);
            this.panelPhotoUpload.Controls.Add(this.btPhotoUpload);
            this.panelPhotoUpload.Controls.Add(this.pbImage);
            this.panelPhotoUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPhotoUpload.Location = new System.Drawing.Point(0, 0);
            this.panelPhotoUpload.Name = "panelPhotoUpload";
            this.panelPhotoUpload.Size = new System.Drawing.Size(269, 405);
            this.panelPhotoUpload.TabIndex = 4;
            this.panelPhotoUpload.Visible = false;
            // 
            // btTakePhoto
            // 
            this.btTakePhoto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btTakePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btTakePhoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btTakePhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTakePhoto.Location = new System.Drawing.Point(17, 326);
            this.btTakePhoto.Name = "btTakePhoto";
            this.btTakePhoto.Size = new System.Drawing.Size(237, 60);
            this.btTakePhoto.TabIndex = 8;
            this.btTakePhoto.Text = "Take a photo";
            this.btTakePhoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTakePhoto.UseVisualStyleBackColor = false;
            this.btTakePhoto.Click += new System.EventHandler(this.btTakePhoto_Click);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.Transparent;
            this.btBack.FlatAppearance.BorderSize = 0;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btBack.Image = ((System.Drawing.Image)(resources.GetObject("btBack.Image")));
            this.btBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBack.Location = new System.Drawing.Point(14, 19);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(76, 31);
            this.btBack.TabIndex = 7;
            this.btBack.Text = "Back";
            this.btBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btPhotoUpload
            // 
            this.btPhotoUpload.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btPhotoUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btPhotoUpload.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btPhotoUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPhotoUpload.Location = new System.Drawing.Point(17, 260);
            this.btPhotoUpload.Name = "btPhotoUpload";
            this.btPhotoUpload.Size = new System.Drawing.Size(237, 60);
            this.btPhotoUpload.TabIndex = 6;
            this.btPhotoUpload.Text = "Upload a photo";
            this.btPhotoUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPhotoUpload.UseVisualStyleBackColor = false;
            this.btPhotoUpload.Click += new System.EventHandler(this.btPhotoUpload_Click);
            // 
            // pbImage
            // 
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.Location = new System.Drawing.Point(64, 88);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(142, 139);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 5;
            this.pbImage.TabStop = false;
            // 
            // panelResult
            // 
            this.panelResult.Controls.Add(this.btResultBack);
            this.panelResult.Controls.Add(this.lbResult);
            this.panelResult.Controls.Add(this.pbResult);
            this.panelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResult.Location = new System.Drawing.Point(0, 0);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(269, 405);
            this.panelResult.TabIndex = 9;
            this.panelResult.Visible = false;
            // 
            // lbResult
            // 
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbResult.Location = new System.Drawing.Point(17, 240);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(234, 44);
            this.lbResult.TabIndex = 1;
            this.lbResult.Text = "Loading...";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbResult
            // 
            this.pbResult.Image = ((System.Drawing.Image)(resources.GetObject("pbResult.Image")));
            this.pbResult.InitialImage = null;
            this.pbResult.Location = new System.Drawing.Point(49, 84);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(172, 155);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResult.TabIndex = 0;
            this.pbResult.TabStop = false;
            // 
            // btResultBack
            // 
            this.btResultBack.BackColor = System.Drawing.Color.Transparent;
            this.btResultBack.FlatAppearance.BorderSize = 0;
            this.btResultBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btResultBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btResultBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btResultBack.Image = ((System.Drawing.Image)(resources.GetObject("btResultBack.Image")));
            this.btResultBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btResultBack.Location = new System.Drawing.Point(14, 19);
            this.btResultBack.Name = "btResultBack";
            this.btResultBack.Size = new System.Drawing.Size(76, 31);
            this.btResultBack.TabIndex = 8;
            this.btResultBack.Text = "Back";
            this.btResultBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btResultBack.UseVisualStyleBackColor = false;
            this.btResultBack.Visible = false;
            this.btResultBack.Click += new System.EventHandler(this.btResultBack_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 405);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.panelPhotoUpload);
            this.Controls.Add(this.btIris);
            this.Controls.Add(this.btFace);
            this.Controls.Add(this.lbChoose);
            this.Controls.Add(this.btFingerprint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recognition";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panelPhotoUpload.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panelResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFingerprint;
        private System.Windows.Forms.Label lbChoose;
        private System.Windows.Forms.Button btFace;
        private System.Windows.Forms.Button btIris;
        private System.Windows.Forms.Panel panelPhotoUpload;
        private System.Windows.Forms.Button btTakePhoto;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btPhotoUpload;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.Button btResultBack;
    }
}

