/*
 * Thomas Sulentic
 * Version 1.0 .CPN Creater
 * 5/30/2017
 */

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

namespace Downtime_Calculator
{
    public partial class NewFile : Form
    {
        private string cpgn = null;                                                 //Full Path to File
        private string campaignName = null;                                         //Primary name of Game
        private string campaignPath = null;                                         //Partial Path to file (No .cpgn)

        private Form1 lastForm;
        public NewFile(ref Form1 oldForm)
        {
            InitializeComponent();
            lastForm = oldForm;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //Aaron Test Code
            //Campaign cpgn = new Campaign();
            //cpgn.SaveToLocation(@"C:\Users\Sneaky\Desktop\XMLTest\Default Name.xml");
            //Campaign cpgn2 = Campaign.LoadFromLocation(@"C:\Users\Sneaky\Desktop\XMLTest\Default Name - Copy.xml");
            //cpgn2.SaveToLocation(@"C:\Users\Sneaky\Desktop\XMLTest\Load Test Path.xml");
            //End Aaron Test
            CreateCampaign();
            CreateBasicCampaignData();
            CreateBasicConfigFile();

            Close();
        }

        private void CreateCampaign()
        {
            if (txtbxName.Text != null)                                             //Check if there is acutal text in the box.
            {
                campaignName = txtbxName.Text;
                campaignPath = ".\\saves\\";                                        //If there is, begin path string

                if (!Directory.Exists(campaignPath))                                //If the Directory doesn't exist
                    Directory.CreateDirectory(campaignPath);                        //create it.

                string buffer = txtbxName.Text;                                     //Text buffer for savefile formatting
                buffer = buffer.ToLower();                                          //make it all lowercase for default saves
                campaignPath += buffer;                                             //Append Path to save file

                cpgn = campaignPath + ".cpgn";                                       //.cpgn (campaign) file type--is .zip
                if (!File.Exists(cpgn))                                             //create file if it doesn't exist. Error out if it does.
                {
                    ZipArchive zip = ZipFile.Open(cpgn, ZipArchiveMode.Create);     //Creates the CPGN

                    zip.CreateEntry("Config.xml");                                  //Creates blank Config File
                    zip.CreateEntry("CampaignData.xml");                            //Creates blank Campaign Data File

                    zip.Dispose();                                                  //closes Zip
                    lastForm.SetFile(cpgn);
                }

                else
                    MessageBox.Show("That file already exists! Either delete the old one, or select a new name!", "ERROR: File Exsists", MessageBoxButtons.OKCancel);
            }
            else
                MessageBox.Show("File name can not be Blank! Please enter a name.", "ERROR: Not a Valid Name", MessageBoxButtons.OKCancel);
        }

        private void CreateBasicCampaignData()
        {
            ZipArchive zip = ZipFile.Open(cpgn, ZipArchiveMode.Update);
            ZipArchiveEntry campaign = zip.GetEntry("CampaignData.xml");
            StreamWriter ghostWriter = new StreamWriter(campaign.Open());
   
            ghostWriter.WriteLine("<Campaign>");
            ghostWriter.WriteLine("\t<ID>1</ID>");
            ghostWriter.WriteLine("\t<Name>" + campaignName + "</Name>");
            ghostWriter.WriteLine("\t<Players>\n</Players>");
            ghostWriter.WriteLine("\t<Characters>\n</Characters>");
            ghostWriter.WriteLine("\t<Accounts>\n</Accounts>");
            ghostWriter.WriteLine("</Campaign>");
   
            ghostWriter.Close();
            zip.Dispose();
            ghostWriter.Dispose();
        }

        private void CreateBasicConfigFile()
        {
            ZipArchive zip = ZipFile.Open(cpgn, ZipArchiveMode.Update);
            ZipArchiveEntry campaign = zip.GetEntry("Config.xml");
            StreamWriter ghostWriter = new StreamWriter(campaign.Open());

            ghostWriter.WriteLine("<Config>");
            ghostWriter.WriteLine("\t<Flags>\n");
            ghostWriter.WriteLine("\t\t<AutoReinv>False</AutoReinv>");
            ghostWriter.WriteLine("\t\t<YearlyRet>True</YearlyRet>");
            ghostWriter.WriteLine("\t\t<AllowStrikes>False</AllowStrikes>");
            ghostWriter.WriteLine("\t</Flags>");
            ghostWriter.WriteLine("\t<Accounts>");
            ghostWriter.WriteLine("\t\t<Account id=\"00\">Creative Arts,4,31,95,2d4,1</Account>");
            ghostWriter.WriteLine("\t\t<Account id=\"01\">Performing Arts,2,36,95,2d6,1</Account>");
            ghostWriter.WriteLine("\t\t<Account id=\"02\">Banking,2,11,98,1d4,0</Account>");
            ghostWriter.WriteLine("\t\t<Account id=\"03\">Common Crafting,1,06,95,1d3,1</Account>");
            ghostWriter.WriteLine("\t\t<Account id=\"04\">Magical Crafting,5,31,95,1d8,1</Account>");
            ghostWriter.WriteLine("\t\t<Account id=\"05\">Millitary Crafting,5,16,90,1d6,1</Account>");
            ghostWriter.WriteLine("\t\t<Account id=\"06\">Exploration,2,41,85,2d8,1</Account>");
            ghostWriter.WriteLine("\t\t<Account id=\"07\">Mill/Granary,3,11,98,1d3,1</Account>");
            ghostWriter.WriteLine("\t\t<Account id=\"08\">Assassins Guild,5,31,95,2d4,1</Account>");
            ghostWriter.WriteLine("\t\t<Account id=\"09\">Crafting Guilds,2,06,98,1d3,1</Account>");
            ghostWriter.WriteLine("\t\t<Account id=\"10\">Merchant's Guild,3,11,98,1d4,1</Account>");
            ghostWriter.WriteLine("\t\t<Account id=\"11\">Thieve's Guild,4,16,90,1d8,1</Account>");
            ghostWriter.WriteLine("\t\t<Account id=\"12\">Exotic Imports,5,31,90,1d10,1</Account>");
            ghostWriter.WriteLine("\t\t<Account id=\"13\">Ordinary Imports,2,16,95,1d4,1</Account>");
            ghostWriter.WriteLine("\t\t<Account id=\"14\">Invention Supplies,3,41,90,2d6,1</Account>");
            ghostWriter.WriteLine("\t\t<Account id=\"15\">Protection Supplies,3,31,95,1d8,1</Account>");
            ghostWriter.WriteLine("\t\t<Account id=\"16\">Quarry Imports,3,21,90,1d6,1</Account>");
            ghostWriter.WriteLine("\t\t<Account id=\"17\">Magical Research,5,51,75,2d6,1</Account>");
            ghostWriter.WriteLine("\t\t<Account id=\"18\">Mundane Research,3,21,85,1d8,1</Account>");
            ghostWriter.WriteLine("\t\t<Account id=\"19\">Stable,1,06,98,1d3,1</Account>");
            ghostWriter.WriteLine("\t\t<Account id=\"20\">Tavern,1,06,98,1d4,1</Account>");
            ghostWriter.WriteLine("\t\t<Account id=\"21\">Resurection Funds,,,,,</Account>");
            ghostWriter.WriteLine("\t</Accounts>");
            ghostWriter.WriteLine("\t<MiscSettings>");
            ghostWriter.WriteLine("\t\t<StrikeCount>3</StrikeCount>");
            ghostWriter.WriteLine("\t</MiscSettings>");
            ghostWriter.WriteLine("</Config>");

            ghostWriter.Close();
            zip.Dispose();
            ghostWriter.Dispose();
        }

        public string GetFileName()
        {
            return cpgn;
        }
    }
}

/*
 * Version 1.0 5/30/2017
 * +Added create file function
 * +Added Check for existing file.
 * +Added .\saves\ directory
 * +Added the ability to Create the directory if it doesn't exist.
 *****************************************************************
 * Version 1.0.1 12/14/17
 * +Changed extention to .CPGN
 * +Added quick, and dirty XML writing for the campaignData.xml
 *****************************************************************
 * 01/07/18
 * +Added Error catch for Blank field.
 */ 
