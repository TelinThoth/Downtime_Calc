namespace Downtime_Calculator
{
    partial class ModifyAccount
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
            this.lbl_acctNum = new System.Windows.Forms.Label();
            this.tb_acctID = new System.Windows.Forms.TextBox();
            this.tb_accountType = new System.Windows.Forms.TextBox();
            this.lbl_acctType = new System.Windows.Forms.Label();
            this.lbl_acctOwner = new System.Windows.Forms.Label();
            this.cbx_owner = new System.Windows.Forms.ComboBox();
            this.lbl_invest = new System.Windows.Forms.Label();
            this.tb_currInvest = new System.Windows.Forms.TextBox();
            this.lbl_currNickname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_changeNickname = new System.Windows.Forms.Button();
            this.btn_transfer = new System.Windows.Forms.Button();
            this.lbl_adjustment = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_addFunds = new System.Windows.Forms.Button();
            this.btn_withdraw = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btn_modifyAccess = new System.Windows.Forms.Button();
            this.lbl_access = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_acctNum
            // 
            this.lbl_acctNum.AutoSize = true;
            this.lbl_acctNum.Location = new System.Drawing.Point(9, 13);
            this.lbl_acctNum.Name = "lbl_acctNum";
            this.lbl_acctNum.Size = new System.Drawing.Size(90, 13);
            this.lbl_acctNum.TabIndex = 0;
            this.lbl_acctNum.Text = "Account Number:";
            // 
            // tb_acctID
            // 
            this.tb_acctID.Location = new System.Drawing.Point(12, 29);
            this.tb_acctID.Name = "tb_acctID";
            this.tb_acctID.ReadOnly = true;
            this.tb_acctID.Size = new System.Drawing.Size(142, 20);
            this.tb_acctID.TabIndex = 1;
            // 
            // tb_accountType
            // 
            this.tb_accountType.Location = new System.Drawing.Point(160, 29);
            this.tb_accountType.Name = "tb_accountType";
            this.tb_accountType.ReadOnly = true;
            this.tb_accountType.Size = new System.Drawing.Size(142, 20);
            this.tb_accountType.TabIndex = 2;
            // 
            // lbl_acctType
            // 
            this.lbl_acctType.AutoSize = true;
            this.lbl_acctType.Location = new System.Drawing.Point(157, 13);
            this.lbl_acctType.Name = "lbl_acctType";
            this.lbl_acctType.Size = new System.Drawing.Size(77, 13);
            this.lbl_acctType.TabIndex = 3;
            this.lbl_acctType.Text = "Account Type:";
            // 
            // lbl_acctOwner
            // 
            this.lbl_acctOwner.AutoSize = true;
            this.lbl_acctOwner.Location = new System.Drawing.Point(12, 137);
            this.lbl_acctOwner.Name = "lbl_acctOwner";
            this.lbl_acctOwner.Size = new System.Drawing.Size(84, 13);
            this.lbl_acctOwner.TabIndex = 4;
            this.lbl_acctOwner.Text = "Account Owner:";
            // 
            // cbx_owner
            // 
            this.cbx_owner.FormattingEnabled = true;
            this.cbx_owner.Location = new System.Drawing.Point(102, 134);
            this.cbx_owner.Name = "cbx_owner";
            this.cbx_owner.Size = new System.Drawing.Size(200, 21);
            this.cbx_owner.TabIndex = 5;
            // 
            // lbl_invest
            // 
            this.lbl_invest.AutoSize = true;
            this.lbl_invest.Location = new System.Drawing.Point(9, 229);
            this.lbl_invest.Name = "lbl_invest";
            this.lbl_invest.Size = new System.Drawing.Size(99, 13);
            this.lbl_invest.TabIndex = 6;
            this.lbl_invest.Text = "Current Investment:";
            // 
            // tb_currInvest
            // 
            this.tb_currInvest.Location = new System.Drawing.Point(12, 245);
            this.tb_currInvest.Name = "tb_currInvest";
            this.tb_currInvest.ReadOnly = true;
            this.tb_currInvest.Size = new System.Drawing.Size(290, 20);
            this.tb_currInvest.TabIndex = 7;
            // 
            // lbl_currNickname
            // 
            this.lbl_currNickname.AutoSize = true;
            this.lbl_currNickname.Location = new System.Drawing.Point(9, 59);
            this.lbl_currNickname.Name = "lbl_currNickname";
            this.lbl_currNickname.Size = new System.Drawing.Size(58, 13);
            this.lbl_currNickname.TabIndex = 8;
            this.lbl_currNickname.Text = "Nickname:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 20);
            this.textBox1.TabIndex = 9;
            // 
            // btn_changeNickname
            // 
            this.btn_changeNickname.Location = new System.Drawing.Point(12, 82);
            this.btn_changeNickname.Name = "btn_changeNickname";
            this.btn_changeNickname.Size = new System.Drawing.Size(290, 23);
            this.btn_changeNickname.TabIndex = 10;
            this.btn_changeNickname.Text = "Change Nickname";
            this.btn_changeNickname.UseVisualStyleBackColor = true;
            // 
            // btn_transfer
            // 
            this.btn_transfer.Location = new System.Drawing.Point(160, 162);
            this.btn_transfer.Name = "btn_transfer";
            this.btn_transfer.Size = new System.Drawing.Size(142, 23);
            this.btn_transfer.TabIndex = 11;
            this.btn_transfer.Text = "Transfer Ownership";
            this.btn_transfer.UseVisualStyleBackColor = true;
            // 
            // lbl_adjustment
            // 
            this.lbl_adjustment.AutoSize = true;
            this.lbl_adjustment.Location = new System.Drawing.Point(12, 272);
            this.lbl_adjustment.Name = "lbl_adjustment";
            this.lbl_adjustment.Size = new System.Drawing.Size(62, 13);
            this.lbl_adjustment.TabIndex = 12;
            this.lbl_adjustment.Text = "Adjustment:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(73, 269);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 20);
            this.textBox2.TabIndex = 13;
            // 
            // btn_addFunds
            // 
            this.btn_addFunds.Location = new System.Drawing.Point(12, 295);
            this.btn_addFunds.Name = "btn_addFunds";
            this.btn_addFunds.Size = new System.Drawing.Size(142, 23);
            this.btn_addFunds.TabIndex = 14;
            this.btn_addFunds.Text = "Add Funds to Investment";
            this.btn_addFunds.UseVisualStyleBackColor = true;
            // 
            // btn_withdraw
            // 
            this.btn_withdraw.Location = new System.Drawing.Point(160, 295);
            this.btn_withdraw.Name = "btn_withdraw";
            this.btn_withdraw.Size = new System.Drawing.Size(142, 23);
            this.btn_withdraw.TabIndex = 15;
            this.btn_withdraw.Text = "Withdraw from Investment";
            this.btn_withdraw.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(308, 29);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 259);
            this.checkedListBox1.TabIndex = 16;
            // 
            // btn_modifyAccess
            // 
            this.btn_modifyAccess.Location = new System.Drawing.Point(309, 295);
            this.btn_modifyAccess.Name = "btn_modifyAccess";
            this.btn_modifyAccess.Size = new System.Drawing.Size(119, 23);
            this.btn_modifyAccess.TabIndex = 17;
            this.btn_modifyAccess.Text = "Modify Access";
            this.btn_modifyAccess.UseVisualStyleBackColor = true;
            // 
            // lbl_access
            // 
            this.lbl_access.AutoSize = true;
            this.lbl_access.Location = new System.Drawing.Point(309, 12);
            this.lbl_access.Name = "lbl_access";
            this.lbl_access.Size = new System.Drawing.Size(121, 13);
            this.lbl_access.TabIndex = 18;
            this.lbl_access.Text = "Characters With Access";
            // 
            // ModifyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 326);
            this.Controls.Add(this.lbl_access);
            this.Controls.Add(this.btn_modifyAccess);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btn_withdraw);
            this.Controls.Add(this.btn_addFunds);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_adjustment);
            this.Controls.Add(this.btn_transfer);
            this.Controls.Add(this.btn_changeNickname);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_currNickname);
            this.Controls.Add(this.tb_currInvest);
            this.Controls.Add(this.lbl_invest);
            this.Controls.Add(this.cbx_owner);
            this.Controls.Add(this.lbl_acctOwner);
            this.Controls.Add(this.lbl_acctType);
            this.Controls.Add(this.tb_accountType);
            this.Controls.Add(this.tb_acctID);
            this.Controls.Add(this.lbl_acctNum);
            this.Name = "ModifyAccount";
            this.Text = "ModifyAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_acctNum;
        private System.Windows.Forms.TextBox tb_acctID;
        private System.Windows.Forms.TextBox tb_accountType;
        private System.Windows.Forms.Label lbl_acctType;
        private System.Windows.Forms.Label lbl_acctOwner;
        private System.Windows.Forms.ComboBox cbx_owner;
        private System.Windows.Forms.Label lbl_invest;
        private System.Windows.Forms.TextBox tb_currInvest;
        private System.Windows.Forms.Label lbl_currNickname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_changeNickname;
        private System.Windows.Forms.Button btn_transfer;
        private System.Windows.Forms.Label lbl_adjustment;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_addFunds;
        private System.Windows.Forms.Button btn_withdraw;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btn_modifyAccess;
        private System.Windows.Forms.Label lbl_access;
    }
}