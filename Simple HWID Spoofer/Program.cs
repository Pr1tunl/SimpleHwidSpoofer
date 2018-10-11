using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Simple_HWID_Spoofer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Credits to Variety for dumping the orginal\\
            //Just changed a few sleeps and removed some junk\\
            Console.Title = "Simple HWID Spoofer";
            string value = string.Empty;
            value = Console.ReadLine();
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\IDConfigDB\\Hardware Profiles\\0001", "HwProfileGuid2", value);
            Console.WriteLine("\nChanging And Saving...");
            Thread.Sleep(1000);
            Console.WriteLine("\nSaved. Now Closing.");
            Thread.Sleep(1000);
            Environment.Exit(0);
        }
    }
}
