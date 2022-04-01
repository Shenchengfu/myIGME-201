using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE20Dom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 11001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            // add the delegate method to be called after the webpage loads, set this up before Navigate()
            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);

            // if you want to use example.html from a local folder (saved in c:\temp for example):
            //this.webBrowser1.Navigate("c:\\temp\\example.html");

            // or if you want to use the URL  (only use one of these Navigate() statements)
            this.webBrowser1.Navigate("people.rit.edu/dxsigm/example.html");


        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;

            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h1");

            for (int i = 0; i < htmlElementCollection.Count; i++)
            {
                if (i == 0)
                {
                    htmlElement = htmlElementCollection[i];
                    htmlElement.InnerText = "My UFO Page";
                }
            }

            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h2");

            for (int i = 0; i < htmlElementCollection.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        htmlElement = htmlElementCollection[i];
                        htmlElement.InnerText = "My UFO Info";
                        break;
                    case 1:
                        htmlElement = htmlElementCollection[i];
                        htmlElement.InnerText = "My UFO Pictures";
                        break;
                    case 2:
                        htmlElement = htmlElementCollection[i];
                        htmlElement.InnerText = "";
                        break;
                }
            }

            htmlElement = webBrowser1.Document.Body;
            htmlElement.Style = "font-family:sans-serif; color:#bb3131;";

            htmlElementCollection = webBrowser.Document.GetElementsByTagName("p");

            for (int i = 0; i < htmlElementCollection.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        htmlElement = htmlElementCollection[i];
                        htmlElement.InnerHtml = "Report your UFO sightings here: <a href=\"http://www.nuforc.org\">www.nuforc.org</a>";
                        htmlElement.Style = "color:#00ff00; font-weight:bold; font-size:2em; text-transform:uppercase; text-shadow:3px 2px #ff0000;";
                        break;
                    case 1:
                        htmlElement = htmlElementCollection[i];
                        htmlElement.InnerText = "";
                        break;
                    case 2:
                        htmlElement = htmlElementCollection[i];

                        HtmlElement htmlElementImg = webBrowser1.Document.CreateElement("img");
                        htmlElementImg.SetAttribute("src", "https://www.giantfreakinrobot.com/wp-content/uploads/2021/05/ufo-ufos.jpg");
                        htmlElementImg.SetAttribute("alt", "UFO");

                        htmlElement.InsertAdjacentElement(HtmlElementInsertionOrientation.AfterBegin, htmlElementImg);
                        break;
                }
            }


            htmlElement = webBrowser1.Document.CreateElement("footer");
            htmlElement.InnerHtml = "&copy; 2022, YOUR NAME!";
            webBrowser1.Document.Body.AppendChild(htmlElement);
        }

    }
}
