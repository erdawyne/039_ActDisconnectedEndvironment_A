﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisconnectedEndvironment
{
    public partial class Form1 : Form
    {
        DataTable dt;
        DataRow dr;
        string code;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRDataSet.empdetails' table. You can move, or remove it, as needed.
            this.empdetailsTableAdapter.Fill(this.hRDataSet.empdetails);
            //This line of code loads data into the
            //hRDataSet.empdetails table. This would appear in
            //Form 1_Load event
            this.empdetailsTableAdapter.Fill(this.hRDataSet.empdetails);

            txtCode.Enabled = false;
            txtName.Enabled = false;
            txtAddress.Enabled = false;
            txtState.Enabled = false;
            txtCountry.Enabled = false;
            cbDesignation.Enabled = false;
            cbDepartement.Enabled = false;

            cbDesignation.Items.Add("MANAGER");
            cbDesignation.Items.Add("AUTHOR");
            cbDesignation.Items.Add("Designer");
            cbDesignation.Items.Add("MARKETING");
            cbDesignation.Items.Add("FINANCE");
            cbDesignation.Items.Add("IDD");
            cmdSave.Enabled = false;

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
