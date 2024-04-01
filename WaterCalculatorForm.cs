namespace ASM2_NVH {

	public partial class WaterCalculatorForm : Form {

		public WaterCalculatorForm() {
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e) {
		}

		private void panel1_Paint(object sender, PaintEventArgs e) {
		}

		private void textBox3_TextChanged(object sender, EventArgs e) {
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e) {
		}

		private void button4_Click(object sender, EventArgs e) {
			DialogResult result = MessageBox.Show("Do you want to exit?", "",
				MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (result == DialogResult.OK) {
				Application.Exit();
			}
		}

		private void button1_Click(object sender, EventArgs e) {
			//Nhập tên Khách hàng
			string name = txbName.Text;
			if (string.IsNullOrEmpty(name)) {
				MessageBox.Show("Please enter your name", "Notice",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			//Tính số nước mà khách hàng đã sử dụng trong tháng
			string lastmonth = txbLastMonth.Text;
			if (string.IsNullOrEmpty(lastmonth)) {
				MessageBox.Show("Please enter waternumber lastmonth", "Notice",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string thismonth = txbThisMonth.Text;
			if (string.IsNullOrEmpty(thismonth)) {
				MessageBox.Show("Please enter waternumber thismonth", "Notice",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (int.Parse(thismonth) < int.Parse(lastmonth)) {
				MessageBox.Show("This month's water number cannot be less than last month's. Please enter again.", "Notice",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txbThisMonth.Text = "";
				return;
			}

			if (!int.TryParse(lastmonth, out int lastMonthValue)) {
				return;
			}

			if (!int.TryParse(thismonth, out int thisMonthValue)) {
				return;
			}

			int TotalWaternumber = thisMonthValue - lastMonthValue;

			//Type Customer and price
			string type = cbbType.Text;
			double price = 0;

			if (string.IsNullOrEmpty(type)) {
				MessageBox.Show("Please choose type customer", "Notice",
				MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			} 
			else 
			{
				switch(type)
				{

					case "Household":
						
					break;
					
					case "Public service":
						price = TotalWaternumber * 9.955;
                    break;

					case "Production units":
						price = TotalWaternumber * 11.615;
					break;

					case "Business services":
						price = TotalWaternumber * 22.068;
					break;
                }
            }

			


            ListViewItem item = new();
			item.Text = name;

			item.SubItems.Add(type);
			item.SubItems.Add("" + TotalWaternumber);
			item.SubItems.Add("" + price);

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


        private void textBox3_KeyPress(object sender, KeyPressEventArgs e) {
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
				e.Handled = true;
			}
		}

		private void textBox2_TextChanged(object sender, EventArgs e) {
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e) {
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
				e.Handled = true;
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
		}

		private void txbThisMonth_TextChanged(object sender, EventArgs e) {
		}

		private void lisview2(object sender, ItemCheckedEventArgs e) {
		}
	}
}