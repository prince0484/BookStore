using BookStore.Entity;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Service
{
    public class BookStoreService : IBookStore
    {
        //public string connectionString = string.Empty;
        string connectionString = "Server=localhost;port=3306;Database=mybookstore;UserId=root;Password=Manju@8409;";

        public BookStoreService(/*IConfiguration config*/)
        {
            //connectionString = config["ConnectionStrings : DefaultConnection"];
        }

        public int DMLTransaction(string query)
        {
            throw new NotImplementedException();
        }

        public Book GetBookById(int bookId)
        {
            throw new NotImplementedException();
        }

        public Cart GetCartDetails(string query)
        {
            throw new NotImplementedException();
        }

        public List<category> GetListCategoryByBookId(int bookId)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetListOfBooks()
        {
            List<Book> books = new List<Book>();

            // MySQL connection string (example: update with your credentials)
           
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();  // Open MySQL connection

                string sql = "SELECT * FROM book";  // SQL query to get all books

                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Assuming Book has properties like Id, Title, Author, etc.
                            //Book book = new Book();
                            books.Add(new Book
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString(),
                                Description = reader["Description"].ToString(),
                                ISBNumber = reader["ISBNumber"].ToString(),
                                Price = Convert.ToDecimal(reader["Price"]),
                                PictureUri = reader["PictureUri"].ToString(),
                                BookAuthorId = Convert.ToInt32(reader["BookAuthorId"]),
                                BookStoreId = Convert.ToInt32(reader["BookStoreId"])
                                // Map other properties of the Book object here
                            });
                            //books.Add(book);  // Add book to the list
                        }
                    }
                    connection.Close();
                }
            }

            return books;  // Return the list of books
        }

        public List<Cart> GetListOfCart(string query)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetail> GetListOfOrder(string query)
        {
            throw new NotImplementedException();
        }

        public List<Store> GetListOfStores(string query)
        {
            throw new NotImplementedException();
        }

        public OrderDetail GetOrderDetails(string query)
        {
            throw new NotImplementedException();
        }

        public Store GetStoreById(string query)
        {
            throw new NotImplementedException();
        }

        public int InsertMultipleRecords(Book book, List<BookCategory> categories)
        {
            throw new NotImplementedException();
        }
    }


}
