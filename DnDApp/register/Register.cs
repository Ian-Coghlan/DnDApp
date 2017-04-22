using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;
using System.Windows.Forms;

namespace DnDApp.register
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {

            string username = username_Field.Text;

            UpdateSetting("username", username);

        }

        private static void UpdateSetting(string key, string value)
        {
            //Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //configuration.AppSettings.Settings[key].Value = value;
            //configuration.Save();
            //ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
