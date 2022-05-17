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
    public partial class UC_P_MedicineValidity : UserControl
    {
        function fn = new function();
        String query;
        public UC_P_MedicineValidity()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtCheck.SelectedIndex == 0)
            {
                query = "select * from medic where eDate >= getdate()";
                setDataGridView(query, "Valid Medicines", Color.Black);
            }
            else if(txtCheck.SelectedIndex == 1)
            {
                query = "select * from medic where eDate <= getdate()";
                setDataGridView(query, "Expired Medicines", Color.DarkOrange);
            }
            else if(txtCheck.SelectedIndex == 2)
            {
                query = "select * from medic";
                setDataGridView(query,"",Color.Black);
            }
        }
        private void setDataGridView(String query,String labelName, Color col )
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];
            setLabel.Text = labelName;
            setLabel.ForeColor = col;
        }

        private void UC_P_MedicineValidity_Load(object sender, EventArgs e)
        {
            setLabel.Text = "";
        }
    }
}
