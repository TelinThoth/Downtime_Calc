﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Downtime_Calculator.Interfaces;
using System.Xml.Linq;
using System.IO;
using System.IO.Compression;

namespace Downtime_Calculator.Classes
{
    class XMLWriter
    {
        #region Singleton Implementation
        public static XMLWriter Instance
        {
            get
            {
                if (instance == null)
                    instance = new XMLWriter();
                return instance;
            }
        }
        private static XMLWriter instance;

        private XMLWriter()
        {
            //intentionally empty
        }
        #endregion

        public void Write(iXMLWritable XMLObject, string writePath)
        {
            XDocument xmlDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Generated by XMLWriter.cs"),
                XMLObject.GetAsElement());
            xmlDocument.Save(writePath);
        }

        public void WriteToZip(iXMLWritable XMLObject, string writePath, string fileName)
        {
            XDocument xmlDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Generated by XMLWriter.cs"),
                XMLObject.GetAsElement());

            byte[] doc = Encoding.UTF8.GetBytes(xmlDocument.ToString());

            ZipArchive parentFile = ZipFile.Open(writePath, ZipArchiveMode.Update);
            ZipArchiveEntry saveLoc = parentFile.GetEntry(fileName);

            saveLoc.Open().Write(doc, 0, doc.Count());

            parentFile.Dispose();
        }
    }
}
