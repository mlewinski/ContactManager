using System;

namespace ContactManager.Model
{
    public class PersonalContactInformation : ContactInformation
    {
        public string Nickname { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Organization { get; set; }
    }
}
