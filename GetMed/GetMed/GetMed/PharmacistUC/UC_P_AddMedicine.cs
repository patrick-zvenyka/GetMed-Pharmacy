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
    public partial class UC_P_AddMedicine : UserControl
    {
        function fn = new function();
        String query;
        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtMedid.Text !="" && txtMedName.Text != "" && txtMedNum.Text != "" && txtQuantity.Text !="" && txtPrice.Text != "")
            {
                String mid = txtMedid.Text;
                String mname = txtMedName.Text;
                String mnumber = txtMedNum.Text;
                String mdate = txtManDate.Text;
                String edate = txtExpDate.Text;
                Int64 quantity = Int64.Parse(txtQuantity.Text);
                Int64 perunit = Int64.Parse(txtPrice.Text);


                query = "insert into medic(mid,mname,mnumber,mDate,eDate,quantity,perUnit) values('"+mid+"','"+mname+"','"+mnumber+"','"+mdate+"','"+edate+"','"+quantity+"',"+perunit+")";
                fn.setData(query, "Medicine added to Database");
            }
            else
            {
                MessageBox.Show("Enter all required data!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
