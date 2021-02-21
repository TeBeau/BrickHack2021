using Microsoft.Extensions.Logging;

namespace BrickHack2021
{
    public class Coffee
    {
        public string name{ get; set; }
        public string description{ get; set; }
        public string store{ get; set; }
        public string recipe{ get; set; }
        public bool saved {get; set;}

        public Coffee(){saved=false;}

        
    }
}