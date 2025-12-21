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
            label2 = new Label();
            txtBoxID = new TextBox();
            txtBoxName = new TextBox();
            label3 = new Label();
            txtBoxAge = new TextBox();
            label4 = new Label();
            txtBoxCourse = new TextBox();
            label5 = new Label();
            dataTblGridStudent = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 71);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Student ID";
            // 
            // txtBoxID
            // 
            txtBoxID.Location = new Point(21, 89);
            txtBoxID.Name = "txtBoxID";
            txtBoxID.Size = new Size(278, 23);
            txtBoxID.TabIndex = 2;
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(21, 147);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(278, 23);
            txtBoxName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 129);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 3;
            label3.Text = "Student Name";
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
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Highlight;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.ControlText;
            btnUpdate.Location = new Point(357, 50);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(208, 33);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ControlText;
            btnDelete.Location = new Point(571, 50);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(205, 33);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaptionText;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(21, 306);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(278, 33);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dataTblGridStudent);
            Controls.Add(txtBoxCourse);
            Controls.Add(label5);
            Controls.Add(txtBoxAge);
            Controls.Add(label4);
            Controls.Add(txtBoxName);
            Controls.Add(label3);
            Controls.Add(txtBoxID);
            Controls.Add(label2);
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
        private Label label2;
        private TextBox txtBoxID;
        private TextBox txtBoxName;
        private Label label3;
        private TextBox txtBoxAge;
        private Label label4;
        private TextBox txtBoxCourse;
        private Label label5;
        private DataGridView tblStudent;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dataTblGridStudent;
    }
}