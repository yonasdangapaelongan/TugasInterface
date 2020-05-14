using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
namespace Polymorphism2
{
    class ConvertToXml : IPrinterWindows
    {
        public void Convert(ShowPrint sp)
        {
            using (StringWriter writer = new StringWriter())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ShowPrint));
                serializer.Serialize(writer, sp );

                string xml = writer.ToString();

                Console.WriteLine("Hasil konversi ke XML :\n");
                Console.WriteLine(xml);
            };
        }

        
        
    }
}
