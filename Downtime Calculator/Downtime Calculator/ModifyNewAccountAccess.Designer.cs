namespace Downtime_Calculator
{
    partial class ModifyNewAccountAccess
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
            this.clbx_allCharacters = new System.Windows.Forms.CheckedListBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_modifyAccess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbx_allCharacters
            // 
            this.clbx_allCharacters.FormattingEnabled = true;
            this.clbx_allCharacters.Location = new System.Drawing.Point(13, 13);
            this.clbx_allCharacters.Name = "clbx_allCharacters";
            this.clbx_allCharacters.Size = new System.Drawing.Size(217, 334);
            this.clbx_allCharacters.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(13, 354);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(107, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // btn_modifyAccess
            // 
            this.btn_modifyAccess.Location = new System.Drawing.Point(126, 354);
            this.btn_modifyAccess.Name = "btn_modifyAccess";
            this.btn_modifyAccess.Size = new System.Drawing.Size(104, 23);
            this.btn_modifyAccess.TabIndex = 2;
            this.btn_modifyAccess.Text = "Modify Access";
            this.btn_modifyAccess.UseVisualStyleBackColor = true;
            this.btn_modifyAccess.Click += new System.EventHandler(this.btn_modifyAccess_Click);
            // 
            // ModifyAccountAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 383);
            this.Controls.Add(this.btn_modifyAccess);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.clbx_allCharacters);
            this.Name = "ModifyAccountAccess";
            this.Text = "Add/Remove Account Access";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbx_allCharacters;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_modifyAccess;
    }
}