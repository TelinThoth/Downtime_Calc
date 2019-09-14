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
        #endregion

        #region Selection Functions
        private void LstBx_Players_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBx_Characters.Items.Clear();
            lstBx_Accounts.Items.Clear();
            tb_Investment.Text = "";

            disDaemon.displayCharacters = currentGame.GetPlayerCharacters(disDaemon.PullPlayerID(lstBx_Players.SelectedIndex)).ToArray();
            lstBx_Characters.Items.AddRange(disDaemon.GetDisplayCharName().ToArray());
        }

        private void LstBx_Characters_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBx_Accounts.Items.Clear();
            tb_Investment.Text = "";

            disDaemon.displayAcounts = currentGame.GetCharacterAccounts(disDaemon.PullCharaID(lstBx_Characters.SelectedIndex)).ToArray();
            lstBx_Accounts.Items.AddRange(disDaemon.GetDisplayAccName().ToArray());
        }

        private void LstBx_Accounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_Investment.Text = "";

            int acctID = disDaemon.displayAcounts[lstBx_Characters.SelectedIndex].ID;
            tb_Investment.Text = currentGame.accounts.Find(x => x.ID == acctID).investment.ToString();
        }
        #endregion
        /*
         * SetFile sets the path for the current open .CPGN file
        */

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
        }

        private void PopulatePlayersField()
        {
            lstBx_Players.Items.Clear();
            disDaemon.displayPlayers = currentGame.players.ToArray();
            lstBx_Players.Items.AddRange(disDaemon.GetDisplayPlayName().ToArray());
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

        public void NewPlayerCreated(object sender, NewPlayerArgs e)
        {
            if(e.playerName != null)
            {
                int playerID = currentGame.GetLowestEmptyPlayerID();
                currentGame.players.Add(new Player(playerID, e.playerName));
                PopulatePlayersField();
            }
        }

        #endregion
    }
}
