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
        NewPlayerArgs args;
        public NewPlayer()
        {
            args = new NewPlayerArgs();
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

        public event EventHandler<NewPlayerArgs> NewPlayerCreated;

        public virtual void OnNewPlayerCreated(NewPlayerArgs e)
        {
            EventHandler<NewPlayerArgs> handler = NewPlayerCreated;
            handler?.Invoke(this, e);
        }

    }
}
