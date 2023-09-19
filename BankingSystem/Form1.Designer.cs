using System;

namespace BankingSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.AccountNoLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BranchLabel = new System.Windows.Forms.Label();
            this.AccountTypeLebel = new System.Windows.Forms.Label();
            this.InitialDepositLabel = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.InitialDepositTextbox = new System.Windows.Forms.TextBox();
            this.CreateAccountBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Account = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GetInfoBtn = new System.Windows.Forms.Button();
            this.InfoNameLabel = new System.Windows.Forms.Label();
            this.InfoBranchLabel = new System.Windows.Forms.Label();
            this.InfoTyprLabel = new System.Windows.Forms.Label();
            this.InfoCurrentBalanceLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BankSecAccNo = new System.Windows.Forms.Label();
            this.BankSecAccTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AmountTextbox = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.DepositBtn = new System.Windows.Forms.Button();
            this.WithdrawBtn = new System.Windows.Forms.Button();
            this.BranchTextbox = new System.Windows.Forms.TextBox();
            this.AccountTypeTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "AB Bank Limited,Bangladesh";
            // 
            // AccountNoLabel
            // 
            this.AccountNoLabel.AutoSize = true;
            this.AccountNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNoLabel.Location = new System.Drawing.Point(0, 201);
            this.AccountNoLabel.Name = "AccountNoLabel";
            this.AccountNoLabel.Size = new System.Drawing.Size(112, 20);
            this.AccountNoLabel.TabIndex = 1;
            this.AccountNoLabel.Text = "Account No:";
            this.AccountNoLabel.Click += new System.EventHandler(this.AccountNoLabel_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(3, 240);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(63, 20);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name:";
            // 
            // BranchLabel
            // 
            this.BranchLabel.AutoSize = true;
            this.BranchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchLabel.Location = new System.Drawing.Point(3, 277);
            this.BranchLabel.Name = "BranchLabel";
            this.BranchLabel.Size = new System.Drawing.Size(75, 20);
            this.BranchLabel.TabIndex = 2;
            this.BranchLabel.Text = "Branch:";
            // 
            // AccountTypeLebel
            // 
            this.AccountTypeLebel.AutoSize = true;
            this.AccountTypeLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountTypeLebel.Location = new System.Drawing.Point(3, 315);
            this.AccountTypeLebel.Name = "AccountTypeLebel";
            this.AccountTypeLebel.Size = new System.Drawing.Size(129, 20);
            this.AccountTypeLebel.TabIndex = 2;
            this.AccountTypeLebel.Text = "Account Type:";
            // 
            // InitialDepositLabel
            // 
            this.InitialDepositLabel.AutoSize = true;
            this.InitialDepositLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitialDepositLabel.Location = new System.Drawing.Point(0, 356);
            this.InitialDepositLabel.Name = "InitialDepositLabel";
            this.InitialDepositLabel.Size = new System.Drawing.Size(132, 20);
            this.InitialDepositLabel.TabIndex = 2;
            this.InitialDepositLabel.Text = "Initial Deposit:";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextbox.Location = new System.Drawing.Point(147, 237);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(216, 27);
            this.NameTextbox.TabIndex = 3;
            // 
            // InitialDepositTextbox
            // 
            this.InitialDepositTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitialDepositTextbox.Location = new System.Drawing.Point(147, 356);
            this.InitialDepositTextbox.Name = "InitialDepositTextbox";
            this.InitialDepositTextbox.Size = new System.Drawing.Size(216, 27);
            this.InitialDepositTextbox.TabIndex = 3;
            // 
            // CreateAccountBtn
            // 
            this.CreateAccountBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.CreateAccountBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountBtn.Location = new System.Drawing.Point(196, 405);
            this.CreateAccountBtn.Name = "CreateAccountBtn";
            this.CreateAccountBtn.Size = new System.Drawing.Size(167, 29);
            this.CreateAccountBtn.TabIndex = 5;
            this.CreateAccountBtn.Text = "Create Account";
            this.CreateAccountBtn.UseVisualStyleBackColor = false;
            this.CreateAccountBtn.Click += new System.EventHandler(this.CreateAccountBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Create Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(498, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Information";
            // 
            // Account
            // 
            this.Account.AutoSize = true;
            this.Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Account.Location = new System.Drawing.Point(400, 154);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(112, 20);
            this.Account.TabIndex = 1;
            this.Account.Text = "Account No:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(544, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 27);
            this.textBox1.TabIndex = 3;
            // 
            // GetInfoBtn
            // 
            this.GetInfoBtn.BackColor = System.Drawing.Color.Gold;
            this.GetInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetInfoBtn.Location = new System.Drawing.Point(569, 198);
            this.GetInfoBtn.Name = "GetInfoBtn";
            this.GetInfoBtn.Size = new System.Drawing.Size(167, 29);
            this.GetInfoBtn.TabIndex = 5;
            this.GetInfoBtn.Text = "Get Information";
            this.GetInfoBtn.UseVisualStyleBackColor = false;
            this.GetInfoBtn.Click += new System.EventHandler(this.GetInfoBtn_Click);
            // 
            // InfoNameLabel
            // 
            this.InfoNameLabel.AutoSize = true;
            this.InfoNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoNameLabel.Location = new System.Drawing.Point(400, 254);
            this.InfoNameLabel.Name = "InfoNameLabel";
            this.InfoNameLabel.Size = new System.Drawing.Size(63, 20);
            this.InfoNameLabel.TabIndex = 2;
            this.InfoNameLabel.Text = "Name:";
            // 
            // InfoBranchLabel
            // 
            this.InfoBranchLabel.AutoSize = true;
            this.InfoBranchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBranchLabel.Location = new System.Drawing.Point(400, 291);
            this.InfoBranchLabel.Name = "InfoBranchLabel";
            this.InfoBranchLabel.Size = new System.Drawing.Size(75, 20);
            this.InfoBranchLabel.TabIndex = 2;
            this.InfoBranchLabel.Text = "Branch:";
            // 
            // InfoTyprLabel
            // 
            this.InfoTyprLabel.AutoSize = true;
            this.InfoTyprLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoTyprLabel.Location = new System.Drawing.Point(400, 329);
            this.InfoTyprLabel.Name = "InfoTyprLabel";
            this.InfoTyprLabel.Size = new System.Drawing.Size(129, 20);
            this.InfoTyprLabel.TabIndex = 2;
            this.InfoTyprLabel.Text = "Account Type:";
            // 
            // InfoCurrentBalanceLabel
            // 
            this.InfoCurrentBalanceLabel.AutoSize = true;
            this.InfoCurrentBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoCurrentBalanceLabel.Location = new System.Drawing.Point(397, 370);
            this.InfoCurrentBalanceLabel.Name = "InfoCurrentBalanceLabel";
            this.InfoCurrentBalanceLabel.Size = new System.Drawing.Size(152, 20);
            this.InfoCurrentBalanceLabel.TabIndex = 2;
            this.InfoCurrentBalanceLabel.Text = "Current Balance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(899, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Banking Section";
            // 
            // BankSecAccNo
            // 
            this.BankSecAccNo.AutoSize = true;
            this.BankSecAccNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankSecAccNo.Location = new System.Drawing.Point(794, 154);
            this.BankSecAccNo.Name = "BankSecAccNo";
            this.BankSecAccNo.Size = new System.Drawing.Size(112, 20);
            this.BankSecAccNo.TabIndex = 1;
            this.BankSecAccNo.Text = "Account No:";
            // 
            // BankSecAccTextbox
            // 
            this.BankSecAccTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankSecAccTextbox.Location = new System.Drawing.Point(922, 147);
            this.BankSecAccTextbox.Name = "BankSecAccTextbox";
            this.BankSecAccTextbox.Size = new System.Drawing.Size(216, 27);
            this.BankSecAccTextbox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(794, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 1;
            // 
            // AmountTextbox
            // 
            this.AmountTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountTextbox.Location = new System.Drawing.Point(922, 191);
            this.AmountTextbox.Name = "AmountTextbox";
            this.AmountTextbox.Size = new System.Drawing.Size(216, 27);
            this.AmountTextbox.TabIndex = 3;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(794, 195);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(78, 20);
            this.AmountLabel.TabIndex = 2;
            this.AmountLabel.Text = "Amount:";
            // 
            // DepositBtn
            // 
            this.DepositBtn.BackColor = System.Drawing.Color.Red;
            this.DepositBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositBtn.Location = new System.Drawing.Point(951, 254);
            this.DepositBtn.Name = "DepositBtn";
            this.DepositBtn.Size = new System.Drawing.Size(167, 29);
            this.DepositBtn.TabIndex = 5;
            this.DepositBtn.Text = "Deposit";
            this.DepositBtn.UseVisualStyleBackColor = false;
            // 
            // WithdrawBtn
            // 
            this.WithdrawBtn.BackColor = System.Drawing.Color.Red;
            this.WithdrawBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawBtn.Location = new System.Drawing.Point(951, 289);
            this.WithdrawBtn.Name = "WithdrawBtn";
            this.WithdrawBtn.Size = new System.Drawing.Size(167, 29);
            this.WithdrawBtn.TabIndex = 5;
            this.WithdrawBtn.Text = "Withdraw";
            this.WithdrawBtn.UseVisualStyleBackColor = false;
            // 
            // BranchTextbox
            // 
            this.BranchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchTextbox.Location = new System.Drawing.Point(147, 274);
            this.BranchTextbox.Name = "BranchTextbox";
            this.BranchTextbox.Size = new System.Drawing.Size(216, 27);
            this.BranchTextbox.TabIndex = 3;
            // 
            // AccountTypeTextbox
            // 
            this.AccountTypeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountTypeTextbox.Location = new System.Drawing.Point(147, 315);
            this.AccountTypeTextbox.Name = "AccountTypeTextbox";
            this.AccountTypeTextbox.Size = new System.Drawing.Size(216, 27);
            this.AccountTypeTextbox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 510);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DepositBtn);
            this.Controls.Add(this.WithdrawBtn);
            this.Controls.Add(this.GetInfoBtn);
            this.Controls.Add(this.CreateAccountBtn);
            this.Controls.Add(this.InitialDepositTextbox);
            this.Controls.Add(this.AccountTypeTextbox);
            this.Controls.Add(this.BranchTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.AmountTextbox);
            this.Controls.Add(this.BankSecAccTextbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.InfoCurrentBalanceLabel);
            this.Controls.Add(this.InitialDepositLabel);
            this.Controls.Add(this.InfoTyprLabel);
            this.Controls.Add(this.InfoBranchLabel);
            this.Controls.Add(this.AccountTypeLebel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BranchLabel);
            this.Controls.Add(this.BankSecAccNo);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.InfoNameLabel);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AccountNoLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void GetInfoBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AccountNoLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AccountNoLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label BranchLabel;
        private System.Windows.Forms.Label AccountTypeLebel;
        private System.Windows.Forms.Label InitialDepositLabel;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox InitialDepositTextbox;
        private System.Windows.Forms.Button CreateAccountBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Account;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button GetInfoBtn;
        private System.Windows.Forms.Label InfoNameLabel;
        private System.Windows.Forms.Label InfoBranchLabel;
        private System.Windows.Forms.Label InfoTyprLabel;
        private System.Windows.Forms.Label InfoCurrentBalanceLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label BankSecAccNo;
        private System.Windows.Forms.TextBox BankSecAccTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AmountTextbox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Button DepositBtn;
        private System.Windows.Forms.Button WithdrawBtn;
        private System.Windows.Forms.TextBox BranchTextbox;
        private System.Windows.Forms.TextBox AccountTypeTextbox;
    }
}

