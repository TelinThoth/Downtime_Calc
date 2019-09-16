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

namespace Downtime_Calculator.Classes
{
    public partial class NewPlayer : Form
    {
        NewPlayerCreatedArgs args;
        public NewPlayer()
        {
            args = new NewPlayerCreatedArgs();
            InitializeComponent();
        }

        private void Bnt_addPlayer_Click(object sender, EventArgs e)
        {
            if(tb_playerName.Text.Trim() != "")
            {
                args.playerName = tb_playerName.Text.Trim();
                OnNewPlayerCreated(args);
                this.Close();
            }
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public event EventHandler<NewPlayerCreatedArgs> NewPlayerCreated;

        public virtual void OnNewPlayerCreated(NewPlayerCreatedArgs e)
        {
            EventHandler<NewPlayerCreatedArgs> handler = NewPlayerCreated;
            handler?.Invoke(this, e);
        }
    }
}
