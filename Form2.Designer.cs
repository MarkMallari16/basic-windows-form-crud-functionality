namespace FirstWinForm
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
            label1 = new Label();
            txtBoxFirstName = new TextBox();
            label3 = new Label();
            txtBoxAge = new TextBox();
            label4 = new Label();
            txtBoxCourse = new TextBox();
            label5 = new Label();
            dataTblGridStudent = new DataGridView();
            BtnUpdate = new Button();
            BtnDelete = new Button();
            BtnAdd = new Button();
            txtBoxLastName = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataTblGridStudent).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(174, 40);
            label1.TabIndex = 0;
            label1.Text = "Basic CRUD";
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.Location = new Point(21, 89);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(278, 23);
            txtBoxFirstName.TabIndex = 4;
            txtBoxFirstName.TextChanged += txtBoxName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 68);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 3;
            label3.Text = "Student First Name";
            // 
            // txtBoxAge
            // 
            txtBoxAge.Location = new Point(21, 206);
            txtBoxAge.Name = "txtBoxAge";
            txtBoxAge.Size = new Size(278, 23);
            txtBoxAge.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 188);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 5;
            label4.Text = "Student Age";
            // 
            // txtBoxCourse
            // 
            txtBoxCourse.Location = new Point(21, 266);
            txtBoxCourse.Name = "txtBoxCourse";
            txtBoxCourse.Size = new Size(278, 23);
            txtBoxCourse.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 248);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 7;
            label5.Text = "Student Course";
            // 
            // dataTblGridStudent
            // 
            dataTblGridStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTblGridStudent.Location = new Point(357, 89);
            dataTblGridStudent.Name = "dataTblGridStudent";
            dataTblGridStudent.Size = new Size(419, 330);
            dataTblGridStudent.TabIndex = 9;
            // 
            // BtnUpdate
            // 
            BtnUpdate.BackColor = SystemColors.Highlight;
            BtnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnUpdate.ForeColor = SystemColors.ControlText;
            BtnUpdate.Location = new Point(357, 50);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(208, 33);
            BtnUpdate.TabIndex = 11;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = false;
            BtnUpdate.Click += btnUpdate_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.IndianRed;
            BtnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnDelete.ForeColor = SystemColors.ControlText;
            BtnDelete.Location = new Point(571, 50);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(205, 33);
            BtnDelete.TabIndex = 12;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += btnDelete_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = SystemColors.ActiveCaptionText;
            BtnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAdd.ForeColor = SystemColors.Control;
            BtnAdd.Location = new Point(21, 306);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(278, 33);
            BtnAdd.TabIndex = 13;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += btnAdd_Click;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Location = new Point(21, 152);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(278, 23);
            txtBoxLastName.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 131);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 14;
            label2.Text = "Student Last Name";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 450);
            Controls.Add(txtBoxLastName);
            Controls.Add(label2);
            Controls.Add(BtnAdd);
            Controls.Add(BtnDelete);
            Controls.Add(BtnUpdate);
            Controls.Add(dataTblGridStudent);
            Controls.Add(txtBoxCourse);
            Controls.Add(label5);
            Controls.Add(txtBoxAge);
            Controls.Add(label4);
            Controls.Add(txtBoxFirstName);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataTblGridStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxFirstName;
        private Label label3;
        private TextBox txtBoxAge;
        private Label label4;
        private TextBox txtBoxCourse;
        private Label label5;
        private DataGridView tblStudent;
        private Button BtnUpdate;
        private Button BtnDelete;
        private Button BtnAdd;
        private DataGridView dataTblGridStudent;
        private TextBox txtBoxLastName;
        private Label label2;
    }
}