using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BlockUrlViaForms
{
    public partial class BlockURL : Form
    {

        public string HostFileLocation = $@"{Environment.GetFolderPath(Environment.SpecialFolder.System)}\drivers\etc";
        public string HostFileName = "hosts";
        public string BackupFileExtension = ".bak";
        public string Ipaddress = "127.0.0.1 ";

        public BlockURL()
        {
            InitializeComponent();

            try
            {
                if (File.Exists(Path.Combine(HostFileLocation, HostFileName +""+ BackupFileExtension)))
                {
                    MessageBox.Show("Backup file already exists. No need to take backup");
                    button1.Enabled = false;
                    btnAddUrl.Enabled = false;
                    textBox1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                    btnAddUrl.Enabled = true;
                    textBox1.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Path.Combine(HostFileLocation, HostFileName)))
                {
                    File.Copy(Path.Combine(HostFileLocation, HostFileName), Path.Combine(HostFileLocation, HostFileName + "" + BackupFileExtension));
                    MessageBox.Show("Host file backup process has been completed successfully");
                }
                else
                {
                    MessageBox.Show("Host file does not exists!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(File.Exists(Path.Combine(HostFileLocation, HostFileName + "" + BackupFileExtension)))
            {
                MessageBox.Show("Backup host file exists!");
            }

            if(File.Exists(Path.Combine(HostFileLocation, HostFileName)))
            {
                MessageBox.Show("Current host file exists!");
            }

            //AddSecurityPermission();

            string[] backupHostsLines = File.ReadAllLines(Path.Combine(HostFileLocation, HostFileName + "" + BackupFileExtension));
            string[] currentHostsLines = File.ReadAllLines(Path.Combine(HostFileLocation, HostFileName));

            var urlsToBlock = currentHostsLines.Except(backupHostsLines).ToArray();

            var hostsLines = currentHostsLines.Where(line => !urlsToBlock.Any(urls => line.Contains(urls) && line.StartsWith("#127.0.0.1"))).ToArray();
            File.WriteAllLines(Path.Combine(HostFileLocation, HostFileName), hostsLines);

        }

        private void AddSecurityPermission()
        {
            string hostFilePath = Path.Combine(HostFileLocation, HostFileName);
            string userName = Environment.UserName;

            FileSecurity fileSecurity = File.GetAccessControl(hostFilePath);

            // Get the identity reference of the current user
            IdentityReference user = new NTAccount(userName);

            // Set the owner of the host file to the current user
            fileSecurity.SetOwner(user);

            // Replace the existing security settings of the host file with the new settings
            File.SetAccessControl(hostFilePath, fileSecurity);

            // Get a FileSecurity object that represents the new security settings of the host file
            fileSecurity = File.GetAccessControl(hostFilePath);

            // Add full control permission for the current user to the host file
            fileSecurity.AddAccessRule(new FileSystemAccessRule(user, FileSystemRights.FullControl, AccessControlType.Allow));

            // Replace the existing security settings of the host file with the new settings
            File.SetAccessControl(hostFilePath, fileSecurity);
        }

        private void btnSampleUrl_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Path.Combine(HostFileLocation, HostFileName + "" + BackupFileExtension)))
            {
                MessageBox.Show("Please take backup of host file");
                return;
            }

            List<string> urlsToBeBlockedList = new List<string>()
            {
                Ipaddress + "stackoverflow.com",
                Ipaddress + "github.com",
                Ipaddress + "www.facebook.com",
                Ipaddress + "twitter.com"
            };

            foreach (string urlToBeBlocked in urlsToBeBlockedList)
            {
                using (var stream = new StreamWriter(Path.Combine(HostFileLocation, HostFileName), true, Encoding.Default))
                {
                    stream.WriteLine(urlToBeBlocked);
                }
            }
        }

        private void btnAddUrl_Click(object sender, EventArgs e)
        {
           
        }
    }
}
