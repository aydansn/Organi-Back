using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogani.Domain.Models.Entity
{
    public class BlogPost 
    {
        public int Id { get; set; }

        public string Body { get; set; }

        public string Title { get; set; }

        public string Slug { get; set; }

        public string Image { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public DateTime? PublishedDate { get; set; }




    }
}
