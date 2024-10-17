using WinSCP;

namespace FtpBulkUpload.winforms
{
    public partial class FtpUploadForm : Form
    {
        public FtpUploadForm()
        {
            InitializeComponent();
        }

        private async void ButtonUpload_Click(object sender, EventArgs e)
        {
            labelStatus.Text = "Connecting...";
            await Task.Delay(500);

            string ftpHost = textBoxHost.Text;
            if (!int.TryParse(textBoxPort.Text, out int ftpPort))
            {
                MessageBox.Show("Invalid port number.");
                labelStatus.Text = "Invalid port number. Please correct it.";
                return;
            }
            string ftpUser = textBoxUser.Text;
            string ftpPassword = textBoxPassword.Text;
            string localDirectory = textBoxLocalDir.Text;
            string remoteDirectory = textBoxRemoteDir.Text;

            SessionOptions sessionOptions = new SessionOptions
            {
                Protocol = Protocol.Ftp,
                HostName = ftpHost,
                PortNumber = ftpPort,
                UserName = ftpUser,
                Password = ftpPassword
            };

            bool connected = false;
            using (Session session = new Session())
            {
                try
                {
                    session.Open(sessionOptions);
                    connected = true;
                    labelStatus.Text = "Connection successful!";
                    await Task.Delay(500);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message);
                    labelStatus.Text = "Connection failed. Please check your settings.";
                    return;
                }

                if (connected)
                {
                    try
                    {
                        labelStatus.Text = "Uploading files...";
                        await Task.Delay(500);

                        TransferOptions transferOptions = new TransferOptions { TransferMode = TransferMode.Binary };
                        TransferOperationResult transferResult = session.PutFiles(localDirectory + @"\*", remoteDirectory, false, transferOptions);
                        transferResult.Check();

                        string uploadedFiles = "Files Uploaded:\n";
                        foreach (TransferEventArgs transfer in transferResult.Transfers)
                        {
                            uploadedFiles += $"- {transfer.FileName}\n";
                        }
                        labelStatus.Text = "Upload completed.";
                        MessageBox.Show(uploadedFiles, "Upload Summary");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("File transfer failed: " + ex.Message);
                        labelStatus.Text = "File transfer failed. Please try again.";
                    }
                }
            }
        }
    }
}