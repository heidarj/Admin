using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin
{
    class Program
    {
        static void Main(string[] args)
        {
                string path = Directory.GetCurrentDirectory();
                var psi = new ProcessStartInfo("cmd.exe");
                psi.Verb = "runas";
                psi.UseShellExecute = false;
                psi.Arguments = string.Format("/d {0} ", path);
                Process.Start(psi);
        }
    }
}
