using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace EnableEnterpriseMode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (get_XML())
            {
                if (getEM() == fileName())
                {
                    emBox.Checked = true;
                    inputLink.ReadOnly = true;
                }
                else
                {
                    inputLink.Text = "";
                }
            }

            string ieVersion = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Internet Explorer").GetValue("Version").ToString();
            string[] sep = new string[] { "." };
            string[] result = ieVersion.Split(sep, StringSplitOptions.None);
            ieVerLabel.Text = "Version of IE installed: " + result[1];
        }

        private void emBox_CheckChanged(object sender, EventArgs e)
        {
            if (emBox.Checked == true)
            {
                if (!setEM()) //if setting the Enterprise Mode Reg fails, uncheck the box
                {
                    emBox.Checked = false;
                }
            }
            else //else, if box is unchecked, to try delete the key:
            {
                try
                {
                    inputLink.ReadOnly = false;
                    disableLabel.Text = "";
                    Microsoft.Win32.Registry.CurrentUser.DeleteSubKeyTree(@"Software\Policies\Microsoft\Internet Explorer\Main\EnterpriseMode");
                }
                catch { }
            }
        }

        private bool get_XML()
        {
            bool ret = false;
            try
            {
                XElement xml = XElement.Load(fileName()).Element("emie").Element("domain");
                inputLink.Text = xml.Value.ToString();
                ret = true;
            }
            catch { }//could not load xml file
            return ret;
        }

        private bool set_XML()
        {
            XElement rules = new XElement("rules");
            rules.SetAttributeValue("version","1");

            XElement em = new XElement("emie");

            XElement domain = new XElement("domain",inputLink.Text);
            domain.SetAttributeValue("exclude","false");

            em.Add(domain);
            rules.Add(em);

            XDocument doc = new XDocument(rules);

            //doc.Save(fileName); //We can do this because EM doesn't accept the xml it generates
            System.IO.File.WriteAllText(fileName(), doc.ToString()); //it does accept this though

            return true;
        }

        private string getEM()
        {
            string emVal = "";
            try
            {
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Policies\Microsoft\Internet Explorer\Main\EnterpriseMode");
                emVal = key.GetValue("SiteList").ToString();
                key.Close();
            }
            catch { }
            return emVal;
        }

        private bool setEM()
        {
            bool ret = false;
            try
            {
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Policies\Microsoft\Internet Explorer\Main\EnterpriseMode");
                key.SetValue("Enable", "");
                key.SetValue("SiteList", fileName());
                key.Close();
                ret = set_XML();
                inputLink.ReadOnly = ret;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("The system is showing that you do not have Administrator Access.\n\nPlease check with your system admin.");
            }
            return ret;
        }

        private string fileName()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "sitelist.xml");
        }

        private void inputLink_ReadOnlyChanged(object sender, EventArgs e)
        {
            if (inputLink.ReadOnly == true)
            {
                disableLabel.Text = "Locked";
            }
            else
            {
                disableLabel.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enable EnterpriseMode (google it...)\n\n1)Enter Site Into Textbox\n2)Click Enable\n3)Open Internet Explorer\n4)Navigate to Website\n\nUnfortunately, IE will not detect a site change until it detects that it's been disabled then redetects that it's been enabled. To update the site you must:\n1)Disable\n2)Close all open IE windows then reopen IE\n3)Close the newly opened IE window (now it is ready to detect your new site)\n4)Add site and enable\n5)Re-open IE.\n\nbduncan1125@gmail.com");
        }

    }
}
