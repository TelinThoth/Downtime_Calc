namespace Downtime_Calculator.Classes
{
    partial class NewPlayer
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
            this.tb_playerName = new System.Windows.Forms.TextBox();
            this.lbl_playerName = new System.Windows.Forms.Label();
            this.bnt_addPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_playerName
            // 
            this.tb_playerName.Location = new System.Drawing.Point(12, 28);
            this.tb_playerName.Name = "tb_playerName";
            this.tb_playerName.Size = new System.Drawing.Size(282, 20);
            this.tb_playerName.TabIndex = 0;
            // 
            // lbl_playerName
            // 
            this.lbl_playerName.AutoSize = true;
            this.lbl_playerName.Location = new System.Drawing.Point(9, 9);
            this.lbl_playerName.Name = "lbl_playerName";
            this.lbl_playerName.Size = new System.Drawing.Size(67, 13);
            this.lbl_playerName.TabIndex = 1;
            this.lbl_playerName.Text = "Player Name";
            // 
            // bnt_addPlayer
            // 
            this.bnt_addPlayer.Location = new System.Drawing.Point(12, 55);
            this.bnt_addPlayer.Name = "bnt_addPlayer";
            this.bnt_addPlayer.Size = new System.Drawing.Size(108, 23);
            this.bnt_addPlayer.TabIndex = 2;
            this.bnt_addPlayer.Text = "Add This Player";
            this.bnt_addPlayer.UseVisualStyleBackColor = true;
            this.bnt_addPlayer.Click += new System.EventHandler(this.Bnt_addPlayer_Click);
            // 
            // NewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 86);
            this.Controls.Add(this.bnt_addPlayer);
            this.Controls.Add(this.lbl_playerName);
            this.Controls.Add(this.tb_playerName);
            this.Name = "NewPlayer";
            this.Text = "Add New Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_playerName;
        private System.Windows.Forms.Label lbl_playerName;
        private System.Windows.Forms.Button bnt_addPlayer;
    }
}