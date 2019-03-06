using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zoo_shop.Models
{
    public class Pet
    {
        protected string Name;
        protected string Breed;
        public string[] Pets = { "Cat", "Dog" };

        public virtual string Introduce() { return ""; }
    }
}
