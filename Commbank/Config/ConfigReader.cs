using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml;
using System.Xml.XPath;
using System.IO;

namespace Commbank.Config
{
    public class ConfigReader
    {


        public static void SetFrameworkSettings()
        {

            XPathItem aut;
            XPathItem testtype;
            XPathItem islog;
            XPathItem isreport;
            XPathItem buildname;
            XPathItem logPath;

            //get xml file path
            string strFilename = Environment.CurrentDirectory.ToString() + "\\Config\\GlobalConfig.xml";
            //Read xml file
            FileStream stream = new FileStream(strFilename, FileMode.Open);
            XPathDocument document = new XPathDocument(stream);
            XPathNavigator navigator = document.CreateNavigator();

            //Get XML Details and pass it in XPathItem type variables
            aut = navigator.SelectSingleNode("Commbank/RunSettings/AUT");
            buildname = navigator.SelectSingleNode("Commbank/RunSettings/BuildName");
            testtype = navigator.SelectSingleNode("Commbank/RunSettings/TestType");
            islog = navigator.SelectSingleNode("Commbank/RunSettings/IsLog");
            isreport = navigator.SelectSingleNode("Commbank/RunSettings/IsReport");
            logPath = navigator.SelectSingleNode("Commbank/RunSettings/LogPath");

            //Set XML Details in the property to be used accross framework
            Settings.AUT = aut.Value.ToString();
            Settings.BuildName = buildname.Value.ToString();
            Settings.TestType = testtype.Value.ToString();
            Settings.IsLog = islog.Value.ToString();
            Settings.IsReporting = isreport.Value.ToString();
            Settings.LogPath = logPath.Value.ToString();
        }

    }
}
