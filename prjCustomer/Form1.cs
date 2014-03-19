using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCustomer
{
    public partial class Form1 : Form
    {

        protected List<CCustomer> listCustomer = new List<CCustomer>();
        private int intIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            CCustomer cust = new CCustomer() { id = "001", name = "Marco", phone = "0932214541", email = "marco@gmail.com", address = "高雄市" };
            listCustomer.Add(cust);
            cust = new CCustomer() { id = "002", name = "Emma", phone = "0968545214", email = "emma@hotmail.com", address = "高雄市" };
            listCustomer.Add(cust);
            cust = new CCustomer() { id = "003", name = "Bill", phone = "0954125478", email = "bill@yahoo.com", address = "新北市" };
            listCustomer.Add(cust);
            cust = new CCustomer() { id = "004", name = "Jenny", phone = "0965441254", email = "jenny@yahoo.com", address = "新北市" };
            listCustomer.Add(cust);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            intIndex++;
            if (intIndex >= listCustomer.Count)
                intIndex = listCustomer.Count - 1;
            displayCustomerInfo();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            intIndex = 0;
            displayCustomerInfo();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            intIndex = listCustomer.Count - 1;
            displayCustomerInfo();
        }

        private void displayCustomerInfo()
        {
            txtId.Text = listCustomer[intIndex].id;
            txtName.Text = listCustomer[intIndex].name;
            txtPhone.Text = listCustomer[intIndex].phone;
            txtEmail.Text = listCustomer[intIndex].email;
            txtAddress.Text = listCustomer[intIndex].address;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            intIndex--;
            if (intIndex < 0)
                intIndex = 0;
            displayCustomerInfo();
        }

    }
}
