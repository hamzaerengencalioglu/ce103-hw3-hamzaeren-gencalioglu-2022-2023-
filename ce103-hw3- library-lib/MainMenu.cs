using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace libraryapplication
{
    public class MainMenu
    {
        public string erenslibrary = @"

                  ______ _____  ______ _   _ _  _____   _      _____ ____  _____            _______     __
                 |  ____|  __ \|  ____| \ | ( )/ ____| | |    |_   _|  _ \|  __ \     /\   |  __ \ \   / /
                 | |__  | |__) | |__  |  \| |/| (___   | |      | | | |_) | |__) |   /  \  | |__) \ \_/ / 
                 |  __| |  _  /|  __| | . ` |  \___ \  | |      | | |  _ <|  _  /   / /\ \ |  _  / \   /  
                 | |____| | \ \| |____| |\  |  ____) | | |____ _| |_| |_) | | \ \  / ____ \| | \ \  | |   
                 |______|_|  \_\______|_| \_| |_____/  |______|_____|____/|_|  \_\/_/    \_\_|  \_\ |_|   
                                                                                          
            ";
        public string space = @"


";

        #region Mainmenu
        public void Menu()

        {
            Console.Clear();
            Console.WriteLine(erenslibrary);
            string mainmenu = @"
                                                1) Category 
                                                2) Book
                                                3) Exit
                              ";
            Console.WriteLine(mainmenu);
            Console.WriteLine("Please Type The Number Of The Menu You Want To Enter And Click Enter");
            int entrymainmenu = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                switch (entrymainmenu)
                {
                    case 1:

                        MainMenu category = new MainMenu();
                        category.Category();
                        break;

                    case 2:

                        MainMenu book = new MainMenu();
                        book.Book();
                        break;

                        //case 3:
                }
            }

        }
        #endregion

        #region Category
        public void Category()
        {
            Console.Clear();
            Console.WriteLine(erenslibrary);
            string categoryoptions = @"
                                            1) Edit Category
                                            2) Delete Category
                                            3) Exit
                    ";
            Console.WriteLine(categoryoptions);
            int entrycategory = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                switch (entrycategory)
                {
                    case 1:
                        MainMenu editcategory = new MainMenu();
                        editcategory.EditCategory();
                        break;

                    case 2:
                        MainMenu deletecategory = new MainMenu();
                        deletecategory.DeleteCategory();
                        break;

                    case 3:
                        MainMenu exitcategory = new MainMenu();
                        exitcategory.ExitCategory();
                        break;
                }

            }

        }

        public void EditCategory()
        {
            Console.Clear();
            Console.WriteLine(erenslibrary);
            Console.WriteLine("Enter The Category You Want To Edit :");
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.ReadLine();


            }


            Console.Clear();
            MainMenu BackToCategory = new MainMenu();
            BackToCategory.Category();



        }

        public void DeleteCategory()
        {
            Console.Clear();
            Console.WriteLine(erenslibrary);
            Console.WriteLine("Enter The Category You Want To Delete :");
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.ReadLine();


            }


            Console.Clear();
            MainMenu BackToCategory = new MainMenu();
            BackToCategory.Category();



        }

        public void ExitCategory()
        {
            Console.Clear();
            MainMenu exitcategory = new MainMenu();
            exitcategory.Menu();

        }
        #endregion

        #region Book
        public void Book()
        {
            Console.Clear();
            Console.WriteLine(erenslibrary);
            string bookoptions = @"
                                            1) Search Book
                                            2) All Books
                                            3) Lend Book
                                            4) Add Book
                                            5) Edit Book
                                            6) Delete Book
                                            7) Exit
                    ";
            Console.WriteLine(bookoptions);

            int entrybook = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                switch (entrybook)
                {
                    case 1:
                        MainMenu searchbook = new MainMenu();
                        searchbook.SearchBook();
                        break;

                    case 2:
                        MainMenu allbooks = new MainMenu();
                        allbooks.AllBooks();
                        break;

                    case 3:
                        MainMenu lendbook = new MainMenu();
                        lendbook.BookLend();
                        break;
                    case 4:
                        MainMenu addbook = new MainMenu();
                        addbook.AddBook();
                        break;

                    case 5:
                        MainMenu editbook = new MainMenu();
                        editbook.EditBook();
                        break;

                    case 6:
                        MainMenu deletebook = new MainMenu();
                        deletebook.DeleteBook();
                        break;

                    case 7:
                        MainMenu exitbook = new MainMenu();
                        exitbook.ExitCategory();
                        break;

                }

            }

        }

        public void AddBook()
        {
            Console.Clear();
            Console.WriteLine(erenslibrary);
            Console.WriteLine("                                                         Add Book");
            Console.WriteLine("If You Want To Add A Book, Press Enter");

            while (Console.ReadKey().Key == ConsoleKey.Enter)
            {

                StreamWriter sw = new StreamWriter("Books.dat", true, Encoding.GetEncoding("UTF-8"));

                Console.Clear();
                Console.WriteLine(erenslibrary);
                Console.WriteLine("                                                         Add Book");
                Console.WriteLine(space);

                Console.WriteLine("Category :");
                string Entrycategory = Console.ReadLine();


                Console.WriteLine("ID : ");
                int entryıd = Convert.ToInt32(Console.ReadLine());
                StreamWriter ıddat = new StreamWriter(entryıd + ".dat", true, Encoding.GetEncoding("UTF-8"));
                StreamWriter category = new StreamWriter(Entrycategory + ".dat", true, Encoding.GetEncoding("UTF-8"));

                sw.WriteLine("ID : " + entryıd);
                ıddat.WriteLine("ID : " + entryıd);
                category.WriteLine("ID :" + entryıd);


                sw.WriteLine("Category : " + Entrycategory);
                ıddat.WriteLine("Category : " + Entrycategory);
                category.WriteLine("Category : " + Entrycategory);




                Console.WriteLine("Name : ");
                string entryname = Console.ReadLine();
                sw.WriteLine("Name : " + entryname);
                ıddat.WriteLine("Name : " + entryname);
                category.WriteLine("Name :" + entryname);
                StreamWriter Name = new StreamWriter(entryname + ".dat", true, Encoding.GetEncoding("UTF-8"));
                Name.WriteLine("Name :" + entryname);
                Name.WriteLine("ID :" + entryıd);
                Name.WriteLine("Category :" + Entrycategory);


                Console.WriteLine("Author :");
                string entryauthor = Console.ReadLine();
                sw.WriteLine("Author : " + entryauthor);
                ıddat.WriteLine("Author : " + entryauthor);
                category.WriteLine("Author :" + entryauthor);
                Name.WriteLine("Author :" + entryauthor);

                Console.WriteLine("Pages :");
                int entrypages = Convert.ToInt32(Console.ReadLine());
                sw.WriteLine("Pages : " + entrypages);
                ıddat.WriteLine("Pages : " + entrypages);
                category.WriteLine("Pages :" + entrypages);
                Name.WriteLine("Pages :" + entrypages);

                Console.WriteLine("Edition :");
                string entryedition = Console.ReadLine();
                sw.WriteLine("Edition : " + entryedition);
                ıddat.WriteLine("Edition : " + entryedition);
                category.WriteLine("Edition : " + entryedition);
                Name.WriteLine("Edition :" + entryedition);
                Books books = new Books { ID = entryıd, Name = entryname, Author = entryauthor, Pages = entrypages, Edition = entryedition, Category = Entrycategory };

                sw.WriteLine("-------------------------------------------------------------------------------------------------------------------");
                ıddat.WriteLine("----------------------------------------------------------------------------------------------------------------");
                category.WriteLine("----------------------------------------------------------------------------------------------------------------");
                Name.WriteLine("----------------------------------------------------------------------------------------------------------------");
                sw.Close();
                sw.Dispose();
                ıddat.Close();
                ıddat.Dispose();
                category.Close();
                category.Dispose();
                Name.Close();
                Name.Dispose();


                Console.Clear();
                Console.WriteLine(erenslibrary);
                Console.WriteLine("                                                         Add Book");
                Console.WriteLine(space);
                Console.WriteLine("The Book Successfully Added");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine(erenslibrary);
                Console.WriteLine("                                                         Add Book");
                Console.WriteLine(space);
                Console.WriteLine("If You Want To Add A New Book Press Enter. Press Esc If You Want To Exit");

            }

            Console.Clear();
            MainMenu BackToBook = new MainMenu();
            BackToBook.Book();



        }

        public void EditBook()
        {
            Console.Clear();
            Console.WriteLine(erenslibrary);
            Console.WriteLine("                                                             Edit Book");
            Console.WriteLine(space);
            Console.WriteLine("If You Want to Edit the ID of the book press enter");

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine(erenslibrary);
                Console.WriteLine("                                                         Edit Book");
                Console.WriteLine(space);
                Console.WriteLine("Enter the ID of the book you want to edit :");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine(erenslibrary);
                Console.WriteLine("                                                         Edit Book");
                Console.WriteLine(space);
                Console.WriteLine("The Book Successfully Edited");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine(erenslibrary);
                Console.WriteLine("                                                         Edit Book");
                Console.WriteLine(space);
                Console.WriteLine("If ou Want To Edit Another Book Press Any Key. Press Esc If You Want To Exit");

            }
            Console.Clear();

            MainMenu BackToBook = new MainMenu();
            BackToBook.Book();

        }

        public void DeleteBook()
        {
            Console.Clear();
            Console.WriteLine(erenslibrary);
            Console.WriteLine("Enter The ID Of The Book You Want To Delete :");

            if (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                int deleteidbook = Convert.ToInt32(Console.ReadLine());
                if (File.Exists(deleteidbook + ".dat"))
                {
                    File.Delete(deleteidbook + ".dat");
                    //Console.WriteLine("Deleted Book");
                    //Thread.Sleep(800);

                    Console.WriteLine("Enter The Name Of The Book You Want To Delete");
                    string deletenamebook = Console.ReadLine();
                    if (File.Exists(deletenamebook + ".dat"))
                    {
                        File.Delete(deletenamebook + ".dat");
                        Console.WriteLine("Deleted Book");
                        Thread.Sleep(800);

                    }
                    else
                    {
                        Console.WriteLine("No Book Found By This Name");
                        Thread.Sleep(800);
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.DeleteBook();
                    }

                }
            }
            else
            {
                Console.Clear();
                MainMenu BackToBook = new MainMenu();
                BackToBook.Book();
            }

        }
        public void ExitBook()
        {
            Console.Clear();
            MainMenu exitbook = new MainMenu();
            exitbook.Menu();


        }
        #endregion

        #region BookRental
        public void BookLend()
        {
            Console.Clear();
            Console.WriteLine(erenslibrary);
            Console.WriteLine("                                                             Lend Book");
            Console.WriteLine("If You Want to Lend The Book, Press Any Button.");

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {

                Console.Clear();
                Console.WriteLine(erenslibrary);
                Console.WriteLine("                                                         Lend Book");
                Console.WriteLine(space);
                Console.WriteLine("ID Number Of The Person : ");
                ulong personid = Convert.ToUInt64(Console.ReadLine());
                StreamWriter PersonID = new StreamWriter(personid + ".dat", true, Encoding.GetEncoding("UTF-8"));
                PersonID.WriteLine(personid);


                Console.WriteLine("Name Of The Person : ");
                string personname = Console.ReadLine();
                PersonID.WriteLine(personname);

                Console.WriteLine("Phone Number Of The Person : ");
                ulong personnumber = Convert.ToUInt64(Console.ReadLine());
                PersonID.WriteLine(personnumber);

                Console.WriteLine("The Date The Book Was Borrowed : ");
                ulong date = Convert.ToUInt64(Console.ReadLine());
                PersonID.WriteLine(date);

                Console.WriteLine("ID Of The Book : ");
                int lendbookid = Convert.ToInt32(Console.ReadLine());
                PersonID.WriteLine(lendbookid);

                Console.WriteLine("Name Of The Book : ");
                string lendbookname = Console.ReadLine();
                PersonID.WriteLine(lendbookname);
                PersonID.WriteLine("----------------------------------------------------------------------------------------------------------------");
                PersonID.Close();
                PersonID.Dispose();
                PersonInformation personinformation = new PersonInformation { PID = personid, Pname = personname, Pphonenumber = personnumber, Pdate = date };
                Books book = new Books { ID = lendbookid, Name = lendbookname };



                Console.Clear();
                Console.WriteLine("The Book Successfully Lended");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine(erenslibrary);
                Console.WriteLine("                                                         Lend Book");
                Console.WriteLine(space);
                Console.WriteLine("If You Want To Add A New Book Press Enter. Press Esc If You Want To Exit");

            }
            Console.Clear();
            MainMenu BackToBook = new MainMenu();
            BackToBook.Book();
        }
        #endregion

        public void AllBooks()
        {
            Console.Clear();
            Console.WriteLine(erenslibrary);
            Console.WriteLine("");
            Console.WriteLine("                                                       All Books");
            Console.WriteLine(space);
            string filepath = @"Books.dat";
            string readbook = System.IO.File.ReadAllText(filepath, Encoding.GetEncoding("UTF-8"));
            Console.WriteLine(readbook);
            Console.WriteLine(space);
            Console.WriteLine("Press To Esc to exit");
            while (Console.ReadKey().Key == ConsoleKey.Escape)
            {

                Console.Clear();
                MainMenu backbooksmenu = new MainMenu();
                backbooksmenu.Book();
            }
        }
        public void SearchBook()
        {
            Console.Clear();
            Console.WriteLine(erenslibrary);
            Console.WriteLine("");
            Console.WriteLine("                                                         Search Book");
            Console.WriteLine(space);
            string searchbookoptions = @"
                                            1) Book Search By ID
                                            2) Book Search By Name
                    ";
            Console.WriteLine(searchbookoptions);

            int searchoptions = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                switch (searchoptions)
                {
                    case 1:
                        Console.WriteLine("ID : ");
                        if (Console.ReadKey().Key == ConsoleKey.Escape)
                        {

                            Console.Clear();
                            MainMenu backbooksmenu = new MainMenu();
                            backbooksmenu.Book();
                        }
                        else
                        {
                            int searchidbook = Convert.ToInt32(Console.ReadLine());
                            Books books = new Books { ID = searchidbook };
                            if (File.Exists(@searchidbook + ".dat"))
                            {
                                string filepath1 = @searchidbook + ".dat";
                                string readbook = System.IO.File.ReadAllText(filepath1, Encoding.GetEncoding("UTF-8"));
                                Console.WriteLine(readbook);
                                Console.WriteLine(space);
                                Console.WriteLine("Press To Esc to exit");
                                while (Console.ReadKey().Key == ConsoleKey.Escape)
                                {

                                    Console.Clear();
                                    MainMenu backbooksmenu = new MainMenu();
                                    backbooksmenu.Book();
                                }

                            }
                            else
                            {
                                Console.WriteLine("No Book Found With This ID");
                                Thread.Sleep(1000);


                                Console.Clear();
                                MainMenu backbooksmenu = new MainMenu();
                                backbooksmenu.Book();


                            }
                        }
                        break;

                    case 2:
                        Console.WriteLine("Name : ");
                        if (Console.ReadKey().Key == ConsoleKey.Escape)
                        {


                            Console.Clear();
                            MainMenu backbooksmenu = new MainMenu();
                            backbooksmenu.Book();
                        }
                        else
                        {
                            string searchnamebook = Console.ReadLine();
                            Books books = new Books { Name = searchnamebook };
                            if (File.Exists(@searchnamebook + ".dat"))
                            {
                                string filepath2 = @searchnamebook + ".dat";
                                string readbook = System.IO.File.ReadAllText(filepath2, Encoding.GetEncoding("UTF-8"));
                                Console.WriteLine(readbook);
                                Console.WriteLine(space);
                                Console.WriteLine("Press To Esc to exit");
                                while (Console.ReadKey().Key == ConsoleKey.Escape)
                                {

                                    Console.Clear();
                                    MainMenu backbooksmenu = new MainMenu();
                                    backbooksmenu.Book();
                                }

                            }
                            else
                            {
                                Console.WriteLine("No Book Found With This Name");
                                Thread.Sleep(1000);


                                Console.Clear();
                                MainMenu backbooksmenu = new MainMenu();
                                backbooksmenu.Book();


                            }
                        }
                        break;



                }




                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {

                    Console.Clear();
                    MainMenu backbooksmenu = new MainMenu();
                    backbooksmenu.Book();
                }
                else
                {
                    int searchbook = Convert.ToInt32(Console.ReadLine());
                    Books books = new Books { ID = searchbook };
                    if (File.Exists(@searchbook + ".dat"))
                    {
                        string filepath = @searchbook + ".dat";
                        string readbook = System.IO.File.ReadAllText(filepath, Encoding.GetEncoding("UTF-8"));
                        Console.WriteLine(readbook);
                        Console.WriteLine(space);
                        Console.WriteLine("Press To Esc to exit");
                        while (Console.ReadKey().Key == ConsoleKey.Escape)
                        {

                            Console.Clear();
                            MainMenu backbooksmenu = new MainMenu();
                            backbooksmenu.Book();
                        }



                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("                                     No Book Found With This ID");
                        Thread.Sleep(1000);
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.SearchBook();




                    }
                }

            }
        }
    }
}

