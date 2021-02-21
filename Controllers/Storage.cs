using System;
using System.Text.Json;
using System.Collections.Generic;

namespace BrickHack2021.Controllers
{
    public class Storage
    {
        private const string PATH = "coffee_db.txt";                            // Path to 'database' text file
        private List<Coffee> coffeeList;
        public Storage(){}

        public void writeToFile(Coffee coffee){
            string coffeeJson = JsonSerializer.Serialize(coffee);
            Console.WriteLine(coffeeJson);
            
            System.IO.File.WriteAllText(PATH, string.Format(coffeeJson));
        }

        public void ReadFromFile(){
            string coffeeDB = System.IO.File.ReadAllText(PATH);
            Console.WriteLine(coffeeDB);
        }
    }
}