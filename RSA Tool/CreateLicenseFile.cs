using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RSA_Tool
{
    public partial class CreateLicenseFile
    {

        public CreateLicenseFile()
        {

        }


        struct LicenseData
        {
            public string Comment;
            public string Type;
            public DateTime Expiration;
            public int Quantity;
            public List<string> Features;
            public string CustomerName;
            public string CustomerEmail;
        }


        public void GenerateFile(string sourceText, string signatureText)
        {
            if (sourceText == string.Empty || signatureText == string.Empty)
            {
                MessageBox.Show("Source text or signature is empty. No license file created!", "Not all data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {

                //Type->Trail
                //Expiration->03.03.2020
                //Quantity->1
                //Feature->Basic
                //Feature->FT
                //Feature->ET
                //Name->Elbe
                //Email->elbe.chrst@at.at

                LicenseData licData = new LicenseData();
                licData.Features = new List<string>();
                string[] lines = sourceText.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

                for(int i = 0; i < lines.Length; i++) {
                    String[] line = Regex.Split(lines[i], @"\->");
                    switch (line[0].ToString()) {
                        case "Type":
                            licData.Type = line[1];
                            break;
                        case "Expiration":
                            licData.Expiration = Convert.ToDateTime(line[1]);
                            break;
                        case "Quantity":
                            licData.Quantity = int.Parse(line[1]);
                            break;
                        case "Feature":
                            licData.Features.Add(line[1]);
                            break;
                        case "Name":
                            licData.CustomerName = line[1];
                            break;
                        case "Email":
                            licData.CustomerEmail = line[1];
                            break;
                    }
                }

                XDocument doc = new XDocument(
                    new XComment("This is a comment"),
                    new XElement("License",
                        new XElement("Type", licData.Type),
                        new XElement("Expiration", licData.Expiration),
                        new XElement("Quantity", licData.Quantity)
                    )
                );

                XElement features = new XElement("Features");

                foreach (string feature in licData.Features)
                {
                    features.Add(new XElement("Feature", feature));
                }
                doc.Root.Add(features);

                XElement customerData = new XElement("Customer",
                    new XElement("Name", licData.CustomerName),
                    new XElement("Email", licData.CustomerEmail)
                );

                XElement signature = new XElement("signature", signatureText);

                doc.Root.Add(customerData);
                doc.Root.Add(signature);
                doc.Save(Application.StartupPath + "\\LicenseFiles\\lic1.xml");
            }
        }
    }
}
