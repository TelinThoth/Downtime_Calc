using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using Downtime_Calculator.Classes;
using Downtime_Calculator.Interfaces;
using Downtime_Calculator.Events;
using System.Xml;

namespace Downtime_Calculator
{
    public partial class Form1 : Form
    {
        private string fileName;
        private DisplayData disDaemon;
        private Campaign currentGame;

        private Boolean needToSave;

        //Temp Data Holder:
        string[] accType_temp = new string[22];

        public Form1()
        {
            InitializeComponent();
            needToSave = false;
            disDaemon = new DisplayData();
            ChangeFileLoadState(false);

            accType_temp[0] = "Creative Arts";
            accType_temp[1] = "Performing Arts";
            accType_temp[2] = "Banking";
            accType_temp[3] = "Common Crafting";
            accType_temp[4] = "Magical Crafting";
            accType_temp[5] = "Millitary Crafting";
            accType_temp[6] = "Exploration";
            accType_temp[7] = "Mill/Granary";
            accType_temp[8] = "Assassins Guild";
            accType_temp[9] = "Crafting Guilds";
            accType_temp[10] = "Merchant's Guild";
            accType_temp[11] = "Thieves Guild";
            accType_temp[12] = "Exotic Imports";
            accType_temp[13] = "Ordinary Imports";
            accType_temp[14] = "Invention Supplies";
            accType_temp[15] = "Protection Supplies";
            accType_temp[16] = "Quarry Imports";
            accType_temp[17] = "Magical Research";
            accType_temp[18] = "Mundane Research";
            accType_temp[19] = "Stable";
            accType_temp[20] = "Tavern";
            accType_temp[21] = "Resurection Funds";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        #region Button Functions
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            CheckIfNeedToSave();
            CreateNewCampaign();
        }
        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            CheckIfNeedToSave();
            OpenCampaign();
        }
        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            if (fileName != null)
            {
                currentGame.SaveToLocation(fileName);
                needToSave = false;
            }
        }
        private void Btn_newPlayer_Click(object sender, EventArgs e)
        {
            NewPlayer form = new NewPlayer();
            form.NewPlayerCreated += NewPlayerCreated;
            form.Show();
        }

        private void Btn_AddCharacter_Click(object sender, EventArgs e)
        {
            NewCharacter form = new NewCharacter(disDaemon.displayPlayers, lstBx_Players.SelectedIndex);
            form.NewCharacterCreated += NewCharacterCreated;
            form.Show();
        }

        private void Btn_addAccount_Click(object sender, EventArgs e)
        {
            NewAccount form = new NewAccount(currentGame.characters, disDaemon.PullCharaID(lstBx_Characters.SelectedIndex), currentGame.accounts, accType_temp);
            form.NewAccountCreated += NewAccountCreated;
            form.Show();
        }

        private void Btn_AddFunds_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Selection Functions
        private void LstBx_Players_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlayerSelected();
        }

        private void LstBx_Characters_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterSelected();
        }

        private void LstBx_Accounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccountSelected();
        }
        #endregion

        private void PlayerSelected()
        {
            lstBx_Characters.Items.Clear();
            lstBx_Accounts.Items.Clear();
            tb_Investment.Text = "";

            if (lstBx_Players.SelectedIndex >= 0)
            {
                disDaemon.displayCharacters = currentGame.GetPlayerCharacters(disDaemon.PullPlayerID(lstBx_Players.SelectedIndex)).ToArray();
                lstBx_Characters.Items.AddRange(disDaemon.GetDisplayCharName().ToArray());

                ChangePlayerSelectedState(true);
            }
            else
            {
                ChangePlayerSelectedState(false);
            }
        }

        private void CharacterSelected()
        {
            lstBx_Accounts.Items.Clear();
            tb_Investment.Text = "";

            if (lstBx_Characters.SelectedIndex >= 0)
            {
                disDaemon.displayAcounts = currentGame.GetCharacterAccounts(disDaemon.PullCharaID(lstBx_Characters.SelectedIndex)).ToArray();
                lstBx_Accounts.Items.AddRange(disDaemon.GetDisplayAccName().ToArray());

                ChangeCharacterSelectedState(true);
            }
            else
            {
                ChangeCharacterSelectedState(false);
            }
        }

        private void AccountSelected()
        {
            tb_Investment.Text = "";

            int acctID = disDaemon.displayAcounts[lstBx_Accounts.SelectedIndex].ID;
            tb_Investment.Text = currentGame.accounts.Find(x => x.ID == acctID).investment.ToString();
        }

        public void ReadFile(string path)
        {
            //This can be rewritten somehow...[ZipArchive.Open.Read] Maybe?
            string tempFile = ".\\tempCPGNdt.xml";
            ZipArchive cpgnFile = ZipFile.OpenRead(path);
            
            ZipArchiveEntry cpgnData = cpgnFile.GetEntry("CampaignData.xml");
            
            StreamReader ghostReader = new StreamReader(cpgnData.Open());
            File.WriteAllText(tempFile, ghostReader.ReadToEnd());
            currentGame = Campaign.LoadFromLocation(tempFile);


            //Cleanup
            if(File.Exists(tempFile))
            {
                File.Delete(tempFile);
            }
            ghostReader.Close();
            ghostReader.Dispose();
            cpgnFile.Dispose();
            string curName = currentGame.name;
            this.Text = "Bank Of Abadar - " + currentGame.name;
            PopulatePlayersField();
            ChangeFileLoadState(true);
        }

        private void PopulatePlayersField()
        {
            lstBx_Players.Items.Clear();
            disDaemon.displayPlayers = currentGame.players.ToArray();
            lstBx_Players.Items.AddRange(disDaemon.GetDisplayPlayName().ToArray());
        }

        private void CreateNewCampaign()
        {
            NewFile form = new NewFile();
            form.NewCampaignCreated += NewCampaignCreated;
            form.Show();
        }

        private void OpenCampaign()
        { 
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.ShowDialog();
            fileName = fileDialog.FileName;
            if (fileName != "")
            {
                ReadFile(fileName);
            }
        }

        private void CheckIfNeedToSave()
        {
            if (needToSave)
            {
                DialogResult answer = MessageBox.Show("You have not saved your current campaign. \r\nWould you like to?", "Save File?", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    currentGame.SaveToLocation(fileName);
                }
            }
        }

        #region Button Changers
        private void ChangeFileLoadState(Boolean isFileLoaded)
        {
            if(isFileLoaded)
            {
                btn_newPlayer.Enabled = true;
                btn_removePlayer.Enabled = false;
                btn_AddFunds.Enabled = false;
                btn_addAccount.Enabled = false;
                btn_AddCharacter.Enabled = false;
                btn_deleteCharacter.Enabled = false;
                btn_removeAccess.Enabled = false;
                btn_removePlayer.Enabled = false;
            }
            else
            {
                btn_newPlayer.Enabled = false;
                btn_removePlayer.Enabled = false;
                btn_AddFunds.Enabled = false;
                btn_addAccount.Enabled = false;
                btn_AddCharacter.Enabled = false;
                btn_deleteCharacter.Enabled = false;
                btn_removeAccess.Enabled = false;
                btn_removePlayer.Enabled = false;
            }
        }

        private void ChangePlayerSelectedState(Boolean isPlayerSelected)
        {
            if(isPlayerSelected)
            {
                btn_removePlayer.Enabled = true;
                btn_AddCharacter.Enabled = true;

                ChangeCharacterSelectedState(false);
            }
            else
            {
                btn_removePlayer.Enabled = false;
                btn_deleteCharacter.Enabled = false;

                ChangeCharacterSelectedState(false);
            }
        }

        private void ChangeCharacterSelectedState(Boolean isCharacterSelected)
        {
            if(isCharacterSelected)
            {
                btn_deleteCharacter.Enabled = true;
                btn_addAccount.Enabled = true;

                ChangeAccountSelectedState(false);
            }
            else
            {
                btn_deleteCharacter.Enabled = false;
                btn_addAccount.Enabled = false;

                ChangeAccountSelectedState(false);
            }
        }

        private void ChangeAccountSelectedState(Boolean isAccountSelected)
        {
            if(isAccountSelected)
            {
                btn_removeAccess.Enabled = true;
                btn_AddFunds.Enabled = true;
            }
            else
            {
                btn_removeAccess.Enabled = false;
                btn_AddFunds.Enabled = false;
            }
        }
        #endregion

        #region EventListeners
        public void NewCampaignCreated(object sender, NewCampaignCreatedEventArgs e)
        {
            if (e.fileName != null)
            {
                fileName = e.fileName;
                ReadFile(fileName);
                needToSave = false;
            }
        }

        public void NewPlayerCreated(object sender, NewPlayerCreatedArgs e)
        {
            if(e.playerName != null)
            {
                int playerID = currentGame.GetLowestEmptyPlayerID();
                currentGame.players.Add(new Player(playerID, e.playerName));

                currentGame.players.Sort();

                PopulatePlayersField();
                needToSave = true;
            }
        }

        public void NewCharacterCreated(object sender, NewCharacterCreatedArgs e)
        {
            int characterID = currentGame.GetLowestEmptyCharacterID();
            Character tempCharacter = new Character(characterID, e.characterName);
            currentGame.players.Find(x => x.ID == e.attachedPlayerID).AddCharacter(tempCharacter);
            currentGame.characters.Add(tempCharacter);

            currentGame.characters.Sort();

            PlayerSelected();
            needToSave = true;
        }

        public void NewAccountCreated(object sender, NewAccountCreatedArgs e)
        {
            int acctID = currentGame.GetLowestEmptyAccountID();
            int returnID;
            if (e.returnAcc == -1)
                returnID = acctID;
            else if (e.returnAcc == -2)
                returnID = -1;
            else
                returnID = e.returnAcc;

            Account tempAccount = new Account(acctID, e.type, e.investment, e.nick, e.owner, returnID);
            currentGame.accounts.Add(tempAccount);
            currentGame.characters.Find(x => x.ID == e.owner).AddAccountAccess(tempAccount);

            currentGame.accounts.Sort();
            CharacterSelected();
            needToSave = true;
        }

        #endregion
    }
}
