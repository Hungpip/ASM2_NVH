﻿namespace ASM2_NVH {

	public partial class WaterCalculatorForm : Form {

		public WaterCalculatorForm() {
			InitializeComponent();
		}
		//Nhập tên Khách hàng
		private void button1_Click(object sender, EventArgs e) {
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
				MessageBox.Show("This month's water number cannot be less than last month's." +
								" Please enter again.", "Notice",
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
			} else {
				switch (type) {
					case "Household":
						double[] priceStep = [5.973, 7.052, 8.699, 15.929];
						int index = Math.Min(3, (int) Math.Floor(TotalWaternumber / 10.0));
						price = TotalWaternumber * priceStep[index];
						break;
						
					case "Public services":
						price = TotalWaternumber * 9.955;
						break;

					case "Production units":
						price = TotalWaternumber * 11.615;
						break;

					case "Business":
						price = TotalWaternumber * 22.068;
						break;
				}
			}

			double VAT = price * 0.1;
			double TotalPrice = price + VAT;

			ListViewItem item = new();
			item.Text = name;

			item.SubItems.Add(type);
			item.SubItems.Add(lastmonth);
			item.SubItems.Add(thismonth);
			item.SubItems.Add("" + TotalWaternumber);
			item.SubItems.Add($"{TotalPrice:n3}");

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
		private void textBox2_KeyPress(object sender, KeyPressEventArgs e) {
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
				e.Handled = true;
			}
		}
		private void btnFIx_Click(object sender, EventArgs e) {
			if (listView1.SelectedItems.Count > 0) {
				listView1.SelectedItems[0].SubItems[0].Text = txbName.Text;
				listView1.SelectedItems[0].SubItems[1].Text = cbbType.Text;
				if (!int.TryParse(txbLastMonth.Text, out int lastMonth) || 
					!int.TryParse(txbThisMonth.Text, out int thisMonth))
					return;
				if (thisMonth < lastMonth) {
					MessageBox.Show("This month's water number cannot be less than last month's." +
									" Please enter again.", "Notice",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txbThisMonth.Text = "";
					return;
				}
				double TotalWaternumber = thisMonth - lastMonth;
				listView1.SelectedItems[0].SubItems[2].Text = txbLastMonth.Text;
				listView1.SelectedItems[0].SubItems[3].Text = txbThisMonth.Text;
				listView1.SelectedItems[0].SubItems[4].Text = "" + TotalWaternumber;
				double price = 0;
				switch (cbbType.Text) {
					case "Household":
						double[] priceStep = [5.973, 7.052, 8.699, 15.929];
						int index = Math.Min(3, (int) Math.Floor(TotalWaternumber / 10.0));
						price = TotalWaternumber * priceStep[index];
						break;

					case "Public services":
						price = TotalWaternumber * 9.955;
						break;

					case "Production units":
						price = TotalWaternumber * 11.615;
						break;

					case "Business":
						price = TotalWaternumber * 22.068;
						break;
				}
				double VAT = price * 0.1;
				double TotalPrice = price + VAT;
				listView1.SelectedItems[0].SubItems[5].Text = $"{TotalPrice:n3}";
			}	else {
				MessageBox.Show("You must choose 1 line !!");
			}	
		}

		private void IndexChanged(object sender, EventArgs e) {
			if (listView1.SelectedItems.Count <= 0) return;
			txbName.Text = listView1.SelectedItems[0].SubItems[0].Text;
			cbbType.Text = listView1.SelectedItems[0].SubItems[1].Text;
			txbLastMonth.Text = listView1.SelectedItems[0].SubItems[2].Text;
			txbThisMonth.Text = listView1.SelectedItems[0].SubItems[3].Text;
		}
        //Nút deleteeeeee
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete?", "",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);

                    txbName.Text = "";
                    txbLastMonth.Text = "";
                    txbThisMonth.Text = "";
					cbbType.Text = "";
                }
                else
                {
                    MessageBox.Show("Must choose a litter one line");
                }
            }
        }
        //Nút exitttttt
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
				private double CalculatePrice(int waternumber) {
			if (0 < waternumber && waternumber <= 10) {
			}
			return 0;
		}
    }
}