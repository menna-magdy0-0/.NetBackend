using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask1.Model
{
    public class News
    {
        public int NewsId { get; set; }
        public string Title { get; set; }
        public string bref { get; set; }
        public string? Description { get; set; }
        public DateTime dateTime { get; set; } = DateTime.Now;

        //foreign key
        public int AuthorId { get; set; }//sql
        //foreign key
        public int CatalogId { get; set; }//sql

        //navigation property
        public virtual Catalog Catalog { get; set; }//c#
        public virtual Author Author { get; set; }//c#

        //public override string ToString()
        //{
        //    return base.ToString();
        //}

    }
}
