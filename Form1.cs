using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apaartment_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumber.Text) || string.IsNullOrWhiteSpace(txtTenant.Text) ||
                  string.IsNullOrWhiteSpace(txtPrice.Text) || comboBoxNumber.SelectedItem == null)
            {
                MessageBox.Show("يرجى تعبئة البيانات");
            }
            string Info = $"شقة رقم:{txtNumber.Text}    - المستأجر:{txtTenant.Text}   - " +
                $"عدد الغرف: {comboBoxNumber.Text}    -   الايجار: {txtPrice.Text} ريال   - " +
                $" التاريخ: {dateTimePicker1.Value.ToShortDateString()}";
            lstApartments.Items.Add(Info);
             
            txtNumber.Clear();
            txtPrice.Clear();
            txtTenant.Clear();
            comboBoxNumber.SelectedIndex = -1;
        }

        private void lstApartments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstApartments.SelectedIndex == -1)
            {
                MessageBox.Show("يرجى اختيار عنصر للحذف!");
            }
            lstApartments.Items.RemoveAt(lstApartments.SelectedIndex);
        }
    }
}
