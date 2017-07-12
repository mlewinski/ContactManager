using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Model
{
    public class Contact
    {
        public int ID { get; set; }
        public List<Email> EmailAddresses { get; set; }
        public List<Phone> PhoneNumbers { get; set; }
        public List<GenericCommunicator> OtherCommunicators { get; set; }
        public DateTime Created { get; set; }
        public ContactInformation ContactInformation { get; set; }
    }
}
