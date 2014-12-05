using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMasters.Model
{
    public class Member
    {
        public int Id { get; set; }
        public IList<Speech> Speeches { get; set; }
        public DateTime MembershipStart { get; set; }
        public DateTime MembershipEnd { get; set; }
    }
}
