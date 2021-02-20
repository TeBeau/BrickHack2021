using Microsoft.Extensions.Logging;

namespace helloworld
{
    public class Coffee
    {
        public string name;
        public string description;
        public Store store; 
        public string picLink;

        public Coffee( string n, string d){
            name = n;
            description =d;
            store= null;
            picLink = null;
        }
        public Coffee( string n, string d, Store s){
            name = n;
            description =d;
            store = s;   
            picLink= null;
        }
        public Coffee( string n, string d,string pic){
            name = n;
            description =d;
            store = null;
            picLink= pic; 
        }
        public Coffee( string n, string d, Store s, string pic){
            name = n;
            description =d;
            store = s;
            picLink= pic; 
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
    }
}