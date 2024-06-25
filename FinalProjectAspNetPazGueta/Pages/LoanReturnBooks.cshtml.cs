using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProjectAspNetPazGueta.Pages
{
    public class LoanReturnBooksModel : PageModel
    {
        private readonly Startup _startup;

        public LoanReturnBooksModel (Startup startup)
        {
            _startup = startup;
        }
        public void OnGet()
        {
        }
        /*
         public IActionResult OnPostLoanBookByName(string subscriberName, string bookName)
            {
                var subscriber = FindSubscriberByName(subscriberName);
                var book = FindBookByName(bookName);

                if (subscriber == null || book == null)
                {
                    // Subscriber or book not found, display an error message or handle accordingly
                    // return an appropriate view or redirect
                }
                else if (subscriber.LoanedBooks.Count >= 3)
                {
                    // Subscriber has reached the maximum number of books on loan, display an error message or handle accordingly
                    // return an appropriate view or redirect
                }
                else
                {
                    // Loan the book to the subscriber
                    LoanBookToSubscriber(book, subscriber);
                    return RedirectToPage();
                }
            }
         
        */
    }
}
