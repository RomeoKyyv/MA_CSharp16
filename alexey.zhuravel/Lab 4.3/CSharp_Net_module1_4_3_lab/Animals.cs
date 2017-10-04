using System.Collections;
using System.Collections.Generic;

namespace CSharp_Net_module1_4_3_lab
{
    //6) implement interface IEnumerable
    class Animals : IEnumerable
    {
        // 7) declare private array of Animal
        private List<Animal> animalsList;
        // 8) declare parameter constructor to initialize array   
        public Animals()
        {
            animalsList = new List <Animal> { new Animal("Bird", 2), new Animal("Crocodile", 178)};
        }
        // 9) implement method GetEnumerator(), which returns IEnumerator

        // use foreach on array of Animal
        // and yield return for every animal

        public IEnumerator GetEnumerator()
        {
            foreach (var animal in animalsList)
            {
                yield return animal;
            }
            throw new System.NotImplementedException();

        }

    }
}
