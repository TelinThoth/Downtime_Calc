using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Downtime_Calculator.Classes;
using Downtime_Calculator.Events;

namespace Downtime_Calculator
{
    public partial class NewAccount : Form
    {
        NewAccountCreatedArgs args;

        Character[] allCharas;
        int ownerID;
        int[] accessGranted;

        Boolean reinvest;
        public NewAccount(List<Character> allCharacters, int selectedID, List<Account> allAccounts, string[] i_accountTypes)
        {
            args = new NewAccountCreatedArgs();
            reinvest = false;
            InitializeComponent();
            allCharas = allCharacters.ToArray();
            foreach (Character chara in allCharacters)
                cb_accountOwner.Items.Add(chara.name);
            cb_accountOwner.SelectedIndex = selectedID;
            ownerID = allCharas[selectedID].ID;

            cb_reinvestAccount.Items.Add("This Account");
            foreach (Account acc in allAccounts)
                cb_reinvestAccount.Items.Add(acc.GetAccountName());

            cb_accountType.Items.AddRange(i_accountTypes);
        }

        private void Cb_autoReinvest_CheckedChanged(object sender, EventArgs e)
        {
            reinvest = !reinvest;
            if(reinvest)
            {
                lbl_reinvestAccount.Visible = true;
                lbl_reinvestAccount.Enabled = true;
                cb_reinvestAccount.Visible = true;
                cb_reinvestAccount.Enabled = true;
            }
            else
            {
                lbl_reinvestAccount.Visible = false;
                lbl_reinvestAccount.Enabled = false;
                cb_reinvestAccount.Visible = false;
                cb_reinvestAccount.Enabled = false;
            }
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_createAccount_Click(object sender, EventArgs e)
        {
            if (Double.Parse(tb_investment.Text) >= 0)
                args.investment = Double.Parse(tb_investment.Text);
            else
            {
                MessageBox.Show("Investment can not be Blank, or a Negative Value", "ERROR: Invesment Invalid Amount", MessageBoxButtons.OK);
                return;
            }

            if (cb_accountType.SelectedIndex >= 0)
                args.type = cb_accountType.SelectedIndex;
            else
            {
                MessageBox.Show("Account Type can not be blank.", "ERROR: Invalid Account Type", MessageBoxButtons.OK);
                return;
            }

            args.nick = tb_nickname.Text;
            if(cb_accountOwner.SelectedIndex >= 0)
            {
                args.owner = allCharas[cb_accountOwner.SelectedIndex].ID;
            }
            else
            {
                MessageBox.Show("Owner can not be blank, or a non-existant character.", "ERROR: Invalid Owner", MessageBoxButtons.OK);
                return;
            }


            if (cb_autoReinvest.Checked)
                args.returnAcc = cb_reinvestAccount.SelectedIndex - 1;
            else
                args.returnAcc = -2;

            args.accessGranted = accessGranted;

            OnNewAccountCreated(args);
            this.Close();
        }

        private void Btn_modifyAccess_Click(object sender, EventArgs e)
        {
            ModifyNewAccountAccess form = new ModifyNewAccountAccess(allCharas, ownerID);
            form.AccountAccessModified += AccountAccessModified;

            form.Show();
        }

        public event EventHandler<NewAccountCreatedArgs> NewAccountCreated;

        public virtual void OnNewAccountCreated(NewAccountCreatedArgs e)
        {
            EventHandler<NewAccountCreatedArgs> handler = NewAccountCreated;
            handler?.Invoke(this, e);
        }

        public void AccountAccessModified(object sender, ModifyAccountAccessArgs e)
        {
            accessGranted = e.charIDs;
        }

        private void Cb_accountOwner_SelectedIndexChanged(object sender, EventArgs e)
        {
            ownerID = allCharas[cb_accountOwner.SelectedIndex].ID;
        }
    }
}
