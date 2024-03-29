﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            //collections are arrays on steroids
            //examples of collections: lists and dictionaries

            
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "B2";

            Book b1 = new Book();
            b1.Author = "Abe Cede";
            b1.Title = "Microsoft .NET XML Web Services";
            b1.ISBN = "0-000-00000-0";

            //old style collections:
            /*
            // ArrayLists are dynamically sized,
            // cool features like sorting, remove items
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1); // old style collections are not strongly typed,
                                 // you can add anythig to a collection

            myArrayList.Remove(b1); 
            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            */

            /*
            //new style collections:
            //List<T>
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add((car2));
            //myList.Add(b1); //you can't add b1 to this list
            foreach (Car car in myList)
            {
                Console.WriteLine(car.Make);
            }
            */

            /*
            // Dictionary<TKey, TValue> 

            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();

            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["B2"].Make);
            */

            //string[] names = { "Bob", "Steve", "Brian", "Chuck" };

            // Object initializer syntax
            // No need for a Constructor
            //Car car1 = new Car() { Make = "BMW", Model = "750li", VIN = "C3" };
            //Car car2 = new Car() { Make = "Toyota", Model = "4Runner", VIN = "D4" };

            // Collection initializer

            List<Car> myList = new List<Car>()
            {
                new Car { Make = "Oldsmobile", Model = "Cutlass Supreme", VIN = "E5" },
                new Car { Make = "dsdsde", Model = "Caaaaaa", VIN = "F6" }

            };


            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; } //type prop + 2 x tab
        public string Make { get; set; }
        public string Model { get; set; }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}