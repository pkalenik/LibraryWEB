using LibraryWEB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LibraryWEB.Controllers
{
    public class QuestionnaireController : Controller
    {

        LibraryContext db;

        public QuestionnaireController(LibraryContext context)
        {
            db = context;
        }

        /// <summary>
        /// Shows all questionnaires
        /// </summary>
        /// <returns>Index page</returns>
        public IActionResult Index()
        { 
            return View(new Questionnaire());
        }

        /// <summary>
        /// Checks the Questionnaire model for data validity
        /// </summary>
        /// <returns>Result page if model is valid and Index page else</returns>
        [HttpPost]
        public IActionResult Index(Questionnaire questionnaire, IFormCollection collection)
        {
            if (string.IsNullOrEmpty(questionnaire.FirstName) && string.IsNullOrEmpty(questionnaire.LastName))
            {
                ModelState.AddModelError("FirstName", "The field FirstName must be input");
                ModelState.AddModelError("LastName", "The field LastName must be input");
            }
            else if (string.IsNullOrEmpty(questionnaire.FirstName))
            {
                ModelState.AddModelError("FirstName", "The field First Name must be input");
            }
            else if (string.IsNullOrEmpty(questionnaire.LastName))
            {
                ModelState.AddModelError("LastName", "The field Last Name must be input");
            }
            else if (questionnaire.FirstName == questionnaire.LastName)
            {
                ModelState.AddModelError("FirstName", "First and last name can't match!");
            }
            else if (questionnaire.FirstName.Contains("Admin") || questionnaire.LastName.Contains("Admin"))
            {
                ModelState.AddModelError("FirstName", "Admin name is not available!");
            }

            if (ModelState.IsValid)
            {
                QuestionnaireAnswer qaDto = new QuestionnaireAnswer()
                {
                    Answer = collection["genre"],
                };
                QuestionnaireAnswer qa2Dto = new QuestionnaireAnswer
                {
                    Answer = collection["language"],
                };
                QuestionnaireAnswer qa3Dto = new QuestionnaireAnswer
                {
                    Answer = collection["age"] == "true,false" ? "Yes" : "No",
                };

                var questionnaireDto = new Questionnaire()
                {
                    Id = questionnaire.Id,
                    FirstName = questionnaire.FirstName,
                    LastName = questionnaire.LastName,
                    QuestionnaireAnswers = new List<QuestionnaireAnswer>
                    {
                        qaDto, qa2Dto, qa3Dto
                    }
                };

                List<string> answerList = new List<string> { collection["genre"], collection["language"], collection["age"] == "true,false" ? "Yes" : "No" };

                ViewBag.answerList = answerList;

                db.Questionnaires.Add(questionnaireDto);

                db.SaveChanges();

                return View("Result", questionnaire);
            }

            return View("Index", new Questionnaire());
        }
    }
}
