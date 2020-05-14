using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Polymorphism2
{
     class ConvertToJson : IPrinterWindows
    {
        public void Convert (ShowPrint sp)
        {
            string json = JsonConvert.SerializeObject(sp);

            Console.WriteLine ("Hasil Konversi ke json:\n");
            Console.WriteLine(json);
        }

    }
}
