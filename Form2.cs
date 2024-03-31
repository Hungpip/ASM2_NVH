using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ASM2_NVH
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name", "Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string lastmonth = txbLastMonth.Text;
            if (string.IsNullOrEmpty(lastmonth))
            {
                MessageBox.Show("Please enter waternumber lastmonth", "Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string thismonth = txbThisMonth.Text;
            if (string.IsNullOrEmpty(thismonth))
            {
                MessageBox.Show("Please enter waternumber thismonth", "Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string type = cbbType.Text;
            if (string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Please choose type customer", "Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem item = new
            ListViewItem();
            item.Text = name;

            item.SubItems.Add(type);
            item.SubItems.Add(lastmonth);
            item.SubItems.Add(thismonth);

            listView1.Items.Add(item);
            cbbType.Text = type;
            txbLastMonth.Text = lastmonth;
            txbThisMonth.Text = thismonth;
            txbName.Focus();


            txbName.Text = "";
            txbLastMonth.Text = "";
            txbThisMonth.Text = "";
            cbbType.Text = "";
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void txbThisMonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void lisview2(object sender, ItemCheckedEventArgs e)
        {

        }
    }
}
