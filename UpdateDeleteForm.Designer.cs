namespace FirstWinForm
{
    partial class UpdateDeleteForm
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
            label1 = new Label();
            txtBoxId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtBoxFirstName = new TextBox();
            txtBoxLastName = new TextBox();
            label4 = new Label();
            txtBoxAge = new TextBox();
            label5 = new Label();
            txtBoxCourse = new TextBox();
            label6 = new Label();
            DeleteBtn = new Button();
            UpdateBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // txtBoxId
            // 
            txtBoxId.Location = new Point(12, 37);
            txtBoxId.Name = "txtBoxId";
            txtBoxId.ReadOnly = true;
            txtBoxId.Size = new Size(435, 23);
            txtBoxId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(0, 30);
            label2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 72);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 3;
            label3.Text = "First Name";
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.Location = new Point(12, 90);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(435, 23);
            txtBoxFirstName.TabIndex = 4;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Location = new Point(12, 145);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(435, 23);
            txtBoxLastName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 127);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 5;
            label4.Text = "Last Name";
            // 
            // txtBoxAge
            // 
            txtBoxAge.Location = new Point(12, 204);
            txtBoxAge.Name = "txtBoxAge";
            txtBoxAge.Size = new Size(435, 23);
            txtBoxAge.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 186);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 7;
            label5.Text = "Age";
            // 
            // txtBoxCourse
            // 
            txtBoxCourse.Location = new Point(12, 260);
            txtBoxCourse.Name = "txtBoxCourse";
            txtBoxCourse.Size = new Size(435, 23);
            txtBoxCourse.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 242);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 9;
            label6.Text = "Course";
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.IndianRed;
            DeleteBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBtn.ForeColor = SystemColors.Control;
            DeleteBtn.Location = new Point(12, 309);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(214, 43);
            DeleteBtn.TabIndex = 11;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = SystemColors.ActiveCaption;
            UpdateBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = SystemColors.Control;
            UpdateBtn.Location = new Point(232, 309);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(215, 43);
            UpdateBtn.TabIndex = 12;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // UpdateDeleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 379);
            Controls.Add(UpdateBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(txtBoxCourse);
            Controls.Add(label6);
            Controls.Add(txtBoxAge);
            Controls.Add(label5);
            Controls.Add(txtBoxLastName);
            Controls.Add(label4);
            Controls.Add(txtBoxFirstName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBoxId);
            Controls.Add(label1);
            Name = "UpdateDeleteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update/Delete Students";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private Button DeleteBtn;
        private Button UpdateBtn;
        private TextBox txtBoxId;
        private TextBox txtBoxFirstName;
        private TextBox txtBoxLastName;
        private TextBox txtBoxAge;
        private TextBox txtBoxCourse;
    }
}