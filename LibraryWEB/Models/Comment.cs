using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryWEB.Models
{
    /// <summary>
    /// View Model of Comment
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// Id of the Comment for identification
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of the person who writes the comment
        /// </summary>
        [Display(Name = "Your Full Name:")]
        public string Name { get; set; }
        /// <summary>
        /// Text of comment
        /// </summary>
        //[Display(Name = "Your Feedback:")]
        //public string Text { get; set; }
        /// <summary>
        /// Date when the comment was published
        /// </summary>
        public DateTime Date { get; set; }

        public CommentText CommentText { get; set; }
    }
}
