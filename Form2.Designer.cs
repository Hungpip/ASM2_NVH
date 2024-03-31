namespace ASM2_NVH
{
    partial class Form2
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
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label4 = new Label();
            label2 = new Label();
            txbThisMonth = new TextBox();
            label1 = new Label();
            cbbType = new ComboBox();
            txbLastMonth = new TextBox();
            txbName = new TextBox();
            btnExit = new Button();
            btnDelete = new Button();
            btnFIx = new Button();
            btnAdd = new Button();
            label3 = new Label();
            lbName = new Label();
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
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbThisMonth);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbbType);
            panel1.Controls.Add(txbLastMonth);
            panel1.Controls.Add(txbName);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnFIx);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbName);
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 206);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(209, 136);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 14;
            label4.Text = "This Month";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 136);
            label2.Name = "label2";
            label2.Size = new Size(76, 17);
            label2.TabIndex = 13;
            label2.Text = "Last Month";
            // 
            // txbThisMonth
            // 
            txbThisMonth.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbThisMonth.Location = new Point(217, 156);
            txbThisMonth.Name = "txbThisMonth";
            txbThisMonth.Size = new Size(60, 26);
            txbThisMonth.TabIndex = 12;
            txbThisMonth.TextChanged += txbThisMonth_TextChanged;
            txbThisMonth.KeyPress += textBox3_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(386, 29);
            label1.Name = "label1";
            label1.Size = new Size(98, 17);
            label1.TabIndex = 11;
            label1.Text = "Type Customer";
            // 
            // cbbType
            // 
            cbbType.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbType.FormattingEnabled = true;
            cbbType.Items.AddRange(new object[] { "Household", "Administrative agency, public service", "Production units", "Business services" });
            cbbType.Location = new Point(490, 24);
            cbbType.Name = "cbbType";
            cbbType.Size = new Size(248, 27);
            cbbType.TabIndex = 10;
            cbbType.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txbLastMonth
            // 
            txbLastMonth.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbLastMonth.Location = new Point(76, 156);
            txbLastMonth.Name = "txbLastMonth";
            txbLastMonth.Size = new Size(60, 26);
            txbLastMonth.TabIndex = 9;
            txbLastMonth.KeyPress += textBox2_KeyPress;
            // 
            // txbName
            // 
            txbName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbName.Location = new Point(123, 24);
            txbName.Name = "txbName";
            txbName.Size = new Size(248, 26);
            txbName.TabIndex = 7;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            btnDelete.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            btnFIx.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFIx.Location = new Point(494, 139);
            btnFIx.Name = "btnFIx";
            btnFIx.Size = new Size(75, 30);
            btnFIx.TabIndex = 4;
            btnFIx.Text = "Fix";
            btnFIx.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(494, 81);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 30);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(135, 109);
            label3.Name = "label3";
            label3.Size = new Size(95, 17);
            label3.TabIndex = 2;
            label3.Text = "Waternumber :";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbName.Location = new Point(47, 29);
            lbName.Name = "lbName";
            lbName.Size = new Size(69, 17);
            lbName.TabIndex = 0;
            lbName.Text = "Full Name";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(panel1);
            Name = "Form2";
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
        private Label lbName;
        private TextBox txbName;
        private TextBox txbLastMonth;
        private Label label1;
        private ComboBox cbbType;
        private Label label3;
        private Label label4;
        private Label label2;
        private TextBox txbThisMonth;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}