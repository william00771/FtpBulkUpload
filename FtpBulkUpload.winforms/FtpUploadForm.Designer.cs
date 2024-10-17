namespace FtpBulkUpload.winforms
{
    partial class FtpUploadForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelLocalDir;
        private System.Windows.Forms.TextBox textBoxLocalDir;
        private System.Windows.Forms.Label labelRemoteDir;
        private System.Windows.Forms.TextBox textBoxRemoteDir;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Label labelStatus;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            int labelWidth = 100;
            int textBoxXPosition = labelWidth + 80;
            
            this.labelHost = new System.Windows.Forms.Label();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLocalDir = new System.Windows.Forms.Label();
            this.textBoxLocalDir = new System.Windows.Forms.TextBox();
            this.labelRemoteDir = new System.Windows.Forms.Label();
            this.textBoxRemoteDir = new System.Windows.Forms.TextBox();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();

            // ftpHost - Label
            this.labelHost.AutoSize = true;
            this.labelHost.Location = new System.Drawing.Point(20, 20);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(labelWidth, 13);
            this.labelHost.Text = "FTP Host:";

            // ftpHost - Input
            this.textBoxHost.Location = new System.Drawing.Point(textBoxXPosition, 20);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(200, 20);

            // ftpPort - Label
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(20, 60);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(labelWidth, 13);
            this.labelPort.Text = "Port:";

            // ftpPort - Input
            this.textBoxPort.Location = new System.Drawing.Point(textBoxXPosition, 60);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(200, 20);

            // ftpUsername - Label
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(20, 100);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(labelWidth, 13);
            this.labelUser.Text = "Username:";

            // ftpUsername - Input
            this.textBoxUser.Location = new System.Drawing.Point(textBoxXPosition, 100);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(200, 20);

            // ftpPassword - Label
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(20, 140);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(labelWidth, 13);
            this.labelPassword.Text = "Password:";

            // ftpPassword - Input
            this.textBoxPassword.Location = new System.Drawing.Point(textBoxXPosition, 140);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(200, 20);

            // Local Directory - Label
            this.labelLocalDir.AutoSize = true;
            this.labelLocalDir.Location = new System.Drawing.Point(20, 180);
            this.labelLocalDir.Name = "labelLocalDir";
            this.labelLocalDir.Size = new System.Drawing.Size(labelWidth, 13);
            this.labelLocalDir.Text = "Local Directory:";

            // Local Directory - Input
            this.textBoxLocalDir.Location = new System.Drawing.Point(textBoxXPosition, 180);
            this.textBoxLocalDir.Name = "textBoxLocalDir";
            this.textBoxLocalDir.Size = new System.Drawing.Size(200, 20);

            // Remote Directory - Label
            this.labelRemoteDir.AutoSize = true;
            this.labelRemoteDir.Location = new System.Drawing.Point(20, 220);
            this.labelRemoteDir.Name = "labelRemoteDir";
            this.labelRemoteDir.Size = new System.Drawing.Size(labelWidth, 13);
            this.labelRemoteDir.Text = "Remote Directory:";

            // Remote Directory - Input
            this.textBoxRemoteDir.Location = new System.Drawing.Point(textBoxXPosition, 220);
            this.textBoxRemoteDir.Name = "textBoxRemoteDir";
            this.textBoxRemoteDir.Size = new System.Drawing.Size(200, 20);

            // Upload Button
            this.buttonUpload.Location = new System.Drawing.Point(textBoxXPosition, 260);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(100, 30);
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.ButtonUpload_Click);

            // Status Label
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(20, 300);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(300, 13);
            this.labelStatus.Text = "";

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 340);
            this.Controls.Add(this.labelHost);
            this.Controls.Add(this.textBoxHost);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelLocalDir);
            this.Controls.Add(this.textBoxLocalDir);
            this.Controls.Add(this.labelRemoteDir);
            this.Controls.Add(this.textBoxRemoteDir);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.labelStatus);
            this.Name = "Form1";
            this.Text = "FTP Bulk Upload";
        }

        #endregion
    }
}