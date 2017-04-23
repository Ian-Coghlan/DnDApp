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
            string password = password_Field.Text;
            string passwordConfirm = password_Confim_Field.Text;

            if(password == passwordConfirm)
            {
                UpdateSetting("username", username);

            }
            else
            {

            }



        }

        private static void UpdateSetting(string key, string username)
        {
            
            Properties.Settings.Default["username"] = username;
            Properties.Settings.Default.Save();

        }
    }
}
