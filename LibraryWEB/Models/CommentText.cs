using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWEB.Models
{
    public class CommentText
    {
        public int Id { get; set; }

        [Display(Name = "Your Feedback:")]
        public string Text { get; set; }

        public int CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}
