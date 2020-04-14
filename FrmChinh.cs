﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CuaHangGiayDep
{
    public partial class FrmChinh : Form
    {
        public FrmChinh()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Functions.Connection();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Functions.Disconnect();
            Application.Exit();
        }

        private void mnuCo_Click(object sender, EventArgs e)
        {
            FrmCo DM_Co = new FrmCo();
            DM_Co.ShowDialog();

        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            FrmChatLieu DM_CL = new FrmChatLieu();
            DM_CL.ShowDialog();
        }
    }
}