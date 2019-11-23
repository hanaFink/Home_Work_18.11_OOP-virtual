using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        /// <summary>
        /// returning array of only rasing horses
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static Horse []  GetRacingHorses(Horse [] arr)
        {
            int counter = 0;

            ///counts how many rasing horses in array

            foreach (Horse item in arr)
            {
                if (item.IsRaising() == true)
                {
                    counter++;
                }
            }
            
            ///make empty array for only raising  horses
            Horse[] rasing = new Horse[counter];

            counter = 0;


            /// fill array with raising horses
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].IsRaising() == true)
                {
                    rasing[counter] = arr[i];
                    counter++;
                }
            }

             return rasing ;
         
        } 
        /// <summary>
        /// printing sount of each animal
        /// </summary>
        /// <param name="arr"></param>
        static void AnimalSing(Animal [] arr)
        {
            foreach (Animal item in arr)
            {
                item.MakeSound();
            }
        }
        static void Main(string[] args)
        {
            Poodle littlPoodle = new Poodle("Poody","creckers","2");
            Wolf bigAngreeWolf = new Wolf("AngreeWolf", "meat", "1");
            Horse oneHorse = new Horse("Princess", true);
            PetWolf petWolf = new PetWolf("little pritty Wolf", "meat", "5");
            petWolf.MakeSound();

            Animal[] arrOfAnimals = { littlPoodle, bigAngreeWolf, oneHorse };

            AnimalSing(arrOfAnimals);


            Horse twoHorse = new Horse("two", true);
            Horse threeeHorse = new Horse("tree", false);
            Horse fourHorse = new Horse("four", false);
            Horse fiveHorse = new Horse("five", true);

            Horse[] rasingArr = { oneHorse, twoHorse, threeeHorse, fourHorse, fiveHorse };

            Horse [] onlyRaising =GetRacingHorses(rasingArr);
            foreach (Horse item in onlyRaising)
            {
                Console.WriteLine(item);
            }
        }
    }
}
