using System;
using System.Collections.Generic;

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
