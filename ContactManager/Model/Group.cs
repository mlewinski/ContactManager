using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Model
{
    public class Group
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Contact> Members { get; set; }

        public void AddContact(Contact contact)
        {
            if(contact!=null)
                Members.Add(contact);
        }

        public void RemoveContact(int ID)
        {
            Members.RemoveAll(x => x.ID == ID);
        }
    }
}
