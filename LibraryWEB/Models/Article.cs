using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWEB.Models
{
    public class Article
    {
        /// <summary>
        /// Id of the Article for identification
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Title of the Article
        /// </summary>
        [Display(Name = "Article Title:")]
        public string Title { get; set; }
        /// <summary>
        /// Date when the article was published
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Text of the Article
        /// </summary>
        [Display(Name = "Article Text:")]
        public string Text { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }

        public Article()
        {
            Tags = new List<Tag>();
        }
    }
}
