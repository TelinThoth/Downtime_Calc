using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Downtime_Calculator.Events;
using Downtime_Calculator.Classes;

namespace Downtime_Calculator
{
    public partial class NewCharacter : Form
    {
        public NewCharacterCreatedArgs args;
        private Player[] playerSelections;

        public NewCharacter(Player[] i_players, int playerIndex)
        {
            args = new NewCharacterCreatedArgs();
            playerSelections = i_players;

            InitializeComponent();

            foreach (Player p_value in i_players)
                cb_playersSelection.Items.Add(p_value.name);
            cb_playersSelection.SelectedIndex = playerIndex;
        }

        private void Btn_createCharacter_Click(object sender, EventArgs e)
        {
            if (tb_characterName.Text.Trim() != "")
            {
                args.attachedPlayerID = playerSelections[cb_playersSelection.SelectedIndex].ID;
                args.characterName = tb_characterName.Text;
                OnNewPlayerCreated(args);
                this.Close();
            }
            else
                MessageBox.Show("Character Name Cannot be Blank.", "ERROR IN CHARACTER CREATION.", MessageBoxButtons.OK);
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public event EventHandler<NewCharacterCreatedArgs> NewCharacterCreated;

        public virtual void OnNewPlayerCreated(NewCharacterCreatedArgs e)
        {
            EventHandler<NewCharacterCreatedArgs> handler = NewCharacterCreated;
            handler?.Invoke(this, e);
        }
    }
}
