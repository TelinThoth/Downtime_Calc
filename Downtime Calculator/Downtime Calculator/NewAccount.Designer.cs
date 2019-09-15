namespace Downtime_Calculator
{
    partial class NewAccount
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
            this.lbl_newAccountOwner = new System.Windows.Forms.Label();
            this.cb_accountOwner = new System.Windows.Forms.ComboBox();
            this.lbl_accountType = new System.Windows.Forms.Label();
            this.cb_accountType = new System.Windows.Forms.ComboBox();
            this.lbl_investAmount = new System.Windows.Forms.Label();
            this.tb_investment = new System.Windows.Forms.TextBox();
            this.tb_nickname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_autoReinvest = new System.Windows.Forms.CheckBox();
            this.lbl_reinvestAccount = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_createAccount = new System.Windows.Forms.Button();
            this.cb_reinvestAccount = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_newAccountOwner
            // 
            this.lbl_newAccountOwner.AutoSize = true;
            this.lbl_newAccountOwner.Location = new System.Drawing.Point(13, 13);
            this.lbl_newAccountOwner.Name = "lbl_newAccountOwner";
            this.lbl_newAccountOwner.Size = new System.Drawing.Size(109, 13);
            this.lbl_newAccountOwner.TabIndex = 0;
            this.lbl_newAccountOwner.Text = "New Account Owner:";
            // 
            // cb_accountOwner
            // 
            this.cb_accountOwner.FormattingEnabled = true;
            this.cb_accountOwner.Location = new System.Drawing.Point(128, 10);
            this.cb_accountOwner.Name = "cb_accountOwner";
            this.cb_accountOwner.Size = new System.Drawing.Size(238, 21);
            this.cb_accountOwner.TabIndex = 1;
            // 
            // lbl_accountType
            // 
            this.lbl_accountType.AutoSize = true;
            this.lbl_accountType.Location = new System.Drawing.Point(45, 48);
            this.lbl_accountType.Name = "lbl_accountType";
            this.lbl_accountType.Size = new System.Drawing.Size(77, 13);
            this.lbl_accountType.TabIndex = 2;
            this.lbl_accountType.Text = "Account Type:";
            // 
            // cb_accountType
            // 
            this.cb_accountType.FormattingEnabled = true;
            this.cb_accountType.Location = new System.Drawing.Point(128, 45);
            this.cb_accountType.Name = "cb_accountType";
            this.cb_accountType.Size = new System.Drawing.Size(238, 21);
            this.cb_accountType.TabIndex = 3;
            // 
            // lbl_investAmount
            // 
            this.lbl_investAmount.AutoSize = true;
            this.lbl_investAmount.Location = new System.Drawing.Point(21, 115);
            this.lbl_investAmount.Name = "lbl_investAmount";
            this.lbl_investAmount.Size = new System.Drawing.Size(101, 13);
            this.lbl_investAmount.TabIndex = 4;
            this.lbl_investAmount.Text = "Investment Amount:";
            // 
            // tb_investment
            // 
            this.tb_investment.Location = new System.Drawing.Point(128, 112);
            this.tb_investment.Name = "tb_investment";
            this.tb_investment.Size = new System.Drawing.Size(238, 20);
            this.tb_investment.TabIndex = 5;
            // 
            // tb_nickname
            // 
            this.tb_nickname.Location = new System.Drawing.Point(128, 73);
            this.tb_nickname.Name = "tb_nickname";
            this.tb_nickname.Size = new System.Drawing.Size(238, 20);
            this.tb_nickname.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Account Label:";
            // 
            // cb_autoReinvest
            // 
            this.cb_autoReinvest.AutoSize = true;
            this.cb_autoReinvest.Location = new System.Drawing.Point(24, 167);
            this.cb_autoReinvest.Name = "cb_autoReinvest";
            this.cb_autoReinvest.Size = new System.Drawing.Size(139, 17);
            this.cb_autoReinvest.TabIndex = 8;
            this.cb_autoReinvest.Text = "Automatically Reinvest?";
            this.cb_autoReinvest.UseVisualStyleBackColor = true;
            this.cb_autoReinvest.CheckedChanged += new System.EventHandler(this.Cb_autoReinvest_CheckedChanged);
            // 
            // lbl_reinvestAccount
            // 
            this.lbl_reinvestAccount.AutoSize = true;
            this.lbl_reinvestAccount.Enabled = false;
            this.lbl_reinvestAccount.Location = new System.Drawing.Point(50, 191);
            this.lbl_reinvestAccount.Name = "lbl_reinvestAccount";
            this.lbl_reinvestAccount.Size = new System.Drawing.Size(72, 13);
            this.lbl_reinvestAccount.TabIndex = 9;
            this.lbl_reinvestAccount.Text = "Reinvest into:";
            this.lbl_reinvestAccount.Visible = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(12, 230);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(140, 23);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // btn_createAccount
            // 
            this.btn_createAccount.Location = new System.Drawing.Point(226, 230);
            this.btn_createAccount.Name = "btn_createAccount";
            this.btn_createAccount.Size = new System.Drawing.Size(140, 23);
            this.btn_createAccount.TabIndex = 12;
            this.btn_createAccount.Text = "Create Account";
            this.btn_createAccount.UseVisualStyleBackColor = true;
            this.btn_createAccount.Click += new System.EventHandler(this.Btn_createAccount_Click);
            // 
            // cb_reinvestAccount
            // 
            this.cb_reinvestAccount.Enabled = false;
            this.cb_reinvestAccount.FormattingEnabled = true;
            this.cb_reinvestAccount.Location = new System.Drawing.Point(128, 188);
            this.cb_reinvestAccount.Name = "cb_reinvestAccount";
            this.cb_reinvestAccount.Size = new System.Drawing.Size(238, 21);
            this.cb_reinvestAccount.TabIndex = 13;
            this.cb_reinvestAccount.Visible = false;
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 259);
            this.Controls.Add(this.cb_reinvestAccount);
            this.Controls.Add(this.btn_createAccount);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_reinvestAccount);
            this.Controls.Add(this.cb_autoReinvest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nickname);
            this.Controls.Add(this.tb_investment);
            this.Controls.Add(this.lbl_investAmount);
            this.Controls.Add(this.cb_accountType);
            this.Controls.Add(this.lbl_accountType);
            this.Controls.Add(this.cb_accountOwner);
            this.Controls.Add(this.lbl_newAccountOwner);
            this.Name = "NewAccount";
            this.Text = "Create New Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_newAccountOwner;
        private System.Windows.Forms.ComboBox cb_accountOwner;
        private System.Windows.Forms.Label lbl_accountType;
        private System.Windows.Forms.ComboBox cb_accountType;
        private System.Windows.Forms.Label lbl_investAmount;
        private System.Windows.Forms.TextBox tb_investment;
        private System.Windows.Forms.TextBox tb_nickname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_autoReinvest;
        private System.Windows.Forms.Label lbl_reinvestAccount;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_createAccount;
        private System.Windows.Forms.ComboBox cb_reinvestAccount;
    }
}