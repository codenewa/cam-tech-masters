using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechMasters.Model
{
    public class Officer
    {
        private Officer() { }
        
        private Officer(OfficerRole role)
        {
            this.Role = role;
        }

        public Member MemberInfo { get; set; }
        public DateTime TermStartDate { get; set; }
        public DateTime TermEndDate { get; set; }
        public OfficerRole Role { get; set; }
    }


}
