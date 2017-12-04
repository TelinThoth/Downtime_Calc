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

namespace Downtime_Calculator
{
    public partial class NewFile : Form
    {
        public NewFile()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtbxName.Text != null)                                             //Check if there is acutal text in the box.
            {
                string name = ".\\saves\\";                                          //If there is, begin path string
                
                if (!Directory.Exists(name))                                        //If the Directory doesn't exist
                    Directory.CreateDirectory(name);                                //create it.

                string buffer = txtbxName.Text;                                     //Text buffer for savefile formatting
                buffer = buffer.ToLower();                                          //make it all lowercase for default saves
                name += buffer;                                                     //Append Path to save file
                
                name += ".cpn";                                                     //.cpn (campaign) file type--is .zip
                if (!File.Exists(name))                                             //create file if it doesn't exist. Error out if it does.
                {
                    using (ZipArchive zip = ZipFile.Open(name, ZipArchiveMode.Create));
                    Close();
                }

                else
                    MessageBox.Show("That file already exists! Either delete the old one, or select a new name!", "ERROR: File Exsists", MessageBoxButtons.OKCancel);
            }
        }

        private void txtbxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

/*
 * Version 1.0 5/30/2017
 * +Added create file function
 * +Added Check for existing file.
 * +Added .\saves\ directory
 * +Added the ability to Create the directory if it doesn't exist.
 *
 */ 
