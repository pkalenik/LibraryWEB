using LibraryWEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWEB.Controllers
{
    public class GuestController : Controller
    {
        LibraryContext db;
        public GuestController(LibraryContext context)
        {
            db = context;
        }

        /// <summary>
        /// Shows all comments
        /// </summary>
        /// <returns>Index page</returns>
        // [Authorize(Roles = "user")]
        public IActionResult Index(int page = 1)
        {
            int pageSize = 3;   // количество элементов на странице

            IEnumerable<Comment> source = db.Comments.Include(c=> c.CommentText).OrderByDescending(c => c.Date);

            var count = source.Count();
            var items = source.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Comments = items
            };

            return View(viewModel);
        }

        /// <summary>
        /// Checks the Comment model for data validity
        /// </summary>
        /// <returns>Index page</returns>
        [HttpPost]
        public IActionResult Index(Comment comment, int page = 1)
        {
            if (string.IsNullOrEmpty(comment.Name) && string.IsNullOrEmpty(comment.CommentText.Text))
            {
                ModelState.AddModelError("Name", "The field Full Name must be input");
                ModelState.AddModelError("Text", "The field Feedback must be input");
            }
            else if (string.IsNullOrEmpty(comment.Name))
            {
                ModelState.AddModelError("Name", "The field Full Name must be input");
            }
            else if (comment.Name.Contains("Admin"))
            {
                ModelState.AddModelError("Name", "Admin name is not available!");
            }

            if (string.IsNullOrEmpty(comment.CommentText.Text))
            {
                ModelState.AddModelError("Text", "The field Feedback must be input");
            }
            else if (comment.CommentText.Text[0] != comment.CommentText.Text.ToUpper()[0])
            {
                ModelState.AddModelError("Text", "Must start with a capital letter");
            }
            else if (comment.CommentText.Text.Contains(">") || comment.CommentText.Text.Contains("<"))
            {
                ModelState.AddModelError("Text", "Feedback cannot contains < or >");
            }

            var text = db.CommentText.Where(c => c.Text == comment.CommentText.Text).FirstOrDefault();

            if(text != null)
            {
                ModelState.AddModelError("Text", "This text already exist!");
            }

            if (ModelState.IsValid)
            {
                comment.Date = DateTime.Now;

                db.Comments.Add(comment);
                db.SaveChanges();

                int pageSize = 3;

                IEnumerable<Comment> source = db.Comments.Include(c=>c.CommentText).OrderByDescending(c=>c.Date);

                var count = source.Count();
                var items = source.Skip((page - 1) * pageSize).Take(pageSize).ToList();

                PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
                IndexViewModel viewModel = new IndexViewModel
                {
                    PageViewModel = pageViewModel,
                    Comments = items
                };

                return View(viewModel);
            }

            return Index();
        }
    }
}
