using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjCustomer
{
    public partial class GridBox : prjCustomer.Form1
    {
        public GridBox()
        {
            InitializeComponent();
        }

        private void GridBox_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = base.listCustomer;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            base.moveTo(e.RowIndex);
        }
    }
}
