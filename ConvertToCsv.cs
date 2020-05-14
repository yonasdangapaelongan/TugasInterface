using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism2
{
    class ConvertToCsv : IPrinterWindows
    {
        public void Convert(ShowPrint sp)
        {
            string csv = string.Format("{0}, {1}, {2}", sp.print, sp.nama, sp.printer);

            Console.WriteLine("Hasil Konversi ke csv:\n");
            Console.WriteLine(csv);
        }
    }
}
