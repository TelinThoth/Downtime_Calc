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
    public partial class ModifyNewAccountAccess : Form
    {
        private ModifyAccountAccessArgs args;
        private List<Character> allCharas = new List<Character>();

        public ModifyNewAccountAccess(Character[] i_Charas, int ownerID)
        {
            InitializeComponent();

            foreach (Character chara in i_Charas)
            {
                if (chara.ID != ownerID)
                {
                    clbx_allCharacters.Items.Add(chara.name);
                    allCharas.Add(chara);
                }
            }
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modifyAccess_Click(object sender, EventArgs e)
        {
            args = new ModifyAccountAccessArgs();
            List<int> allSelectedIDs = new List<int>();
            for(int i = 0; i < clbx_allCharacters.Items.Count; i++)
                if(clbx_allCharacters.GetItemCheckState(i) == CheckState.Checked)
                {
                    allSelectedIDs.Add(allCharas[i].ID);
                }
            args.charIDs = allSelectedIDs.ToArray();

            OnAccountAccessModified(args);
            this.Close();
        }

        public event EventHandler<ModifyAccountAccessArgs> AccountAccessModified;

        public virtual void OnAccountAccessModified(ModifyAccountAccessArgs e)
        {
            EventHandler<ModifyAccountAccessArgs> handler = AccountAccessModified;
            handler?.Invoke(this, e);
        }
    }
}
