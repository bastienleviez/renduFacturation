using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturation.Shared
{
    public class Facture
    {
        public string Client { get; set; }

        public string Numero { get; set; }

        public DateTime DateEmission { get; set; }

        public DateTime DateReglement { get; set; }

        public double MontantDu { get; set; }

        public double MontantRegle { get; set; }

        public Facture(string c, string n, DateTime de, DateTime dr, double md, double mr)
        {
            this.Client = c;
            this.Numero = n;
            this.DateEmission = de;
            this.DateReglement = dr;
            this.MontantDu = md;
            this.MontantRegle = mr;
        }
    }
}
