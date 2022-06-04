using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTimeExplorer.Models
{
    public class CharacterModel
    {
        public int id { get; set; }
        public string slug { get; set; }
        public string displayName { get; set; }
        public string fullName { get; set; }
        public string species { get; set; }
        public string sex { get; set; }
        public string[] quotes { get; set; }
        public string sprite { get; set; }
    }

}
