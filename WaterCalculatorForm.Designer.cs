namespace ASM2_NVH
{
    partial class WaterCalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			panel1 = new Panel();
			label1 = new Label();
			fullnameLabel = new Label();
			waternumberLabel = new Label();
			thisMonthLabel = new Label();
			lastMonthLabel = new Label();
			typeCustomerLabel = new Label();
			txbThisMonth = new TextBox();
			cbbType = new ComboBox();
			txbLastMonth = new TextBox();
			txbName = new TextBox();
			btnExit = new Button();
			btnDelete = new Button();
			btnFIx = new Button();
			btnAdd = new Button();
			listView1 = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader5 = new ColumnHeader();
			columnHeader6 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(label1);
			panel1.Controls.Add(fullnameLabel);
			panel1.Controls.Add(waternumberLabel);
			panel1.Controls.Add(thisMonthLabel);
			panel1.Controls.Add(lastMonthLabel);
			panel1.Controls.Add(typeCustomerLabel);
			panel1.Controls.Add(txbThisMonth);
			panel1.Controls.Add(cbbType);
			panel1.Controls.Add(txbLastMonth);
			panel1.Controls.Add(txbName);
			panel1.Controls.Add(btnExit);
			panel1.Controls.Add(btnDelete);
			panel1.Controls.Add(btnFIx);
			panel1.Controls.Add(btnAdd);
			panel1.Location = new Point(11, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(814, 206);
			panel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BorderStyle = BorderStyle.Fixed3D;
			label1.Enabled = false;
			label1.Location = new Point(748, 185);
			label1.Name = "label1";
			label1.Size = new Size(61, 17);
			label1.TabIndex = 15;
			label1.Text = "* 10% VAT";
			// 
			// fullnameLabel
			// 
			fullnameLabel.AutoSize = true;
			fullnameLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point,  0);
			fullnameLabel.Location = new Point(47, 29);
			fullnameLabel.Name = "fullnameLabel";
			fullnameLabel.Size = new Size(69, 17);
			fullnameLabel.TabIndex = 0;
			fullnameLabel.Text = "Full Name";
			// 
			// waternumberLabel
			// 
			waternumberLabel.AutoSize = true;
			waternumberLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point,  0);
			waternumberLabel.Location = new Point(135, 109);
			waternumberLabel.Name = "waternumberLabel";
			waternumberLabel.Size = new Size(95, 17);
			waternumberLabel.TabIndex = 9;
			waternumberLabel.Text = "Waternumber :";
			// 
			// thisMonthLabel
			// 
			thisMonthLabel.AutoSize = true;
			thisMonthLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point,  0);
			thisMonthLabel.Location = new Point(209, 136);
			thisMonthLabel.Name = "thisMonthLabel";
			thisMonthLabel.Size = new Size(75, 17);
			thisMonthLabel.TabIndex = 14;
			thisMonthLabel.Text = "This Month";
			// 
			// lastMonthLabel
			// 
			lastMonthLabel.AutoSize = true;
			lastMonthLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point,  0);
			lastMonthLabel.Location = new Point(71, 136);
			lastMonthLabel.Name = "lastMonthLabel";
			lastMonthLabel.Size = new Size(76, 17);
			lastMonthLabel.TabIndex = 13;
			lastMonthLabel.Text = "Last Month";
			// 
			// typeCustomerLabel
			// 
			typeCustomerLabel.AutoSize = true;
			typeCustomerLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point,  0);
			typeCustomerLabel.Location = new Point(386, 29);
			typeCustomerLabel.Name = "typeCustomerLabel";
			typeCustomerLabel.Size = new Size(98, 17);
			typeCustomerLabel.TabIndex = 11;
			typeCustomerLabel.Text = "Type Customer";
			// 
			// txbThisMonth
			// 
			txbThisMonth.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
			txbThisMonth.Location = new Point(217, 156);
			txbThisMonth.Name = "txbThisMonth";
			txbThisMonth.Size = new Size(60, 26);
			txbThisMonth.TabIndex = 3;
			txbThisMonth.KeyPress += textBox3_KeyPress;
			// 
			// cbbType
			// 
			cbbType.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
			cbbType.FormattingEnabled = true;
			cbbType.Items.AddRange(new object[] { "Household", "Public services", "Production units", "Business" });
			cbbType.Location = new Point(490, 24);
			cbbType.Name = "cbbType";
			cbbType.Size = new Size(248, 27);
			cbbType.TabIndex = 4;
			// 
			// txbLastMonth
			// 
			txbLastMonth.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
			txbLastMonth.Location = new Point(76, 156);
			txbLastMonth.Name = "txbLastMonth";
			txbLastMonth.Size = new Size(60, 26);
			txbLastMonth.TabIndex = 2;
				txbLastMonth.KeyPress += textBox2_KeyPress;
			// 
			// txbName
			// 
			txbName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
			txbName.Location = new Point(123, 24);
			txbName.Name = "txbName";
			txbName.Size = new Size(248, 26);
			txbName.TabIndex = 1;
			// 
			// btnExit
			// 
			btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
			btnExit.Location = new Point(663, 139);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(75, 30);
			btnExit.TabIndex = 8;
			btnExit.Text = "Exit";
			btnExit.UseVisualStyleBackColor = true;
			btnExit.Click += button4_Click;
			// 
			// btnDelete
			// 
			btnDelete.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
			btnDelete.Location = new Point(663, 81);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(75, 30);
			btnDelete.TabIndex = 7;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += button3_Click;
			// 
			// btnFIx
			// 
			btnFIx.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
			btnFIx.Location = new Point(494, 139);
			btnFIx.Name = "btnFIx";
			btnFIx.Size = new Size(75, 30);
			btnFIx.TabIndex = 6;
			btnFIx.Text = "Edit";
			btnFIx.UseVisualStyleBackColor = true;
			btnFIx.Click += btnFIx_Click;
			// 
			// btnAdd
			// 
			btnAdd.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
			btnAdd.Location = new Point(494, 81);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(75, 30);
			btnAdd.TabIndex = 5;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += button1_Click;
			// 
			// listView1
			// 
			listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader5, columnHeader6, columnHeader3, columnHeader4 });
			listView1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
			listView1.FullRowSelect = true;
			listView1.GridLines = true;
			listView1.Location = new Point(12, 224);
			listView1.Name = "listView1";
			listView1.Size = new Size(813, 175);
			listView1.TabIndex = 1;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = View.Details;
			listView1.SelectedIndexChanged += IndexChanged;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Name";
			columnHeader1.Width = 150;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Type Customer ";
			columnHeader2.TextAlign = HorizontalAlignment.Center;
			columnHeader2.Width = 170;
			// 
			// columnHeader5
			// 
			columnHeader5.Text = "Last Month";
			columnHeader5.TextAlign = HorizontalAlignment.Center;
			columnHeader5.Width = 100;
			// 
			// columnHeader6
			// 
			columnHeader6.Text = "This Moth";
			columnHeader6.TextAlign = HorizontalAlignment.Center;
			columnHeader6.Width = 100;
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Total waternumber";
			columnHeader3.TextAlign = HorizontalAlignment.Center;
			columnHeader3.Width = 150;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Total bill(VND)";
			columnHeader4.TextAlign = HorizontalAlignment.Center;
			columnHeader4.Width = 130;
			// 
			// WaterCalculatorForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(837, 450);
			Controls.Add(listView1);
			Controls.Add(panel1);
			Name = "WaterCalculatorForm";
			Text = "Form2";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
        private Button btnExit;
        private Button btnDelete;
        private Button btnFIx;
        private Button btnAdd;
        private Label fullnameLabel;
        private TextBox txbName;
        private TextBox txbLastMonth;
        private Label typeCustomerLabel;
        private ComboBox cbbType;
        private Label waternumberLabel;
        private Label thisMonthLabel;
        private Label lastMonthLabel;
        private TextBox txbThisMonth;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label1;
    }
}