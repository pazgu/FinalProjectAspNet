namespace FinalProjectAspNetPazGueta.Model
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    namespace BookStore.Pages.Models
    {
        public class Subscriber
        {
            [BsonId]
            [BsonRepresentation(BsonType.ObjectId)]
            public string? Id { get; set; }

            [BsonElement("FirstName")]
            public string? FirstName { get; set; }

            [BsonElement("LastName")]
            public string? LastName { get; set; }

            public List<Book> LoanedBooks { get; set; } = new List<Book>();

            public Subscriber() { }

            public Subscriber (string id, string firstName, string lastName, List<Book> LoanedBooks)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                LoanedBooks = LoanedBooks;
            }
        }
    }

}
