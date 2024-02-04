using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CG.Web.MegaApiClient;
using System.Configuration;


namespace BackupManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string selectBackupFile()
        {
            dia_backupfile.Filter = "Zipped (*.zip)|*.zip|WinRaR (*.rar)|*.rar|7-Zip (*.7z)|*.7z";
            dia_backupfile.FilterIndex = 1;
            DialogResult result = dia_backupfile.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = dia_backupfile.FileName;

                try
                {
                    return file;
                }
                catch (IOException err)
                {
                    return MessageBox.Show($"An error occurred while selecting the archive: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString();
                }
            }
            return "No file selected.";
        }

        private void btn_backupbrowse_Click(object sender, EventArgs e)
        {
            inp_filebackup.Text = selectBackupFile();
        }

        void uploadToMega()
        {
            var client = new MegaApiClient();
            client.Login("REDACTED", "REDACTED");

            IEnumerable<INode> nodes = client.GetNodes();

            /* var link = new Uri("https://mega.nz/fm/" + inp_folderid);
            IEnumerable<INode> urinodes = client.GetNodesFromLink(link);*/
            string date = DateTime.Now.ToString("dMMyyyy");
            string time = DateTime.Now.ToString("fffffff");

            INode root = nodes.Single(x => x.Id == inp_folderid.Text);
            INode folder = client.CreateFolder("set_" + date + "_" + time, root);
            INode myFile = client.UploadFile(inp_filebackup.Text, folder);

            MessageBox.Show("Archive was succesfully uploaded to the cloud.", "Archive Transfer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lbl_uploadresp.ForeColor = Color.FromArgb(0, 192, 0);
            lbl_uploadresp.Text = "Uploaded!";


            /*IEnumerable<INode> children = nodes.Where(x => x.ParentId == root.Id);

            foreach (INode child in children)
            {
                if (child.Name == "set_" + date)
                {
                    INode folder = client.CreateFolder("set_" + date, child);
                    INode myFile = client.UploadFile(inp_filebackup.Text, folder);
                } else
                {
                    INode folder = client.CreateFolder("set_" + date, root);
                    INode myFile = client.UploadFile(inp_filebackup.Text, folder);
                }
            } */

            client.Logout();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("It's always recommended to lock the archive with a password for an extra layer of security. Do you wish to continue?", "Archive Security", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            try
            {
                if (File.Exists(inp_filebackup.Text) && !String.IsNullOrEmpty(inp_folderid.Text))
                {
                    switch (Path.GetExtension(inp_filebackup.Text))
                    {
                        case ".zip":
                            if (confirm == DialogResult.Yes)
                            {
                                uploadToMega();
                            }
                            else
                            {
                                MessageBox.Show("Transfer to cloud canceled.", "Security", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;
                        case ".rar":
                            if (confirm == DialogResult.Yes)
                            {
                                uploadToMega();
                            }
                            else
                            {
                                MessageBox.Show("Transfer to cloud canceled.", "Security", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;
                        case ".7z":
                            if (confirm == DialogResult.Yes)
                            {
                                uploadToMega();
                            }
                            else
                            {
                                MessageBox.Show("Transfer to cloud canceled.", "Security", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;
                        default:
                            MessageBox.Show("Unsupported file type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            inp_filebackup.BackColor = Color.FromArgb(255, 109, 102);
                            break;
                    }
                }
                else if (String.IsNullOrEmpty(inp_filebackup.Text) ||inp_filebackup.Text == "No file selected.")
                {
                    MessageBox.Show("Field cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    inp_filebackup.BackColor = Color.FromArgb(255, 109, 102);
                }
                else if (String.IsNullOrEmpty(inp_folderid.Text))
                {
                    MessageBox.Show("Field cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    inp_folderid.BackColor = Color.FromArgb(255, 109, 102);
                }
                else
                {
                    MessageBox.Show("File could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    inp_filebackup.BackColor = Color.FromArgb(255, 109, 102);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"An error occurred while uploading files to the cloud: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
