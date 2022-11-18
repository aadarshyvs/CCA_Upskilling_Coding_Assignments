namespace introduction_6
{
    internal class Program
    {
        public enum bookTypes
        {
            Magazine = 0,
            Novel,
            ReferenceBook,
            Miscellaneous
        }
        struct Book
        {
            public int bookId;
            public string title;
            public string price;
            public string bookType;


        }
        static void Main(string[] args)
        {
            Book book = new Book();

            Console.WriteLine("Enter Book Id: ");
            book.bookId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Book Title: ");
            book.title = Console.ReadLine();


            Console.WriteLine("Enter Book price: ");
            book.price = Console.ReadLine();


            Console.WriteLine("Enter Book Type: ");
            Console.WriteLine("1-Magazine : 2-Novel : 3-ReferenceBook : 4-Miscellaneous");

            int action = Convert.ToInt32(Console.ReadLine());

            switch (action)
            {
                case 1:
                    {
                        book.bookType = "Magazine";
                        break;
                    }
                case 2:
                    {
                        book.bookType = "Novel";
                        break;
                    }
                case 3:
                    {
                        book.bookType = "ReferenceBook";
                        break;
                    }
                case 4:
                    {
                        book.bookType = "Miscellaneous";
                        break;
                    }
                default:
                    Console.WriteLine("Wrong action!! try again");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine(" Details of book are\n" + "ID: " + book.bookId + " \n Title: " + book.title + " \n Price: " + book.price + " \n Type: " + book.bookType);
            Console.ReadKey();
        }
    }
}
