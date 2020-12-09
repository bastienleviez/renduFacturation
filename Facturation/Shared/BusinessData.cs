using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturation.Shared
{
    public class BusinessData : IBusinessData
    {
        public IEnumerable<Facture> Factures { get; set; }

        public BusinessData(IEnumerable<Facture> fs)
        {
            this.Factures = fs;
        }

        public BusinessData()
        {

        }
    }
}
