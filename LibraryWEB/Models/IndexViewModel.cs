using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWEB.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Article> Articles { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public Comment Comment { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public Tag Tag { get; set; }
    }
}
