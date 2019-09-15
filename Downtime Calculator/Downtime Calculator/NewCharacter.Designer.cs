namespace Downtime_Calculator
{
    partial class NewCharacter
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
            this.lbl_attachToPlayer = new System.Windows.Forms.Label();
            this.cb_playersSelection = new System.Windows.Forms.ComboBox();
            this.tb_characterName = new System.Windows.Forms.TextBox();
            this.lbl_CharacterName = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_createCharacter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_attachToPlayer
            // 
            this.lbl_attachToPlayer.AutoSize = true;
            this.lbl_attachToPlayer.Location = new System.Drawing.Point(13, 13);
            this.lbl_attachToPlayer.Name = "lbl_attachToPlayer";
            this.lbl_attachToPlayer.Size = new System.Drawing.Size(85, 13);
            this.lbl_attachToPlayer.TabIndex = 0;
            this.lbl_attachToPlayer.Text = "Attach to Player:";
            // 
            // cb_playersSelection
            // 
            this.cb_playersSelection.FormattingEnabled = true;
            this.cb_playersSelection.Location = new System.Drawing.Point(104, 10);
            this.cb_playersSelection.Name = "cb_playersSelection";
            this.cb_playersSelection.Size = new System.Drawing.Size(275, 21);
            this.cb_playersSelection.TabIndex = 1;
            // 
            // tb_characterName
            // 
            this.tb_characterName.Location = new System.Drawing.Point(16, 79);
            this.tb_characterName.Name = "tb_characterName";
            this.tb_characterName.Size = new System.Drawing.Size(363, 20);
            this.tb_characterName.TabIndex = 2;
            // 
            // lbl_CharacterName
            // 
            this.lbl_CharacterName.AutoSize = true;
            this.lbl_CharacterName.Location = new System.Drawing.Point(16, 60);
            this.lbl_CharacterName.Name = "lbl_CharacterName";
            this.lbl_CharacterName.Size = new System.Drawing.Size(84, 13);
            this.lbl_CharacterName.TabIndex = 3;
            this.lbl_CharacterName.Text = "Character Name";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(16, 117);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(140, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // btn_createCharacter
            // 
            this.btn_createCharacter.Location = new System.Drawing.Point(239, 117);
            this.btn_createCharacter.Name = "btn_createCharacter";
            this.btn_createCharacter.Size = new System.Drawing.Size(140, 23);
            this.btn_createCharacter.TabIndex = 5;
            this.btn_createCharacter.Text = "Create Character";
            this.btn_createCharacter.UseVisualStyleBackColor = true;
            this.btn_createCharacter.Click += new System.EventHandler(this.Btn_createCharacter_Click);
            // 
            // NewCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 152);
            this.Controls.Add(this.btn_createCharacter);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_CharacterName);
            this.Controls.Add(this.tb_characterName);
            this.Controls.Add(this.cb_playersSelection);
            this.Controls.Add(this.lbl_attachToPlayer);
            this.Name = "NewCharacter";
            this.Text = "Create New Character";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_attachToPlayer;
        private System.Windows.Forms.ComboBox cb_playersSelection;
        private System.Windows.Forms.TextBox tb_characterName;
        private System.Windows.Forms.Label lbl_CharacterName;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_createCharacter;
    }
}