﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tsunami;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace Tsunami.UnitTest
{
   
 [TestClass()]
    public class SessionManagerTests

    {
        const string TORRENT_LIBRE_OFFICE = "LibreOffice_5.1.1_Win_x86.msi.torrent";
        const string TORRENT_FOLDER = @"Torrent\";
        Boolean bSessionManagerStarted = false;
        Boolean bStartWeb = false;
        [TestMethod()]
        public void InitializeTest()
        {
            Boolean bResult = true;
            if (bSessionManagerStarted == false)
            {
                SessionManager.Initialize();
                bSessionManagerStarted = true;
            }

            Assert.IsTrue(bResult) ;
        }

        [TestMethod()]
        public void startWebTest() { 
// Tests nothing because SessionManager.startWeb() is a void Method
            Boolean bResult = true;
            if (bStartWeb == false) { 
                SessionManager.startWeb();
                bStartWeb = true;
            }
            Assert.IsTrue(bResult);
        }

        [TestMethod()]
        public void stopWebTest()
        {
// Tests nothing because SessionManager.stopWeb() is a void Method
            Boolean bResult = true;
            if (bStartWeb == true) {
                SessionManager.stopWeb();
                bStartWeb = false;
            }
            Assert.IsTrue(bResult);
        }

        [TestMethod()]
        public void TerminateTest()
        {
// Tests nothing because SessionManager.terminate() is a void Method
            Boolean bResult = true;
            if (bSessionManagerStarted == true)
            {
                SessionManager.Terminate();
                bSessionManagerStarted = false;
            }
            Assert.IsTrue(bResult);
        }

        [TestMethod()]
        public void getTorrentStatusTest()
        {

        }

        [TestMethod()]
        public void getTorrentFilesTest()
        {

        }

        [TestMethod()]
        public void getTorrentStatusListTest()
        {

        }

        [TestMethod()]
        public void addTorrentTest()
        {
            string path = Path.GetDirectoryName(
                     Assembly.GetExecutingAssembly().Location);
            string path2 = Path.GetFullPath(path);
            path = Path.Combine(path2, TORRENT_FOLDER, TORRENT_LIBRE_OFFICE);
            if (File.Exists(path))
            {
                SessionManager.addTorrent(path);
            } else
            {
                Assert.Fail("File " + path + " does not exists");
            }
// qui bisogna istanziare un listener per TorrentAdded
        }

        [TestMethod()]
        public void addTorrentTest1()
        {

        }

        [TestMethod()]
        public void deleteTorrentTest()
        {

        }

        [TestMethod()]
        public void pauseTorrentTest()
        {

        }

        [TestMethod()]
        public void resumeTorrentTest()
        {

        }

        [TestMethod()]
        public void GiveMeStateFromEnumTest()
        {

        }

        [TestMethod()]
        public void GiveMeStorageModeFromEnumTest()
        {

        }
    }
}