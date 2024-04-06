namespace ASM2_NVH
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			btnLogin = new Button();
			btnExit = new Button();
			txbEmail = new TextBox();
			passwordEmail = new TextBox();
			emalLabel = new Label();
			passwordLabel = new Label();
			SuspendLayout();
			// 
			// btnLogin
			// 
			btnLogin.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
			btnLogin.Location = new Point(476, 226);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(75, 29);
			btnLogin.TabIndex = 0;
			btnLogin.Text = "Login\r\n";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += button1_Click;
			// 
			// btnExit
			// 
			btnExit.BackColor = SystemColors.Control;
			btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
			btnExit.Location = new Point(710, 343);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(75, 31);
			btnExit.TabIndex = 1;
			btnExit.Text = "Exit";
			btnExit.UseVisualStyleBackColor = false;
			btnExit.Click += button2_Click;
			// 
			// txbEmail
			// 
			txbEmail.Location = new Point(348, 158);
			txbEmail.Multiline = true;
			txbEmail.Name = "txbEmail";
			txbEmail.Size = new Size(203, 23);
			txbEmail.TabIndex = 2;
			// 
			// passwordEmail
			// 
			passwordEmail.Location = new Point(348, 197);
			passwordEmail.Name = "passwordEmail";
			passwordEmail.Size = new Size(203, 23);
			passwordEmail.TabIndex = 3;
			passwordEmail.UseSystemPasswordChar = true;
			// 
			// emalLabel
			// 
			emalLabel.AutoSize = true;
			emalLabel.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
			emalLabel.Location = new Point(267, 156);
			emalLabel.Name = "emalLabel";
			emalLabel.Size = new Size(49, 22);
			emalLabel.TabIndex = 4;
			emalLabel.Text = "Email";
			// 
			// passwordLabel
			// 
			passwordLabel.AutoSize = true;
			passwordLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
			passwordLabel.Location = new Point(267, 197);
			passwordLabel.Name = "passwordLabel";
			passwordLabel.Size = new Size(69, 19);
			passwordLabel.TabIndex = 5;
			passwordLabel.Text = "Password";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(797, 386);
			Controls.Add(emalLabel);
			Controls.Add(passwordLabel);
			Controls.Add(txbEmail);
			Controls.Add(passwordEmail);
			Controls.Add(btnLogin);
			Controls.Add(btnExit);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnLogin;
        private Button btnExit;
        private TextBox txbEmail;
        private TextBox passwordEmail;
        private Label emalLabel;
        private Label passwordLabel;
    }
}
