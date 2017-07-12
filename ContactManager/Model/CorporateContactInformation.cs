using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Model
{
    public class CorporateContactInformation : ContactInformation
    {
        public string NIP { get; set; }
        public string REGON { get; set; }
    }
}
