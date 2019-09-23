namespace Downtime_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lstBx_Players = new System.Windows.Forms.ListBox();
            this.lstBx_Characters = new System.Windows.Forms.ListBox();
            this.lstBx_Accounts = new System.Windows.Forms.ListBox();
            this.tb_Investment = new System.Windows.Forms.TextBox();
            this.lbl_Investment = new System.Windows.Forms.Label();
            this.btn_manageAccount = new System.Windows.Forms.Button();
            this.btn_removePlayer = new System.Windows.Forms.Button();
            this.btn_newPlayer = new System.Windows.Forms.Button();
            this.btn_AddCharacter = new System.Windows.Forms.Button();
            this.btn_deleteCharacter = new System.Windows.Forms.Button();
            this.btn_removeAccess = new System.Windows.Forms.Button();
            this.btn_addAccount = new System.Windows.Forms.Button();
            this.lbl_accID = new System.Windows.Forms.Label();
            this.tb_accID = new System.Windows.Forms.TextBox();
            this.tb_accType = new System.Windows.Forms.TextBox();
            this.lbl_accType = new System.Windows.Forms.Label();
            this.tb_accOwner = new System.Windows.Forms.TextBox();
            this.lbl_accOwner = new System.Windows.Forms.Label();
            this.chb_reinvest = new System.Windows.Forms.CheckBox();
            this.lbl_accAcs = new System.Windows.Forms.Label();
            this.lstbx_accAcs = new System.Windows.Forms.ListBox();
            this.btn_calcReturn = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(581, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.OpenToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.SaveToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // lstBx_Players
            // 
            this.lstBx_Players.FormattingEnabled = true;
            this.lstBx_Players.Location = new System.Drawing.Point(0, 29);
            this.lstBx_Players.Name = "lstBx_Players";
            this.lstBx_Players.Size = new System.Drawing.Size(132, 433);
            this.lstBx_Players.TabIndex = 1;
            this.lstBx_Players.SelectedIndexChanged += new System.EventHandler(this.LstBx_Players_SelectedIndexChanged);
            // 
            // lstBx_Characters
            // 
            this.lstBx_Characters.FormattingEnabled = true;
            this.lstBx_Characters.Location = new System.Drawing.Point(138, 29);
            this.lstBx_Characters.Name = "lstBx_Characters";
            this.lstBx_Characters.Size = new System.Drawing.Size(132, 433);
            this.lstBx_Characters.TabIndex = 2;
            this.lstBx_Characters.SelectedIndexChanged += new System.EventHandler(this.LstBx_Characters_SelectedIndexChanged);
            // 
            // lstBx_Accounts
            // 
            this.lstBx_Accounts.FormattingEnabled = true;
            this.lstBx_Accounts.Location = new System.Drawing.Point(276, 29);
            this.lstBx_Accounts.Name = "lstBx_Accounts";
            this.lstBx_Accounts.Size = new System.Drawing.Size(132, 433);
            this.lstBx_Accounts.TabIndex = 3;
            this.lstBx_Accounts.SelectedIndexChanged += new System.EventHandler(this.LstBx_Accounts_SelectedIndexChanged);
            // 
            // tb_Investment
            // 
            this.tb_Investment.Location = new System.Drawing.Point(414, 45);
            this.tb_Investment.Name = "tb_Investment";
            this.tb_Investment.ReadOnly = true;
            this.tb_Investment.Size = new System.Drawing.Size(155, 20);
            this.tb_Investment.TabIndex = 3;
            this.tb_Investment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Investment
            // 
            this.lbl_Investment.AutoSize = true;
            this.lbl_Investment.Location = new System.Drawing.Point(415, 29);
            this.lbl_Investment.Name = "lbl_Investment";
            this.lbl_Investment.Size = new System.Drawing.Size(89, 13);
            this.lbl_Investment.TabIndex = 5;
            this.lbl_Investment.Text = "Account Balance";
            // 
            // btn_manageAccount
            // 
            this.btn_manageAccount.Location = new System.Drawing.Point(414, 72);
            this.btn_manageAccount.Name = "btn_manageAccount";
            this.btn_manageAccount.Size = new System.Drawing.Size(155, 23);
            this.btn_manageAccount.TabIndex = 6;
            this.btn_manageAccount.Text = "Manage Account";
            this.btn_manageAccount.UseVisualStyleBackColor = true;
            this.btn_manageAccount.Click += new System.EventHandler(this.Btn_manageAccount_Click);
            // 
            // btn_removePlayer
            // 
            this.btn_removePlayer.Location = new System.Drawing.Point(0, 494);
            this.btn_removePlayer.Name = "btn_removePlayer";
            this.btn_removePlayer.Size = new System.Drawing.Size(132, 23);
            this.btn_removePlayer.TabIndex = 7;
            this.btn_removePlayer.Text = "Remove Player";
            this.btn_removePlayer.UseVisualStyleBackColor = true;
            // 
            // btn_newPlayer
            // 
            this.btn_newPlayer.Location = new System.Drawing.Point(0, 468);
            this.btn_newPlayer.Name = "btn_newPlayer";
            this.btn_newPlayer.Size = new System.Drawing.Size(132, 23);
            this.btn_newPlayer.TabIndex = 8;
            this.btn_newPlayer.Text = "Add New Player";
            this.btn_newPlayer.UseVisualStyleBackColor = true;
            this.btn_newPlayer.Click += new System.EventHandler(this.Btn_newPlayer_Click);
            // 
            // btn_AddCharacter
            // 
            this.btn_AddCharacter.Location = new System.Drawing.Point(138, 468);
            this.btn_AddCharacter.Name = "btn_AddCharacter";
            this.btn_AddCharacter.Size = new System.Drawing.Size(131, 23);
            this.btn_AddCharacter.TabIndex = 9;
            this.btn_AddCharacter.Text = "Attach Character";
            this.btn_AddCharacter.UseVisualStyleBackColor = true;
            this.btn_AddCharacter.Click += new System.EventHandler(this.Btn_AddCharacter_Click);
            // 
            // btn_deleteCharacter
            // 
            this.btn_deleteCharacter.Location = new System.Drawing.Point(138, 494);
            this.btn_deleteCharacter.Name = "btn_deleteCharacter";
            this.btn_deleteCharacter.Size = new System.Drawing.Size(131, 23);
            this.btn_deleteCharacter.TabIndex = 10;
            this.btn_deleteCharacter.Text = "Delete Character";
            this.btn_deleteCharacter.UseVisualStyleBackColor = true;
            // 
            // btn_removeAccess
            // 
            this.btn_removeAccess.Location = new System.Drawing.Point(275, 494);
            this.btn_removeAccess.Name = "btn_removeAccess";
            this.btn_removeAccess.Size = new System.Drawing.Size(131, 23);
            this.btn_removeAccess.TabIndex = 12;
            this.btn_removeAccess.Text = "Remove Access";
            this.btn_removeAccess.UseVisualStyleBackColor = true;
            // 
            // btn_addAccount
            // 
            this.btn_addAccount.Location = new System.Drawing.Point(275, 468);
            this.btn_addAccount.Name = "btn_addAccount";
            this.btn_addAccount.Size = new System.Drawing.Size(131, 23);
            this.btn_addAccount.TabIndex = 11;
            this.btn_addAccount.Text = "Open New Account";
            this.btn_addAccount.UseVisualStyleBackColor = true;
            this.btn_addAccount.Click += new System.EventHandler(this.Btn_addAccount_Click);
            // 
            // lbl_accID
            // 
            this.lbl_accID.AutoSize = true;
            this.lbl_accID.Location = new System.Drawing.Point(415, 98);
            this.lbl_accID.Name = "lbl_accID";
            this.lbl_accID.Size = new System.Drawing.Size(64, 13);
            this.lbl_accID.TabIndex = 13;
            this.lbl_accID.Text = "Account ID:";
            // 
            // tb_accID
            // 
            this.tb_accID.Location = new System.Drawing.Point(414, 115);
            this.tb_accID.Name = "tb_accID";
            this.tb_accID.ReadOnly = true;
            this.tb_accID.Size = new System.Drawing.Size(155, 20);
            this.tb_accID.TabIndex = 14;
            this.tb_accID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_accType
            // 
            this.tb_accType.Location = new System.Drawing.Point(414, 155);
            this.tb_accType.Name = "tb_accType";
            this.tb_accType.ReadOnly = true;
            this.tb_accType.Size = new System.Drawing.Size(155, 20);
            this.tb_accType.TabIndex = 16;
            this.tb_accType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_accType
            // 
            this.lbl_accType.AutoSize = true;
            this.lbl_accType.Location = new System.Drawing.Point(415, 138);
            this.lbl_accType.Name = "lbl_accType";
            this.lbl_accType.Size = new System.Drawing.Size(77, 13);
            this.lbl_accType.TabIndex = 15;
            this.lbl_accType.Text = "Account Type:";
            // 
            // tb_accOwner
            // 
            this.tb_accOwner.Location = new System.Drawing.Point(414, 195);
            this.tb_accOwner.Name = "tb_accOwner";
            this.tb_accOwner.ReadOnly = true;
            this.tb_accOwner.Size = new System.Drawing.Size(155, 20);
            this.tb_accOwner.TabIndex = 18;
            this.tb_accOwner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_accOwner
            // 
            this.lbl_accOwner.AutoSize = true;
            this.lbl_accOwner.Location = new System.Drawing.Point(415, 178);
            this.lbl_accOwner.Name = "lbl_accOwner";
            this.lbl_accOwner.Size = new System.Drawing.Size(84, 13);
            this.lbl_accOwner.TabIndex = 17;
            this.lbl_accOwner.Text = "Account Owner:";
            // 
            // chb_reinvest
            // 
            this.chb_reinvest.AutoCheck = false;
            this.chb_reinvest.AutoSize = true;
            this.chb_reinvest.Location = new System.Drawing.Point(418, 222);
            this.chb_reinvest.Name = "chb_reinvest";
            this.chb_reinvest.Size = new System.Drawing.Size(71, 17);
            this.chb_reinvest.TabIndex = 19;
            this.chb_reinvest.Text = "Reinvest:";
            this.chb_reinvest.UseVisualStyleBackColor = true;
            // 
            // lbl_accAcs
            // 
            this.lbl_accAcs.AutoSize = true;
            this.lbl_accAcs.Location = new System.Drawing.Point(415, 273);
            this.lbl_accAcs.Name = "lbl_accAcs";
            this.lbl_accAcs.Size = new System.Drawing.Size(88, 13);
            this.lbl_accAcs.TabIndex = 20;
            this.lbl_accAcs.Text = "Account Access:";
            // 
            // lstbx_accAcs
            // 
            this.lstbx_accAcs.FormattingEnabled = true;
            this.lstbx_accAcs.Location = new System.Drawing.Point(414, 289);
            this.lstbx_accAcs.Name = "lstbx_accAcs";
            this.lstbx_accAcs.Size = new System.Drawing.Size(155, 173);
            this.lstbx_accAcs.TabIndex = 21;
            // 
            // btn_calcReturn
            // 
            this.btn_calcReturn.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_calcReturn.Font = new System.Drawing.Font("AR BLANCA", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcReturn.ForeColor = System.Drawing.Color.Black;
            this.btn_calcReturn.Location = new System.Drawing.Point(413, 469);
            this.btn_calcReturn.Name = "btn_calcReturn";
            this.btn_calcReturn.Size = new System.Drawing.Size(156, 48);
            this.btn_calcReturn.TabIndex = 22;
            this.btn_calcReturn.Text = "Calculate ALL Returns";
            this.btn_calcReturn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 524);
            this.Controls.Add(this.btn_calcReturn);
            this.Controls.Add(this.lstbx_accAcs);
            this.Controls.Add(this.lbl_accAcs);
            this.Controls.Add(this.chb_reinvest);
            this.Controls.Add(this.tb_accOwner);
            this.Controls.Add(this.lbl_accOwner);
            this.Controls.Add(this.tb_accType);
            this.Controls.Add(this.lbl_accType);
            this.Controls.Add(this.tb_accID);
            this.Controls.Add(this.lbl_accID);
            this.Controls.Add(this.btn_removeAccess);
            this.Controls.Add(this.btn_addAccount);
            this.Controls.Add(this.btn_deleteCharacter);
            this.Controls.Add(this.btn_AddCharacter);
            this.Controls.Add(this.btn_newPlayer);
            this.Controls.Add(this.btn_removePlayer);
            this.Controls.Add(this.btn_manageAccount);
            this.Controls.Add(this.lbl_Investment);
            this.Controls.Add(this.tb_Investment);
            this.Controls.Add(this.lstBx_Accounts);
            this.Controls.Add(this.lstBx_Characters);
            this.Controls.Add(this.lstBx_Players);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Bank Of Abadar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ListBox lstBx_Players;
        private System.Windows.Forms.ListBox lstBx_Characters;
        private System.Windows.Forms.ListBox lstBx_Accounts;
        private System.Windows.Forms.TextBox tb_Investment;
        private System.Windows.Forms.Label lbl_Investment;
        private System.Windows.Forms.Button btn_manageAccount;
        private System.Windows.Forms.Button btn_removePlayer;
        private System.Windows.Forms.Button btn_newPlayer;
        private System.Windows.Forms.Button btn_AddCharacter;
        private System.Windows.Forms.Button btn_deleteCharacter;
        private System.Windows.Forms.Button btn_removeAccess;
        private System.Windows.Forms.Button btn_addAccount;
        private System.Windows.Forms.Label lbl_accID;
        private System.Windows.Forms.TextBox tb_accID;
        private System.Windows.Forms.TextBox tb_accType;
        private System.Windows.Forms.Label lbl_accType;
        private System.Windows.Forms.TextBox tb_accOwner;
        private System.Windows.Forms.Label lbl_accOwner;
        private System.Windows.Forms.CheckBox chb_reinvest;
        private System.Windows.Forms.Label lbl_accAcs;
        private System.Windows.Forms.ListBox lstbx_accAcs;
        private System.Windows.Forms.Button btn_calcReturn;
    }
}

