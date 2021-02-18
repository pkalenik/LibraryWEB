using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWEB.Models
{
    public class QuestionnaireAnswer
    {
        /// <summary>
        /// Id of the QuestionnaireAnswer for identification
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Answer of person who fills the questionnaire
        /// </summary>
        public string Answer { get; set; }
        /// <summary>
        /// Foreign key for communication with the questionnaire model
        /// </summary>
        public int QuestionnaireId { get; set; }
        /// <summary>
        /// The object of the questionnaire to access it
        /// </summary>
        public Questionnaire Questionnaire { get; set; }
    }
}
