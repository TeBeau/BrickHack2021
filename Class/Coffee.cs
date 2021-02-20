using Microsoft.Extensions.Logging;

namespace helloworld
{
    public class Coffee
    {
        public string name;
        public string description;
        public Store store; 
        public string recipe;


        public Coffee( string n, string d, Store s){
            name = n;
            description =d;
            store = s;   
            rec= null;
        }
        public Coffee( string n, string d,string rec){
            name = n;
            description =d;
            store = null;
            recipe= rec; 
        }
        public string getName(){
            return name;
        }

        public string getDescrip(){
            return description;
        }

        public Store getStore(){
            return store;
        }
        public string getRecipe(){
            return recipe;
        }
    }
}