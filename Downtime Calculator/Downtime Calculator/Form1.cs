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

        public Form1()
        {
            InitializeComponent();
            disDaemon = new DisplayData();
            ChangeFileLoadState(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        #region Button Functions
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            NewFile form = new NewFile();
            form.NewCampaignCreated += NewCampaignCreated;
            form.Show();
        }
        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            fileName = fileDialog.FileName;
            if (fileName != "")
            {
                ReadFile(fileName);
            }
        }
        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            if (fileName != null)
            {
                currentGame.SaveToLocation(fileName);
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

            disDaemon.displayCharacters = currentGame.GetPlayerCharacters(disDaemon.PullPlayerID(lstBx_Players.SelectedIndex)).ToArray();
            lstBx_Characters.Items.AddRange(disDaemon.GetDisplayCharName().ToArray());

            ChangePlayerSelectedState(true);
        }

        private void CharacterSelected()
        {
            lstBx_Accounts.Items.Clear();
            tb_Investment.Text = "";

            disDaemon.displayAcounts = currentGame.GetCharacterAccounts(disDaemon.PullCharaID(lstBx_Characters.SelectedIndex)).ToArray();
            lstBx_Accounts.Items.AddRange(disDaemon.GetDisplayAccName().ToArray());
        }

        private void AccountSelected()
        {
            tb_Investment.Text = "";

            int acctID = disDaemon.displayAcounts[lstBx_Characters.SelectedIndex].ID;
            tb_Investment.Text = currentGame.accounts.Find(x => x.ID == acctID).investment.ToString();
        }

        public void ReadFile(string path)
        {
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
            }
            else
            {
                btn_removePlayer.Enabled = false;
                btn_deleteCharacter.Enabled = false;
            }
        }

        #region EventListeners
        public void NewCampaignCreated(object sender, NewCampaignCreatedEventArgs e)
        {
            if (e.fileName != null)
            {
                fileName = e.fileName;
                ReadFile(fileName);
            }
        }

        public void NewPlayerCreated(object sender, NewPlayerCreatedArgs e)
        {
            if(e.playerName != null)
            {
                int playerID = currentGame.GetLowestEmptyPlayerID();
                currentGame.players.Add(new Player(playerID, e.playerName));
                //SortList Here
                PopulatePlayersField();
            }
        }

        public void NewCharacterCreated(object sender, NewCharacterCreatedArgs e)
        {
            int characterID = currentGame.GetLowestEmptyCharacterID();
            Character tempCharacter = new Character(characterID, e.characterName);
            currentGame.players.Find(x => x.ID == e.attachedPlayerID).AddCharacter(tempCharacter);
            currentGame.characters.Add(tempCharacter);
            PlayerSelected();
        }

        #endregion
    }
}
