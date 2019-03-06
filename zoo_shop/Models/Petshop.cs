using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zoo_shop.Models
{
    public class Petshop
    {
        public static List<Pet> pet_collection = new List<Pet>();

        public static void AddPet(Pet new_pet)
        {
            pet_collection.Add(new_pet);
        }
        /*public string[] ShowPet;
        public void IntroduceAll()
        {
            foreach (Pet s in pet_collection)
            {
                s.Introduce();
            }
        }
        */
            /*switch (petForm.type)
            {
                case "Dog":
                    Pet d = new Dog(Name, Breed));
                    break;
                case "Cat":
                    Pet d = new Cat(Name, Breed);
                    break;
            }*/

}
}
