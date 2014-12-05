using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMasters.Model
{
    public class Club
    {
        public int ClubNumber { get; set; }
        public int District { get; set; }
        public int Zone { get; set; }
        public DateTime EstablishedDate { get; set; }
        public IList<Member> Members { get; set; }
        public IList<Officer> Officers { get; set; }
    }
}
