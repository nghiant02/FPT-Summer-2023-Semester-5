namespace PRN211PE_FA22_TrialTest_Nghia
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
            btnSearch = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnCreate = new Button();
            txtCategoryID = new TextBox();
            txtPrice = new TextBox();
            txtDateCreate = new TextBox();
            txtProductCode = new TextBox();
            txtProductName = new TextBox();
            txtID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvAdministrator = new DataGridView();
            label8 = new Label();
            cmbCategory = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvAdministrator).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(701, 108);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 36;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(236, 568);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 35;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(131, 568);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 34;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 568);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 33;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(131, 337);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(125, 27);
            txtCategoryID.TabIndex = 32;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(131, 409);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 31;
            // 
            // txtDateCreate
            // 
            txtDateCreate.Location = new Point(131, 471);
            txtDateCreate.Name = "txtDateCreate";
            txtDateCreate.Size = new Size(125, 27);
            txtDateCreate.TabIndex = 30;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(436, 108);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(212, 27);
            txtProductCode.TabIndex = 29;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(131, 278);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 28;
            // 
            // txtID
            // 
            txtID.Location = new Point(131, 213);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 409);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 26;
            label7.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 471);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 25;
            label6.Text = "DateCreate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(245, 108);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 24;
            label5.Text = "ProductCode";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 278);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 23;
            label4.Text = "ProductName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 209);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 22;
            label3.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 337);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 21;
            label2.Text = "CategoryID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(268, 13);
            label1.Name = "label1";
            label1.Size = new Size(463, 62);
            label1.TabIndex = 20;
            label1.Text = "Management Form";
            // 
            // dgvAdministrator
            // 
            dgvAdministrator.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdministrator.Location = new Point(354, 154);
            dgvAdministrator.Margin = new Padding(3, 4, 3, 4);
            dgvAdministrator.Name = "dgvAdministrator";
            dgvAdministrator.RowHeadersWidth = 51;
            dgvAdministrator.RowTemplate.Height = 25;
            dgvAdministrator.Size = new Size(676, 478);
            dgvAdministrator.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 515);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 37;
            label8.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(131, 515);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(125, 28);
            cmbCategory.TabIndex = 38;
            // 
            // Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 667);
            Controls.Add(cmbCategory);
            Controls.Add(label8);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(txtCategoryID);
            Controls.Add(txtPrice);
            Controls.Add(txtDateCreate);
            Controls.Add(txtProductCode);
            Controls.Add(txtProductName);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvAdministrator);
            Name = "Management";
            Text = "Management";
            ((System.ComponentModel.ISupportInitialize)dgvAdministrator).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCreate;
        private TextBox txtCategoryID;
        private TextBox txtPrice;
        private TextBox txtDateCreate;
        private TextBox txtProductCode;
        private TextBox txtProductName;
        private TextBox txtID;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvAdministrator;
        private Label label8;
        private ComboBox cmbCategory;
    }
}