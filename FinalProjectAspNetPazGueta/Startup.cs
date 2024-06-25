using FinalProjectAspNetPazGueta.configuration;
using FinalProjectAspNetPazGueta.Model.BookStore.Pages.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace FinalProjectAspNetPazGueta
{
    public class Startup
    {
        private readonly IMongoCollection<Book> _booksCollection;
        private readonly IMongoCollection<Subscriber> _subscribersCollection;

        public Startup(IOptions<DatabaseSettings> bookDatabaseSettings)
        {
            var mongoClient = new MongoClient(bookDatabaseSettings.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(bookDatabaseSettings.Value.DatabaseName);

            _booksCollection = mongoDatabase.GetCollection<Book>(bookDatabaseSettings.Value.BooksCollectionName);
            _subscribersCollection = mongoDatabase.GetCollection<Subscriber>(bookDatabaseSettings.Value.SubscribersCollectionName);

            try
            {
                //_subscribersCollection.InsertOne(s);
                
            }
            catch (MongoWriteException ex)
            {
                if (ex.WriteError.Category == ServerErrorCategory.DuplicateKey)
                {
                }
                throw; // Re-throw the exception if it's not a duplicate key error
            }
        }

        public void AddNewBook(string bookName, string author, string genre)
        {
            var newBook = new Book(id: null, bookName, author, genre);

            _booksCollection.InsertOne(newBook);
        }

        public void AddNewSubscriber(string firstName, string lastName)
        {
            var newSubscriber = new Subscriber(id: null, firstName, lastName, new List<Book>());

            _subscribersCollection.InsertOne(newSubscriber);
        }
    }
}
