using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace BrickHack2021
{
    public class Store
    {
        /* Attributes */
        private string name;
        private string address;
        private List<Coffee> menu;
        /* End Attributes */

        /**
         * Store Constructor
         */
        public Store(string storeName, string storeAddress){
            address = storeAddress;
            name = storeName;
            menu = new List<Coffee>();
        } /* End Constructor */

        /**
         * Get the name of the Store object
         */
        public string getName(){
            return name;
        }

        /**
         * Get the mailing address of the Store object
         */
        public string getAddress(){
            return address;
        }
        
        /**
         * Add a Coffee object to the store menu
         */
        public void addToMenu(Coffee coffee){
            menu.Add(coffee);
        }
    }
}