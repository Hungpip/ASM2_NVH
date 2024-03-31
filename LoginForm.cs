namespace ASM2_NVH {

	public partial class LoginForm : Form {

		public LoginForm() {
			InitializeComponent();
		}

		private string Email = "thanhtoandiennuoc";
		private string password = "123456";

		// Them close Form1 khi dang nhap thanh cong
		private void button1_Click(object sender, EventArgs e) {
			if (KiemTraDangNhap(txbEmail.Text, passwordEmail.Text)) {
				WaterCalculatorForm f = new();
				Hide();
				f.ShowDialog();
				Close();
			} else {
				MessageBox.Show("Please retun login", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private bool KiemTraDangNhap(string Email, string password) {
			if (Email == this.Email && password == this.password) {
				return true;
			}
			return false;
		}

		private void Form1_Load(object sender, EventArgs e) {
		}

		// Them dialog xac nhan thoot
		private void button2_Click(object sender, EventArgs e) {
			DialogResult result = MessageBox.Show("Do you want to exit?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (result == DialogResult.OK) {
				Application.Exit();
			}
		}
	}
}