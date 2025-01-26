using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec12
{
    internal class Post
    {
        public string Title { get; set; }
        public DateTime Stamp { get; set; }=DateTime.Now;
        public string Description { get; set; }
        public User Creator { get; set; }
        public override string ToString()
        {
            return $"{Title}:{Description}:{Stamp}:{Creator}";
        }
    }
}
