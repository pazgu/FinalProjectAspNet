using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FinalProjectAspNetPazGueta.Model.BookStore.Pages.Models;

namespace FinalProjectAspNetPazGueta.Pages
{
    public class ManageLibraryModel : PageModel
    {
        private readonly Startup _startup;

        public ManageLibraryModel(Startup startup)
        {
            _startup = startup;
        }

        [BindProperty]
        public Subscriber Subscriber { get; set; }

        [BindProperty]
        public Book Book { get; set; }

        public void OnGet()
        {
            // This method is executed when the page loads.
        }

        public IActionResult OnPostAddBook()
        {
            if (ModelState.IsValid)
            {
                // Call the AddNewBook method from the Startup class to add the new book.
                _startup.AddNewBook(Book.BookName, Book.Author, Book.Genre);

                // Optionally, you can redirect the user to another page after successful submission.
                TempData["Message"] = "New book added successfully.";
                //return RedirectToPage("/Index");
            }

            // If the model state is not valid, return the current page with validation errors.
            return Page();
        }

        public IActionResult OnPostAddSubscriber()
        {
            if (ModelState.IsValid)
            {
                // Call the AddNewBook method from the Startup class to add the new book.
                _startup.AddNewSubscriber(Subscriber.FirstName, Subscriber.LastName);

                // Optionally, you can redirect the user to another page after successful submission.
                TempData["Message"] = "New subscriber added successfully.";
                //return RedirectToPage("/Index");
            }

            // If the model state is not valid, return the current page with validation errors.
            return Page();
        }

        /*
        public IActionResult OnPostDeleteBook(int bookId)
        {
            // Check if the book is currently on loan
            if (IsBookOnLoan(bookId))
            {
                // Book is on loan, display an error message or handle accordingly
                // return an appropriate view or redirect
            }
            else
            {
                // Book is not on loan, proceed with deleting the book from the database
                DeleteBookFromDatabase(bookId);
                return RedirectToPage();
            }
        }


        public IActionResult OnPostDeleteSubscriber(int subscriberId)
        {
            // Check if the subscriber has any books on loan
            if (HasBooksOnLoan(subscriberId))
            {
                // Subscriber has books on loan, display an error message or handle accordingly
                // return an appropriate view or redirect
            }
            else
            {
                // Subscriber has no books on loan, proceed with deleting the subscriber from the database
                DeleteSubscriberFromDatabase(subscriberId);
                return RedirectToPage();
            }
        }
        */
    }
}
