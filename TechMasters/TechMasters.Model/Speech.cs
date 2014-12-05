using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMasters.Model
{
    public class Speech
    {
        public int Id { get; set; }
        public int ManualId { get; set; }
        public int ProjectId { get; set; }
        public String Title { get; set; }
        public TimeSpan Duration { get; set; }
        public int SpeakerId { get; set; }
        public int EvaluatorId { get; set; }
        public Uri VideoLink { get; set; }
        public IList<Comment> Comments { get; set; }
    }
}
