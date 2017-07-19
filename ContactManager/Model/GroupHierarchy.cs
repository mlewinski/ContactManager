using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Model
{
    public class GroupHierarchy
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Group> MemberGroups { get; set; }

        public void AddNewGroup(Group group) => MemberGroups.Add(group);
        public void RemoveGroup(int ID) => MemberGroups.RemoveAll(x => x.ID == ID);
    }
}
