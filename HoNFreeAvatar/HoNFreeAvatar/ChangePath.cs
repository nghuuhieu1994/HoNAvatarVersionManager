using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HoNFreeAvatar
{
    public partial class ChangePath : Form
    {
        public ChangePath()
        {
            InitializeComponent();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("path");

            XmlNode version = xmlDoc.SelectSingleNode("version");
            XmlNode SBT = version.SelectSingleNode("SBT");
            XmlNode Super = version.SelectSingleNode("Super");
            XmlNode Garena = version.SelectSingleNode("Garena");

            textBox1.Text = SBT.Attributes[0].Value;
            textBox2.Text = Garena.Attributes[0].Value;
            textBox3.Text = Super.Attributes[0].Value;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode docNode = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmlDoc.AppendChild(docNode);

            XmlNode version = xmlDoc.CreateElement("version");
            xmlDoc.AppendChild(version);

            XmlNode sbtNode = xmlDoc.CreateElement("SBT");
            XmlAttribute sbtAttribute = xmlDoc.CreateAttribute("Path");
            sbtAttribute.Value = textBox1.Text;
            sbtNode.Attributes.Append(sbtAttribute);
            version.AppendChild(sbtNode);

            XmlNode garenaNode = xmlDoc.CreateElement("Garena");
            XmlAttribute garenaAttribute = xmlDoc.CreateAttribute("Path");
            garenaAttribute.Value = textBox2.Text;
            garenaNode.Attributes.Append(garenaAttribute);
            version.AppendChild(garenaNode);

            XmlNode superNode = xmlDoc.CreateElement("Super");
            XmlAttribute superAttribute = xmlDoc.CreateAttribute("Path");
            superAttribute.Value = textBox3.Text;
            superNode.Attributes.Append(superAttribute);
            version.AppendChild(superNode);

            xmlDoc.Save("path");
            this.Close();
        }
    }
}
