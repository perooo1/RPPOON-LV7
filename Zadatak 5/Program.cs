using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////////////////////////////////// Zadatak 5
            /*
            Book book = new Book("The Kite Runner - Khaled Hosseini", 19.99);
            DVD DVDItem = new DVD("Windows 98 for beginners", DVDType.SOFTWARE, 15.49);
            DVD DVDItem2 = new DVD("The Matrix Reloaded", DVDType.MOVIE, 79.99);
            VHS VHSItem = new VHS("The lion king ", 39.99);

            IVisitor visitor = new BuyVisitor();
            
            Console.WriteLine(book); 
            Console.WriteLine(DVDItem); 
            Console.WriteLine(DVDItem2); 
            Console.WriteLine(VHSItem);

            Console.WriteLine("\nAfter accepting:");
            Console.WriteLine(book.Accept(visitor));
            Console.WriteLine(DVDItem.Accept(visitor));
            Console.WriteLine(DVDItem2.Accept(visitor));
            Console.WriteLine(VHSItem.Accept(visitor));
            */
            /////////////////////////////////////////////////////////////////////////////////////////// Zadatak 6
            /*
            Book book = new Book("The Kite Runner - Khaled Hosseini", 19.99);
            DVD DVDItem = new DVD("Windows 98 for beginners", DVDType.SOFTWARE, 15.49);
            DVD DVDItem2 = new DVD("The Matrix Reloaded", DVDType.MOVIE, 79.99);
            VHS VHSItem = new VHS("The lion king ", 39.99);

            IVisitor visitor = new RentVisitor();

            Console.WriteLine(book);
            Console.WriteLine(DVDItem);
            Console.WriteLine(DVDItem2);
            Console.WriteLine(VHSItem);

            Console.WriteLine("\nAfter renting:");
            Console.WriteLine(book.Accept(visitor));
            Console.WriteLine(DVDItem.Accept(visitor));
            Console.WriteLine(DVDItem2.Accept(visitor));
            Console.WriteLine(VHSItem.Accept(visitor));
            */
            /////////////////////////////////////////////////////////////////////////////////////////// Zadatak 7
            
            IVisitor visitor = new RentVisitor();
            Cart cart = new Cart(visitor);

            cart.AddToCart(new Book("The Kite Runner - Khaled Hosseini", 19.99));
            cart.AddToCart(new DVD("Windows 98 for beginners", DVDType.SOFTWARE, 15.49));
            cart.AddToCart(new DVD("The Matrix Reloaded", DVDType.MOVIE, 79.99));
            cart.AddToCart(new VHS("The lion king ", 39.99));


            Console.WriteLine(cart.Accept(visitor)); 
            
        }
    }
}
