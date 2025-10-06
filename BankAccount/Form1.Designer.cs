namespace BankAccount
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
            groupBox1 = new GroupBox();
            nmrBalance = new NumericUpDown();
            label1 = new Label();
            btnCreate = new Button();
            groupBox2 = new GroupBox();
            btnWithdraw = new Button();
            btnDonate = new Button();
            label3 = new Label();
            label2 = new Label();
            nmrWithdraw = new NumericUpDown();
            nmrDonate = new NumericUpDown();
            groupBox3 = new GroupBox();
            lblBalance = new Label();
            groupBox4 = new GroupBox();
            lstOperations = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrBalance).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrWithdraw).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrDonate).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nmrBalance);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Location = new Point(118, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(601, 65);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Otwórz konto";
            // 
            // nmrBalance
            // 
            nmrBalance.Location = new Point(156, 20);
            nmrBalance.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nmrBalance.Name = "nmrBalance";
            nmrBalance.Size = new Size(120, 23);
            nmrBalance.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 28);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 2;
            label1.Text = "Saldo początkowe:";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(298, 20);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "Utwórz";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnWithdraw);
            groupBox2.Controls.Add(btnDonate);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(nmrWithdraw);
            groupBox2.Controls.Add(nmrDonate);
            groupBox2.Enabled = false;
            groupBox2.Location = new Point(118, 98);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(601, 137);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operacje na koncie";
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(298, 83);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(75, 23);
            btnWithdraw.TabIndex = 11;
            btnWithdraw.Text = "Wypłać";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnDonate
            // 
            btnDonate.Location = new Point(298, 36);
            btnDonate.Name = "btnDonate";
            btnDonate.Size = new Size(75, 23);
            btnDonate.TabIndex = 10;
            btnDonate.Text = "Wpłać";
            btnDonate.UseVisualStyleBackColor = true;
            btnDonate.Click += btnDonate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 87);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 8;
            label3.Text = "Kwota:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 44);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 7;
            label2.Text = "Kwota:";
            // 
            // nmrWithdraw
            // 
            nmrWithdraw.Location = new Point(156, 79);
            nmrWithdraw.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nmrWithdraw.Name = "nmrWithdraw";
            nmrWithdraw.Size = new Size(120, 23);
            nmrWithdraw.TabIndex = 6;
            // 
            // nmrDonate
            // 
            nmrDonate.Location = new Point(156, 36);
            nmrDonate.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nmrDonate.Name = "nmrDonate";
            nmrDonate.Size = new Size(120, 23);
            nmrDonate.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblBalance);
            groupBox3.Location = new Point(118, 265);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(601, 116);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Stan konta";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(269, 53);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(13, 15);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "0";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lstOperations);
            groupBox4.Location = new Point(118, 419);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(601, 203);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Lista operacji";
            // 
            // lstOperations
            // 
            lstOperations.FormattingEnabled = true;
            lstOperations.ItemHeight = 15;
            lstOperations.Location = new Point(18, 24);
            lstOperations.Name = "lstOperations";
            lstOperations.Size = new Size(563, 169);
            lstOperations.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 624);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrBalance).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrWithdraw).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrDonate).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private NumericUpDown nmrBalance;
        private Label label1;
        private NumericUpDown nmrWithdraw;
        private NumericUpDown nmrDonate;
        private Button btnCreate;
        private Button btnWithdraw;
        private Button btnDonate;
        private Label label3;
        private Label label2;
        private Label lblBalance;
        private ListBox lstOperations;
    }
}
