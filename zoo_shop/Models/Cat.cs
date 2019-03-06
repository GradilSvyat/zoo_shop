using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zoo_shop.Models
{
    public class Cat : Pet
    {
        public Cat (string Name, string Breed)
        {
            this.Name = Name;
            this.Breed = Breed;
        }

        public override string Introduce()
        {
            return "I’m " + Name.ToString() + " of " + Breed.ToString() +". I’m a cat.";
        }
    }
}
