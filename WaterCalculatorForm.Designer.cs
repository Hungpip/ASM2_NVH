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
			columnHeader3 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BorderStyle = BorderStyle.FixedSingle;
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
			panel1.Size = new Size(776, 206);
			panel1.TabIndex = 0;
			panel1.Paint += panel1_Paint;
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
			waternumberLabel.TabIndex = 2;
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
			txbThisMonth.TabIndex = 12;
			txbThisMonth.TextChanged += txbThisMonth_TextChanged;
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
			cbbType.TabIndex = 10;
			cbbType.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// txbLastMonth
			// 
			txbLastMonth.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
			txbLastMonth.Location = new Point(76, 156);
			txbLastMonth.Name = "txbLastMonth";
			txbLastMonth.Size = new Size(60, 26);
			txbLastMonth.TabIndex = 9;
			txbLastMonth.KeyPress += textBox2_KeyPress;
			// 
			// txbName
			// 
			txbName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
			txbName.Location = new Point(123, 24);
			txbName.Name = "txbName";
			txbName.Size = new Size(248, 26);
			txbName.TabIndex = 7;
			// 
			// btnExit
			// 
			btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
			btnExit.Location = new Point(663, 139);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(75, 30);
			btnExit.TabIndex = 6;
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
			btnDelete.TabIndex = 5;
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
			btnFIx.TabIndex = 4;
			btnFIx.Text = "Fix";
			btnFIx.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			btnAdd.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
			btnAdd.Location = new Point(494, 81);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(75, 30);
			btnAdd.TabIndex = 3;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += button1_Click;
			// 
			// listView1
			// 
			listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
			listView1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
			listView1.FullRowSelect = true;
			listView1.GridLines = true;
			listView1.Location = new Point(12, 224);
			listView1.Name = "listView1";
			listView1.Size = new Size(776, 175);
			listView1.TabIndex = 1;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = View.Details;
			listView1.ItemChecked += lisview2;
			listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
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
			columnHeader2.Width = 300;
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
			ClientSize = new Size(800, 450);
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
    }
}