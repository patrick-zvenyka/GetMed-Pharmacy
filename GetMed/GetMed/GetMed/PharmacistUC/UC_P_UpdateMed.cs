using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetMed.PharmacistUC
{
    public partial class UC_P_UpdateMed : UserControl
    {
        function fn = new function();
        String query;
        public UC_P_UpdateMed()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Int64 totalQuantity;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String mname = txtMedName.Text;
            String mnumber = txtMedNum.Text;
            String mDate = txtManDate.Text;
            String eDate = txtExpDate.Text;
            Int64 quantity = Int64.Parse(txtQuantity.Text);
            Int64 addQuantity = Int64.Parse(txtPricePerUnit.Text);
            Int64 unitprice = Int64.Parse(txtPricePerUnit.Text);

            totalQuantity = quantity + addQuantity;
            query = "update medic set mname = '" + mname + "', mnumber = '" + mnumber + "', mDate = '" + mDate + "', eDate = '" + eDate + "', quantity = " + totalQuantity + ", perUnit =" + unitprice + " where mid = '" + txtMedID.Text + "'";
            fn.setData(query, "Medicine details updated");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMedID.Text != "")
            {
                query = "select * from medic where mid = '" + txtMedID.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtMedName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMedNum.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtManDate.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtExpDate.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtPricePerUnit.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("No medicine found with the ID " + txtMedID.Text + " in the database", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                clearAll();
            }
        }
        private void clearAll()
        {
            txtMedID.Clear();
            txtMedName.Clear();
            txtMedNum.Clear();
            txtManDate.ResetText();
            txtExpDate.ResetText();
            txtQuantity.Clear();
            txtPricePerUnit.Clear();

            if (txtAddQuantity.Text != "0")
            {
                txtAddQuantity.Text = "0";
            }
            else
            {
                txtAddQuantity.Text = "0";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
