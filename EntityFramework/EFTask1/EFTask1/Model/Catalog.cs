using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask1.Model
{
    public class Catalog
    {
        public int CatalogId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Navigation Property 
        public virtual ICollection<News> News { get; set; }
        = new HashSet<News>();

        //public override string ToString()
        //{
        //    return base.ToString();
        //}
    }
}
