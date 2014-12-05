using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMasters.Model
{
    public struct Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public TimeSpan RecommendedDuration { get; set; }
        public string Description { get; set; }
        public IList<string> Objectives { get; set; }
    }
}
