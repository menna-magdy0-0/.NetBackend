using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask1.Model
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public DateTime JoinDate { get; set; } = DateTime.Now;
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Bref { get; set; }

        public virtual ICollection<News> News { get; set; }
        =new HashSet<News>();

        //public override string ToString()
        //{
        //    return base.ToString();
        //}
    }
}
