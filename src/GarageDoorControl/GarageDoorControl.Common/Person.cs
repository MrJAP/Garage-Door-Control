using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageDoorControl.Common
{
    public class Person
    {
        public string Name { get; set; }
        public string FavoriteColor { get; set; }
        public string FavoriteIceCreamFlavor { get; set; }
        public DateTime DateOfBirth { get; set; }
        public TimeSpan Age => DateTime.UtcNow - DateOfBirth;

    }
}
