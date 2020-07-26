using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RSA_Tool
{
    public partial class CreateLicenseFile
    {

        public CreateLicenseFile()
        {

        }

        public void GenerateFile(string sourceText, string signatureText)
        {
            if (sourceText == string.Empty || signatureText == string.Empty)
            {
                MessageBox.Show("Source text or signature is empty. No license file created!", "Not all data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                XDocument doc = new XDocument(
                    new XComment("This is a comment"),
                    new XElement("License",
                        new XElement("Type", "Trail"),
                        new XElement("Expiration", "01.03.2021"),
                        new XElement("Quantity", "1"),
                        new XElement("ProductFeatures",
                            new XElement("Feature", "feat1"),
                            new XElement("Feature", "fes2")
                        ),
                        new XElement("Customer",
                            new XElement("Name", "info6"),
                            new XElement("Email", "info7")
                        ),
                        new XElement("signature", "7DC15AE5799ECA1B4052FC1D7D6DDA9A61DEA728157D3E0D9FF5E389648069F8D0C103F9107FB9F498CCBAAC26459A5E516900335292189F68134A2D29BABDAC78947282518F4E47F0780664E9DEC856873B9055FE0BE67E6F20460B108102E40B2EBC31D87786BA6F751A3BA249F87A80430BC676C21B571BB10B959440F3FC")
                    )
                );
                doc.Save(Application.StartupPath + "\\LicenseFiles\\lic1.xml");
            }
        }

    }
}
