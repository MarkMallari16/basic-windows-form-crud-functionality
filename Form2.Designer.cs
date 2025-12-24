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
            BtnAdd = new Button();
            txtBoxLastName = new TextBox();
            label2 = new Label();
            dataTblGridStudent = new DataGridView();
            cbCourse = new ComboBox();
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
            txtBoxFirstName.Size = new Size(388, 23);
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
            txtBoxAge.Size = new Size(388, 23);
            txtBoxAge.TabIndex = 8;
            txtBoxAge.KeyPress += txtBoxAge_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 188);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 7;
            label4.Text = "Student Age";
            // 
            // txtBoxCourse
            // 
            txtBoxCourse.Location = new Point(21, 266);
            txtBoxCourse.Name = "txtBoxCourse";
            txtBoxCourse.Size = new Size(388, 23);
            txtBoxCourse.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 248);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 9;
            label5.Text = "Student Course";
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = SystemColors.ActiveCaptionText;
            BtnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAdd.ForeColor = SystemColors.Control;
            BtnAdd.Location = new Point(21, 307);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(388, 37);
            BtnAdd.TabIndex = 11;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Location = new Point(21, 152);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(388, 23);
            txtBoxLastName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 131);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 5;
            label2.Text = "Student Last Name";
            // 
            // dataTblGridStudent
            // 
            dataTblGridStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTblGridStudent.Location = new Point(453, 31);
            dataTblGridStudent.Name = "dataTblGridStudent";
            dataTblGridStudent.Size = new Size(791, 439);
            dataTblGridStudent.TabIndex = 13;
            dataTblGridStudent.CellContentClick += dataTblGridStudent_CellContentClick;
            dataTblGridStudent.CellMouseDoubleClick += dataTblGridStudent_CellMouseDoubleClick;
            // 
            // cbCourse
            // 
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new Point(21, 369);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(388, 23);
            cbCourse.TabIndex = 14;
            cbCourse.SelectedIndexChanged += cbCourse_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 559);
            Controls.Add(cbCourse);
            Controls.Add(txtBoxLastName);
            Controls.Add(label2);
            Controls.Add(BtnAdd);
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
            Load += Form2_Load;
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
        private Button BtnAdd;
        private DataGridView dataTblGridStudent;
        private TextBox txtBoxLastName;
        private Label label2;
        private ComboBox cbCourse;
    }
}