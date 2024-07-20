using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab3
{
    internal class DataHandler
    {
        static public DateTime createDataNasterii(string cnp)
        {
            if (cnp.Length != 13) return new DateTime(1, 1, 1);
            try
            {
                int an = 1900 + Convert.ToInt32(cnp[1] + "" + cnp[2]);
                int luna = Convert.ToInt32(cnp[3] + "" + cnp[4]);
                int zi = Convert.ToInt32(cnp[5] + "" + cnp[6]);
                if (cnp[0] == '5' || cnp[0] == '6') an += 100;
                return new DateTime(an, luna, zi);
            }
            catch (Exception) { return new DateTime(1, 1, 1); }
        }
        
        static public void writeJucator(string path, string cnp, string nume, string pozitie)
        {
            //File.Create(path + cnp + ".lpf");
            StreamWriter strW = new StreamWriter(path + cnp + ".lpf", false);
            strW.WriteLine(nume);
            strW.WriteLine(pozitie);
            strW.Close();
        }
    }
}
