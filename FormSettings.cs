using System;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace InPay
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();

            LoadSettings();
        }

         public void LoadSettings()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            /* DATABASE TAB */
            txtDSN.Text                 = config.AppSettings.Settings["DSN"].Value;
            txtServer.Text              = config.AppSettings.Settings["Server"].Value;
            txtDatabase.Text            = config.AppSettings.Settings["Database"].Value;
            txtUserID.Text              = config.AppSettings.Settings["UserID"].Value;
            txtPassword.Text            = config.AppSettings.Settings["Password"].Value;

            /* QUICKBOOKS TAB */
            txtQBDSN.Text = config.AppSettings.Settings["QBDSN"].Value;
            txtQBFilePath.Text = config.AppSettings.Settings["TPQBFilePath"].Value; //QUICK BOOKS FILE
            cbxQBLookBack.SelectedItem = config.AppSettings.Settings["daysBack"].Value;

            /* TRANSACTION PRO TAB */
            txtTPPath.Text = config.AppSettings.Settings["TPPath"].Value;
            txtTPExeFileName.Text = config.AppSettings.Settings["TPExeFile"].Value;
            txtTPVersion.Text = config.AppSettings.Settings["TPAppVersion"].Value;
            txtTPMapFilePayments.Text = config.AppSettings.Settings["TPMapFilePayments"].Value; //RECEIVE PAYMENT - MAP
            txtTPDBTableNamePayments.Text = config.AppSettings.Settings["TPDBTableSourcePayments"].Value; //RECEIVE PAYMENT - DATA SOURCE

            if (config.AppSettings.Settings["TPConnectRetryInterval"] != null)
            {
                cbxTPConnectRetry.SelectedItem = config.AppSettings.Settings["TPConnectRetryInterval"].Value + " min";
            }
            
            //AUTO_ASSIGN (1 or 0)
            if (config.AppSettings.Settings["TPAutoAssign"].Value == "1")
            {
                rbTPAutoAssignYes.Checked = true;
            }else
            {
                rbTPAutoAssignNo.Checked = true;
            }
            //AUTORUN (1 or 0)
            if (config.AppSettings.Settings["TPAutoRun"].Value == "1")
            {
                rbTPAutoRunYes.Checked = true;
            }
            else
            {
                rbTPAutoRunNo.Checked = true;
            }
            //FILE_SOURCE=DSN (add or do not add)
            if (config.AppSettings.Settings["TPFileSource"].Value == "1")
            {
                rbTPSourceDSNYes.Checked = true;
            }
            else
            {
                rbTPSourceDSNNo.Checked = true;
            }
            // DEBUG (0 or 1)
            if (config.AppSettings.Settings["TPDebug"].Value == "1")
            {
                rbTPDebugYes.Checked = true;
            }
            else
            {
                rbTPDebugNo.Checked = true;
            }
            // LOG_ERROR (add / not add)
            if (config.AppSettings.Settings["TPLogError"].Value == "1")
            {
                rbTPLogErrorYes.Checked = true;
            }
            else
            {
                rbTPLogErrorNo.Checked = true;
            }
            // LOG_FILE (text)
            txtTPLogFolder.Text = config.AppSettings.Settings["TPLogFile"].Value;
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings.ActiveForm.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Init ini = Init.Instance();

            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            /* DATABASE TAB */
            config.AppSettings.Settings["DSN"].Value = txtDSN.Text;
            config.AppSettings.Settings["Server"].Value = txtServer.Text;
            config.AppSettings.Settings["Database"].Value = txtDatabase.Text;
            config.AppSettings.Settings["UserID"].Value = txtUserID.Text;
            config.AppSettings.Settings["Password"].Value = txtPassword.Text;

            /* QUICKBOOKS TAB */
            config.AppSettings.Settings["QBDSN"].Value = txtQBDSN.Text;
            config.AppSettings.Settings["TPQBFilePath"].Value = txtQBFilePath.Text;
            config.AppSettings.Settings["daysBack"].Value = cbxQBLookBack.SelectedItem.ToString();

            /* TRANSACTION PRO TAB */
            config.AppSettings.Settings["TPPath"].Value = txtTPPath.Text;
            config.AppSettings.Settings["TPExeFile"].Value = txtTPExeFileName.Text;
            config.AppSettings.Settings["TPAppVersion"].Value = txtTPVersion.Text;
            config.AppSettings.Settings["TPMapFilePayments"].Value = txtTPMapFilePayments.Text; //RECEIVE PAYMENT - MAP
            config.AppSettings.Settings["TPDBTableSourcePayments"].Value = txtTPDBTableNamePayments.Text;  //RECEIVE PAYMENT - DATA SOURCE
            config.AppSettings.Settings["TPConnectRetryInterval"].Value = cbxTPConnectRetry.SelectedItem.ToString().Replace(" min","");
            if (rbTPAutoAssignYes.Checked)
            {
                config.AppSettings.Settings["TPAutoAssign"].Value = "1";
            }
            else
            {
                config.AppSettings.Settings["TPAutoAssign"].Value = "0";
            }
            //AUTORUN (1 or 0)
            if (rbTPAutoRunYes.Checked)
            {
                config.AppSettings.Settings["TPAutoRun"].Value = "1";
            }
            else
            {
                config.AppSettings.Settings["TPAutoRun"].Value = "0";
            }
            //FILE_SOURCE=DSN (add or do not add)
            if (rbTPSourceDSNYes.Checked)
            {
                config.AppSettings.Settings["TPFileSource"].Value = "1";
            }
            else
            {
                config.AppSettings.Settings["TPFileSource"].Value = "0";
            }

            // DEBUG (0 or 1)
            if (rbTPDebugYes.Checked)
            {
                config.AppSettings.Settings["TPDebug"].Value = "1";
            }
            else
            {
                config.AppSettings.Settings["TPDebug"].Value = "0";
            }
            // LOG_ERROR (add / not add)
            if (rbTPLogErrorYes.Checked)
            {
                config.AppSettings.Settings["TPLogError"].Value = "1";
            }
            else
            {
                config.AppSettings.Settings["TPLogError"].Value = "0";
            }
            // LOG_FILE (text)
            config.AppSettings.Settings["TPLogFile"].Value = txtTPLogFolder.Text;

            config.Save();
            ini.Reload();

            FormSettings.ActiveForm.Close();
        }

        private void btnBrowseAppPath_Click(object sender, EventArgs e)
        {
            if (txtTPPath.Text != "")
            {
                openExeFileDialog.InitialDirectory = txtTPPath.Text;
            } else
            {
                openExeFileDialog.RestoreDirectory = true;
            }

            DialogResult result = openExeFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    string fileName = Path.GetFileName(openExeFileDialog.FileName);
                    string filePath = Path.GetDirectoryName(openExeFileDialog.FileName);

                    txtTPExeFileName.Text = fileName;
                    txtTPPath.Text = filePath;
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show(this, "Unable to get selected file path.", "Warning", MessageBoxButtons.OK);
                }
            }
        }

        private void btnTPBrowseLogFolder_Click(object sender, EventArgs e)
        {
            if (txtTPLogFolder.Text != "")
            {
                openLogFolderDialog.SelectedPath = txtTPLogFolder.Text;
            }
            DialogResult result = openLogFolderDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    string folderName = openLogFolderDialog.SelectedPath;
                    txtTPLogFolder.Text = folderName;
                }
                catch (InvalidOperationException)
                {
                    DialogResult dr = MessageBox.Show(this, "Unable to get selected folder.", "Warning", MessageBoxButtons.OK);
                }
            }
        }

        private void btnTPBrowseMapFilePay_Click(object sender, EventArgs e)
        {
            if (txtTPMapFilePayments.Text != "")
            {
                openMapFileDialogPayments.InitialDirectory = Path.GetDirectoryName(txtTPMapFilePayments.Text);
            }
            else
            {
                openMapFileDialogPayments.RestoreDirectory = true;
            }
            DialogResult result = openMapFileDialogPayments.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    string file = openMapFileDialogPayments.FileName;

                    txtTPMapFilePayments.Text = file;
                }
                catch (InvalidOperationException)
                {
                    DialogResult dr = MessageBox.Show(this, "Unable to get selected map file.", "Warning", MessageBoxButtons.OK);
                }
            }
        }

        private void btnTPBrowseQBFilePath_Click_1(object sender, EventArgs e)
        {
            if (txtQBFilePath.Text != "")
            {
                openQBCompanyFileDialog.InitialDirectory = Path.GetDirectoryName(txtQBFilePath.Text);
            }
            else
            {
                openQBCompanyFileDialog.RestoreDirectory = true;
            }
            openQBCompanyFileDialog.ValidateNames = false;
            DialogResult result = openQBCompanyFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    string file = openQBCompanyFileDialog.FileName;
                    txtQBFilePath.Text = file;
                }
                catch (InvalidOperationException)
                {
                    DialogResult dr = MessageBox.Show(this, "Unable to get company file.", "Warning", MessageBoxButtons.OK);
                }
                
            }
        }
    }
}
