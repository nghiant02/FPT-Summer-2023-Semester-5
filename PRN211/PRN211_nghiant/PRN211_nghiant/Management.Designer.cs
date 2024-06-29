namespace PRN211_nghiant
{
    partial class Management
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
            label3 = new Label();
            txtAccountID = new TextBox();
            txtAccountName = new TextBox();
            txtBranchName = new TextBox();
            dgvListStudent = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            label4 = new Label();
            txtTypeId = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cbType = new ComboBox();
            dtpOpenDate = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvListStudent).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 276);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Account ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 347);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Account Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 425);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 2;
            label3.Text = "Branch Name";
            // 
            // txtAccountID
            // 
            txtAccountID.Location = new Point(235, 272);
            txtAccountID.Margin = new Padding(3, 4, 3, 4);
            txtAccountID.Name = "txtAccountID";
            txtAccountID.Size = new Size(130, 27);
            txtAccountID.TabIndex = 3;
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(235, 343);
            txtAccountName.Margin = new Padding(3, 4, 3, 4);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(130, 27);
            txtAccountName.TabIndex = 4;
            // 
            // txtBranchName
            // 
            txtBranchName.Location = new Point(235, 421);
            txtBranchName.Margin = new Padding(3, 4, 3, 4);
            txtBranchName.Name = "txtBranchName";
            txtBranchName.Size = new Size(130, 27);
            txtBranchName.TabIndex = 5;
            // 
            // dgvListStudent
            // 
            dgvListStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListStudent.Location = new Point(5, 16);
            dgvListStudent.Margin = new Padding(3, 4, 3, 4);
            dgvListStudent.Name = "dgvListStudent";
            dgvListStudent.RowHeadersWidth = 51;
            dgvListStudent.RowTemplate.Height = 25;
            dgvListStudent.Size = new Size(969, 200);
            dgvListStudent.TabIndex = 6;
            dgvListStudent.CellDoubleClick += dgvListStudent_CellDoubleClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(641, 516);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(465, 516);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(256, 516);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(525, 280);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 10;
            label4.Text = "Type ID";
            // 
            // txtTypeId
            // 
            txtTypeId.Location = new Point(641, 276);
            txtTypeId.Margin = new Padding(3, 4, 3, 4);
            txtTypeId.Name = "txtTypeId";
            txtTypeId.Size = new Size(138, 27);
            txtTypeId.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(525, 347);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 12;
            label5.Text = "Open Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(525, 418);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 15;
            label6.Text = "AccountType";
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(641, 415);
            cbType.Margin = new Padding(3, 4, 3, 4);
            cbType.Name = "cbType";
            cbType.Size = new Size(138, 28);
            cbType.TabIndex = 16;
            // 
            // dtpOpenDate
            // 
            dtpOpenDate.FormattingEnabled = true;
            dtpOpenDate.Location = new Point(641, 343);
            dtpOpenDate.Margin = new Padding(3, 4, 3, 4);
            dtpOpenDate.Name = "dtpOpenDate";
            dtpOpenDate.Size = new Size(138, 28);
            dtpOpenDate.TabIndex = 17;
            // 
            // Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 617);
            Controls.Add(dtpOpenDate);
            Controls.Add(cbType);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtTypeId);
            Controls.Add(label4);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dgvListStudent);
            Controls.Add(txtBranchName);
            Controls.Add(txtAccountName);
            Controls.Add(txtAccountID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Management";
            Text = "Management";
            ((System.ComponentModel.ISupportInitialize)dgvListStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAccountID;
        private TextBox txtAccountName;
        private TextBox txtBranchName;
        private DataGridView dgvListStudent;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private Label label4;
        private TextBox txtTypeId;
        private Label label5;
        private Label label6;
        private ComboBox cbType;
        private ComboBox dtpOpenDate;
    }
}