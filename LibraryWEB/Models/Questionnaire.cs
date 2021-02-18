using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWEB.Models
{
    public class Questionnaire
    {
        /// <summary>
        /// Id of the Questionnaire for identification
        /// </summary>
        [Required]
        public int Id { get; set; }
        /// <summary>
        /// First name of the person who fills the questionnaire
        /// </summary>
        [Display(Name = "First Name:")]
        public string FirstName { get; set; }

        /// <summary>
        /// /// <summary>
        /// Last name of the person who fills the questionnaire
        /// </summary>
        /// </summary>
        [Display(Name = "Last Name:")]
        public string LastName { get; set; }

        /// <summary>
        /// Answers list of the person who fills out the questionnaire
        /// </summary>
        public ICollection<QuestionnaireAnswer> QuestionnaireAnswers { get; set; }

        /// <summary>
        /// Implements QuestionnaireAnswers list
        /// </summary>
        public Questionnaire()
        {
            QuestionnaireAnswers = new List<QuestionnaireAnswer>();
        }
    }
}
