using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    internal class Jucator
    {
        public enum Pozitie { Portar, Mijlocas, Fundas, Atacant }

        string cnp, nume;
        Pozitie pozitie;
        DateTime data_nasterii;
        byte varsta;

        public string Cnp { get { return cnp; } }
        public string Nume { get { return nume; } }
        public string Poz { get { return pozitie.ToString(); } }
        public DateTime Data { get { return data_nasterii; } }
        public byte Varsta { get { return varsta; } }

        public Jucator(string cnp, string nume, string pozitie)
        {
            this.cnp = cnp;
            this.nume = nume;
            switch (pozitie)
            {
                case "Portar":
                    this.pozitie = Pozitie.Portar;
                    break;
                case "Mijlocas":
                    this.pozitie = Pozitie.Mijlocas;
                    break;
                case "Fundas":
                    this.pozitie = Pozitie.Fundas;
                    break;
                case "Atacant":
                    this.pozitie = Pozitie.Atacant;
                    break;
                default: break;
            }
            data_nasterii = DataHandler.createDataNasterii(cnp);
            varsta = Convert.ToByte(DateTime.Now.Year - data_nasterii.Year);
            if (data_nasterii.Month > DateTime.Now.Month) varsta--;
            else if (data_nasterii.Month == DateTime.Now.Month && data_nasterii.Day > DateTime.Now.Day) varsta--;
        }
    }
}
