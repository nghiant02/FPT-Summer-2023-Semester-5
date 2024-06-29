namespace Calculator
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
            btPlus = new Button();
            btMinus = new Button();
            btTimes = new Button();
            btDivid = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            SuspendLayout();
            // 
            // btPlus
            // 
            btPlus.Location = new Point(496, 277);
            btPlus.Margin = new Padding(3, 4, 3, 4);
            btPlus.Name = "btPlus";
            btPlus.Size = new Size(86, 31);
            btPlus.TabIndex = 9;
            btPlus.Text = "+";
            btPlus.UseVisualStyleBackColor = true;
            btPlus.Click += button10_Click;
            // 
            // btMinus
            // 
            btMinus.Location = new Point(589, 277);
            btMinus.Margin = new Padding(3, 4, 3, 4);
            btMinus.Name = "btMinus";
            btMinus.Size = new Size(86, 31);
            btMinus.TabIndex = 10;
            btMinus.Text = "-";
            btMinus.UseVisualStyleBackColor = true;
            btMinus.Click += button11_Click;
            // 
            // btTimes
            // 
            btTimes.Location = new Point(496, 360);
            btTimes.Margin = new Padding(3, 4, 3, 4);
            btTimes.Name = "btTimes";
            btTimes.Size = new Size(86, 31);
            btTimes.TabIndex = 11;
            btTimes.Text = "*";
            btTimes.UseVisualStyleBackColor = true;
            btTimes.Click += button12_Click;
            // 
            // btDivid
            // 
            btDivid.Location = new Point(589, 360);
            btDivid.Margin = new Padding(3, 4, 3, 4);
            btDivid.Name = "btDivid";
            btDivid.Size = new Size(86, 31);
            btDivid.TabIndex = 12;
            btDivid.Text = "/";
            btDivid.UseVisualStyleBackColor = true;
            btDivid.Click += button13_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 281);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 13;
            label1.Text = "Number 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 364);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 14;
            label2.Text = "Number 2";
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(335, 277);
            txtNumber1.Margin = new Padding(3, 4, 3, 4);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(138, 27);
            txtNumber1.TabIndex = 15;
            txtNumber1.TextChanged += txtNumber1_TextChanged;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(335, 360);
            txtNumber2.Margin = new Padding(3, 4, 3, 4);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(138, 27);
            txtNumber2.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btDivid);
            Controls.Add(btTimes);
            Controls.Add(btMinus);
            Controls.Add(btPlus);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btPlus;
        private Button btMinus;
        private Button btTimes;
        private Button btDivid;
        private Label label1;
        private Label label2;
        private TextBox txtNumber1;
        private TextBox txtNumber2;
    }
}