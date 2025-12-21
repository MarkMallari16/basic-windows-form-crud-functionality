namespace FirstWinForm
{
    partial class Form1
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
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtBoxUsername = new TextBox();
            label3 = new Label();
            txtBoxPassword = new TextBox();
            btnLogin = new Button();
            cbPassword = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 122);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(158, 23);
            label2.Name = "label2";
            label2.Size = new Size(120, 50);
            label2.TabIndex = 1;
            label2.Text = "Login";
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.Location = new Point(55, 146);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.Size = new Size(330, 23);
            txtBoxUsername.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 188);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(55, 212);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(330, 23);
            txtBoxPassword.TabIndex = 4;
            txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.HotTrack;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(276, 252);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(109, 32);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // cbPassword
            // 
            cbPassword.AutoSize = true;
            cbPassword.Location = new Point(162, 260);
            cbPassword.Name = "cbPassword";
            cbPassword.Size = new Size(108, 19);
            cbPassword.TabIndex = 6;
            cbPassword.Text = "Show Password";
            cbPassword.UseVisualStyleBackColor = true;
            cbPassword.CheckedChanged += cbPassword_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 382);
            Controls.Add(cbPassword);
            Controls.Add(btnLogin);
            Controls.Add(txtBoxPassword);
            Controls.Add(label3);
            Controls.Add(txtBoxUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "First Windows Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBoxUsername;
        private Label label3;
        private TextBox txtBoxPassword;
        private Button btnLogin;
        private CheckBox cbPassword;
    }
}
