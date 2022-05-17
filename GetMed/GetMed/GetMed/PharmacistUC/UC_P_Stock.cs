using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace GetMed.PharmacistUC
{
    public partial class UC_P_Stock : UserControl
    {
        function fn = new function();
        String query;
        public UC_P_Stock()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this medicine?", "Medicine Deleted!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from medic where mid = '" + medicineId + "'";
                fn.setData(query, "Medicine Deleted");
                UC_P_Stock_Load(this, null);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_P_Stock_Load(this, null);
        }

        private void UC_P_Stock_Load(object sender, EventArgs e)
        {
            query = "select * from medic ";
            setDataGridView(query);
        }

        private void setDataGridView(string query)
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        String medicineId;

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineId = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from medic where mname like '" + txtSearch.Text + "%' ";
            setDataGridView(query);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "GetMed Pharmacy Inc.\n Stocks Report";
            print.SubTitle = String.Format("Date:- {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "GetMed Pharmacy Inc.\n Stocks Sheet";
            print.FooterSpacing = 15;
            print.PrintDataGridView(guna2DataGridView1);
        }
    }
}
