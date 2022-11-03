namespace BankForms
{
    partial class Form1
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
            this.accountGroup = new System.Windows.Forms.GroupBox();
            this.createAccount = new System.Windows.Forms.Button();
            this.interestRate = new System.Windows.Forms.TextBox();
            this.debet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.savingsAccount = new System.Windows.Forms.RadioButton();
            this.debetAccount = new System.Windows.Forms.RadioButton();
            this.regularAccount = new System.Windows.Forms.RadioButton();
            this.accountBalance = new System.Windows.Forms.TextBox();
            this.accountOwner = new System.Windows.Forms.TextBox();
            this.accountNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bankCode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbAccounts = new System.Windows.Forms.ListBox();
            this.createTransaction = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.transactionAmount = new System.Windows.Forms.TextBox();
            this.transactionType = new System.Windows.Forms.ComboBox();
            this.tslContextMessages = new System.Windows.Forms.ToolStrip();
            this.accountGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountGroup
            // 
            this.accountGroup.Controls.Add(this.createAccount);
            this.accountGroup.Controls.Add(this.interestRate);
            this.accountGroup.Controls.Add(this.debet);
            this.accountGroup.Controls.Add(this.label9);
            this.accountGroup.Controls.Add(this.label8);
            this.accountGroup.Controls.Add(this.label7);
            this.accountGroup.Controls.Add(this.label6);
            this.accountGroup.Controls.Add(this.savingsAccount);
            this.accountGroup.Controls.Add(this.debetAccount);
            this.accountGroup.Controls.Add(this.regularAccount);
            this.accountGroup.Controls.Add(this.accountBalance);
            this.accountGroup.Controls.Add(this.accountOwner);
            this.accountGroup.Controls.Add(this.accountNum);
            this.accountGroup.Controls.Add(this.label5);
            this.accountGroup.Controls.Add(this.bankCode);
            this.accountGroup.Controls.Add(this.label3);
            this.accountGroup.Controls.Add(this.label2);
            this.accountGroup.Controls.Add(this.label1);
            this.accountGroup.Location = new System.Drawing.Point(12, 12);
            this.accountGroup.Name = "accountGroup";
            this.accountGroup.Size = new System.Drawing.Size(508, 437);
            this.accountGroup.TabIndex = 0;
            this.accountGroup.TabStop = false;
            this.accountGroup.Text = "New Account";
            // 
            // createAccount
            // 
            this.createAccount.Location = new System.Drawing.Point(157, 396);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(161, 35);
            this.createAccount.TabIndex = 17;
            this.createAccount.Text = "Create Account";
            this.createAccount.UseVisualStyleBackColor = true;
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // interestRate
            // 
            this.interestRate.Enabled = false;
            this.interestRate.Location = new System.Drawing.Point(265, 329);
            this.interestRate.Name = "interestRate";
            this.interestRate.Size = new System.Drawing.Size(100, 22);
            this.interestRate.TabIndex = 16;
            this.interestRate.Text = "3.6";
            this.interestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.interestRate_KeyPress);
            // 
            // debet
            // 
            this.debet.Enabled = false;
            this.debet.Location = new System.Drawing.Point(265, 271);
            this.debet.Name = "debet";
            this.debet.Size = new System.Drawing.Size(100, 22);
            this.debet.TabIndex = 15;
            this.debet.Text = "2000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(371, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Interest:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Kč";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Debet:";
            // 
            // savingsAccount
            // 
            this.savingsAccount.AutoSize = true;
            this.savingsAccount.Location = new System.Drawing.Point(29, 329);
            this.savingsAccount.Name = "savingsAccount";
            this.savingsAccount.Size = new System.Drawing.Size(127, 20);
            this.savingsAccount.TabIndex = 10;
            this.savingsAccount.Text = "Savings account";
            this.savingsAccount.UseVisualStyleBackColor = true;
            this.savingsAccount.CheckedChanged += new System.EventHandler(this.savingsAccount_CheckedChanged);
            // 
            // debetAccount
            // 
            this.debetAccount.AutoSize = true;
            this.debetAccount.Location = new System.Drawing.Point(29, 271);
            this.debetAccount.Name = "debetAccount";
            this.debetAccount.Size = new System.Drawing.Size(115, 20);
            this.debetAccount.TabIndex = 9;
            this.debetAccount.Text = "Debet account";
            this.debetAccount.UseVisualStyleBackColor = true;
            this.debetAccount.CheckedChanged += new System.EventHandler(this.debetAccount_CheckedChanged);
            // 
            // regularAccount
            // 
            this.regularAccount.AutoSize = true;
            this.regularAccount.Checked = true;
            this.regularAccount.Location = new System.Drawing.Point(29, 214);
            this.regularAccount.Name = "regularAccount";
            this.regularAccount.Size = new System.Drawing.Size(127, 20);
            this.regularAccount.TabIndex = 8;
            this.regularAccount.TabStop = true;
            this.regularAccount.Text = "Regular Account";
            this.regularAccount.UseVisualStyleBackColor = true;
            this.regularAccount.CheckedChanged += new System.EventHandler(this.regularAccount_CheckedChanged);
            // 
            // accountBalance
            // 
            this.accountBalance.Location = new System.Drawing.Point(157, 138);
            this.accountBalance.Name = "accountBalance";
            this.accountBalance.Size = new System.Drawing.Size(157, 22);
            this.accountBalance.TabIndex = 7;
            this.accountBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accountBalance_KeyPress);
            // 
            // accountOwner
            // 
            this.accountOwner.Location = new System.Drawing.Point(157, 84);
            this.accountOwner.Name = "accountOwner";
            this.accountOwner.Size = new System.Drawing.Size(157, 22);
            this.accountOwner.TabIndex = 6;
            // 
            // accountNum
            // 
            this.accountNum.Location = new System.Drawing.Point(157, 32);
            this.accountNum.Name = "accountNum";
            this.accountNum.Size = new System.Drawing.Size(157, 22);
            this.accountNum.TabIndex = 5;
            this.accountNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accountNum_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kč";
            // 
            // bankCode
            // 
            this.bankCode.AutoSize = true;
            this.bankCode.Location = new System.Drawing.Point(332, 35);
            this.bankCode.Name = "bankCode";
            this.bankCode.Size = new System.Drawing.Size(74, 16);
            this.bankCode.TabIndex = 3;
            this.bankCode.Text = "/bankCode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account owner: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbAccounts);
            this.groupBox2.Controls.Add(this.createTransaction);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.transactionAmount);
            this.groupBox2.Controls.Add(this.transactionType);
            this.groupBox2.Location = new System.Drawing.Point(526, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 436);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction";
            // 
            // lbAccounts
            // 
            this.lbAccounts.FormattingEnabled = true;
            this.lbAccounts.ItemHeight = 16;
            this.lbAccounts.Location = new System.Drawing.Point(6, 154);
            this.lbAccounts.Name = "lbAccounts";
            this.lbAccounts.Size = new System.Drawing.Size(494, 276);
            this.lbAccounts.TabIndex = 5;
            // 
            // createTransaction
            // 
            this.createTransaction.Location = new System.Drawing.Point(236, 78);
            this.createTransaction.Name = "createTransaction";
            this.createTransaction.Size = new System.Drawing.Size(165, 39);
            this.createTransaction.TabIndex = 4;
            this.createTransaction.Text = "Accept";
            this.createTransaction.UseVisualStyleBackColor = true;
            this.createTransaction.Click += new System.EventHandler(this.createTransaction_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(407, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Czk";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Amount";
            // 
            // transactionAmount
            // 
            this.transactionAmount.Location = new System.Drawing.Point(236, 42);
            this.transactionAmount.Name = "transactionAmount";
            this.transactionAmount.Size = new System.Drawing.Size(165, 22);
            this.transactionAmount.TabIndex = 1;
            this.transactionAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.transactionAmount_KeyPress);
            // 
            // transactionType
            // 
            this.transactionType.FormattingEnabled = true;
            this.transactionType.Items.AddRange(new object[] {
            "Withdraw",
            "Deposit",
            "Apply Interest"});
            this.transactionType.Location = new System.Drawing.Point(6, 42);
            this.transactionType.Name = "transactionType";
            this.transactionType.Size = new System.Drawing.Size(167, 24);
            this.transactionType.TabIndex = 0;
            this.transactionType.SelectedIndexChanged += new System.EventHandler(this.transactionType_SelectedIndexChanged);
            // 
            // tslContextMessages
            // 
            this.tslContextMessages.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tslContextMessages.Location = new System.Drawing.Point(0, 0);
            this.tslContextMessages.Name = "tslContextMessages";
            this.tslContextMessages.Size = new System.Drawing.Size(1044, 25);
            this.tslContextMessages.TabIndex = 2;
            this.tslContextMessages.Text = "toolStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 461);
            this.Controls.Add(this.tslContextMessages);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.accountGroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.accountGroup.ResumeLayout(false);
            this.accountGroup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox accountGroup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox accountBalance;
        private System.Windows.Forms.TextBox accountOwner;
        private System.Windows.Forms.TextBox accountNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bankCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createAccount;
        private System.Windows.Forms.TextBox interestRate;
        private System.Windows.Forms.TextBox debet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton savingsAccount;
        private System.Windows.Forms.RadioButton debetAccount;
        private System.Windows.Forms.RadioButton regularAccount;
        private System.Windows.Forms.ListBox lbAccounts;
        private System.Windows.Forms.Button createTransaction;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox transactionAmount;
        private System.Windows.Forms.ComboBox transactionType;
        private System.Windows.Forms.ToolStrip tslContextMessages;
    }
}

