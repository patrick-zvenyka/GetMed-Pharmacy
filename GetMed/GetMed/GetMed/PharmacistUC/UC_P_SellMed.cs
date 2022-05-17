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
    public partial class UC_P_SellMed : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public UC_P_SellMed()
        {
            InitializeComponent();
        }

        private void UC_P_SellMed_Load(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            query = "select mname from medic where eDate >= getdate() and quantity > '0'";
            ds = fn.getData(query);
            for(int i=0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_P_SellMed_Load(this, null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            query = "select mname from medic where mname like '" + txtSearch.Text + "%' and eDate >= getdate() and quantity > '0'";
            ds = fn.getData(query);
            for(int i=0; i<ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBoxMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUnits.Clear();
            String name = listBoxMedicines.GetItemText(listBoxMedicines.SelectedItem);
            txtMedName.Text = name;
            query = "select mid,eDate,perUnit from medic where mname = '" + name + "'";
            ds = fn.getData(query);
            txtMedID.Text = ds.Tables[0].Rows[0][0].ToString();
            txtExpDate.Text = ds.Tables[0].Rows[0][1].ToString();
            txtPrice.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void txtUnits_TextChanged(object sender, EventArgs e)
        {
            if(txtUnits.Text != "")
            {
                Int64 unitPrice = Int64.Parse(txtPrice.Text);
                Int64 noUnits = Int64.Parse(txtUnits.Text);
                Int64 totalAmount = unitPrice * noUnits;
                txtTotalPrice.Text = totalAmount.ToString();
            }
            else
            {
                txtTotalPrice.Clear();
            }
        }

        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;

        

        private void btnAdd2Chart_Click(object sender, EventArgs e)
        {
            if(txtMedID.Text != "")
            {
                query = "select quantity from medic where mid = '" + txtMedID.Text + "'";
                ds = fn.getData(query);
                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = quantity - Int64.Parse(txtUnits.Text);
                if(newQuantity >= 0)
                {
                    n = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[n].Cells[0].Value = txtMedID.Text;
                    guna2DataGridView1.Rows[n].Cells[1].Value = txtMedName.Text;
                    guna2DataGridView1.Rows[n].Cells[2].Value = txtExpDate.Text;
                    guna2DataGridView1.Rows[n].Cells[3].Value = txtPrice.Text;
                    guna2DataGridView1.Rows[n].Cells[4].Value = txtUnits.Text;
                    guna2DataGridView1.Rows[n].Cells[5].Value = txtTotalPrice.Text;
                    totalAmount = totalAmount + int.Parse(txtTotalPrice.Text);
                    totalLabel.Text = "RTGS$." + totalAmount.ToString();
                    query = "update medic set quantity = '" + newQuantity + "' where mid ='" + txtMedID.Text + "'";
                    fn.setData(query,"Medicine added to chart.");
                }
                else
                {
                    MessageBox.Show("medicine out of stock.\n Only " + quantity + " left", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clearAll();
                UC_P_SellMed_Load(this, null);
            }
            else
            {
                MessageBox.Show("Select Medicine first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        int valueAmount;
        String valueId;
        protected Int64 noUnit;

        
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueId = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noUnit = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch(Exception)
            {

            }
        }

       
        private void txtRemoveItem_Click(object sender, EventArgs e)
        {
            if(valueId != null)
            {
                try
                {
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
                }
                catch
                {

                }
                finally
                {
                    query = "select quantity from medic where mid = '" + valueId + "'";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noUnit;
                    query = "update medic set quantity = '" + newQuantity + "' where mid = '" + valueId + "'";
                    fn.setData(query, "Medicine removed.");
                    totalAmount = totalAmount - valueAmount;
                    totalLabel.Text = "RTGS$. " + totalAmount.ToString();
                }
                UC_P_SellMed_Load(this, null);
            }
        }
        private void btnPurchasePrint_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "GetMed Pharmacy Inc.\n Payment Reciept";
            print.SubTitle = String.Format("Date:- {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Total: " + totalLabel.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(guna2DataGridView1);

            totalAmount = 0;
            totalLabel.Text = "RTGS$. 00";
            guna2DataGridView1.DataSource = 0;
        }




        private void clearAll()
        {
            txtMedID.Clear();
            txtMedName.Clear();
            txtExpDate.ResetText();
            txtPrice.Clear();
            txtUnits.Clear();
        }
    }
}
