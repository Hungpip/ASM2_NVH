namespace ASM2_NVH {

	public partial class Form1 : Form {

		public Form1() {
			InitializeComponent();
		}

		private string Email = "thanhtoandiennuoc";
		private string password = "123456";

		private void button1_Click(object sender, EventArgs e) {
			if (KiemTraDangNhap(textBox1.Text, textBox2.Text)) {
				Form2 f = new();
				f.ShowDialog();
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

		private void button2_Click(object sender, EventArgs e) {
		}
	}
}