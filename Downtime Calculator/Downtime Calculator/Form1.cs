﻿using System;
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
    public partial class Form1 : Form
    {
        private string fileName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            Form1 oldForm = this;
            NewFile form = new NewFile(ref oldForm);
            form.Show();
        }
        

        /*
         * SetFile sets the path for the current open .CPGN file
        */
        public bool SetFile(string path)
        {
            if (path == null)
            {
                return false;
            }
            else
            {
                fileName = path;
                return true;
            }
        }
    }
}