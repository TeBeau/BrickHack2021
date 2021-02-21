using Microsoft.Extensions.Logging;

namespace BrickHack2021
{
    public class Coffee
    {
        public string name{ get; set; }
        public string description{ get; set; }
        public Store store{ get; set; }
        public string recipe{ get; set; }
        public bool saved {get; set;}

        public Coffee(){saved=false;}
        public Coffee( string n, string d, Store s){
            name = n;
            description =d;
            store = s;   
            saved= false;
        }
        public Coffee( string n, string d,string rec){
            name = n;
            description =d;
            recipe= rec; 
            saved =false;
        }
        
    }
}