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
        public IList<int> Speeches { get; set; }
    }
}
