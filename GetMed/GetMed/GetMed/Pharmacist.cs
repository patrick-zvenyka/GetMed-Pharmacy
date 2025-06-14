﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetMed
{
    public partial class Pharmacist : Form
    {
        
        public Pharmacist()
        {
            InitializeComponent();
        }
        
          
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure, you want to log out?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();
            }
            else if (dialog == DialogResult.No)
            {
                this.Show();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_P_Dashboard1.Visible = true;
            uC_P_Dashboard1.BringToFront();
        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {
            uC_P_Dashboard1.Visible = false;
            uC_P_AddMedicine1.Visible = false;
            uC_P_Stock1.Visible = false;
            uC_P_UpdateMed1.Visible = false;
            uC_P_MedicineValidity1.Visible = false;
            uC_P_SellMed1.Visible = false;
            btnDashboard.PerformClick();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            uC_P_AddMedicine1.Visible = true;
            uC_P_AddMedicine1.BringToFront();
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            uC_P_Stock1.Visible = true;
            uC_P_Stock1.BringToFront();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            uC_P_UpdateMed1.Visible = true;
            uC_P_UpdateMed1.BringToFront();
        }

        private void btnMedValidity_Click(object sender, EventArgs e)
        {
            uC_P_MedicineValidity1.Visible = true;
            uC_P_MedicineValidity1.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uC_P_SellMed1.Visible = true;
            uC_P_SellMed1.BringToFront();
        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
