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

        private void txtbxName_TextChanged(object sender, EventArgs e)
        {

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
            return;
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
