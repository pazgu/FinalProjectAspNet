namespace FinalProjectAspNetPazGueta.Model
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    namespace BookStore.Pages.Models
    {
        public class Book
        {
            [BsonId]
            [BsonRepresentation(BsonType.ObjectId)]
            public string? Id { get; set; }

            [BsonElement("Name")]
            public string? BookName { get; set; }

            [BsonElement("Author")]
            public string? Author { get; set; }

            [BsonElement("Genre")]
            public string? Genre { get; set; }

            public Book() { }

            public Book(string id, string bookName, string author, string genre)
            {
                Id = id;
                BookName = bookName;
                Author = author;
                Genre = genre;
            }
        }
    }

}
