﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using DnDApp.register;

namespace DnDApp
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {

            ReadSetting();
            if (!passwordFilled)
            {
                Login.Enabled = false;
            }
            else
            {
                Login.Enabled = true;

            }

        }

        private void ReadSetting()
        {
            var appSettings = Properties.Settings.Default.password;

            if(appSettings == "")
            {
                passwordFilled = false;

            }
            else
            {
                passwordFilled = true;
            }
        }


        private void Register_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Register reg = new Register();
            reg.Show();
        }

       public bool passwordFilled = false;

    }
}
