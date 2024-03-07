using GenericAnimalClass;
using System;
namespace GenericAnimalClass
{


    // define a generic class named Animal
    public class Animal<T>
    {
        // define a field type t
        public T data;

        // define a constructor of the animal class
        public Animal(T data)
        {
            this.data = data;
            Console.WriteLine("Data passed: " + this.data);
        }

        public T getAnimal()
        {
            return data;
        }

    } 

}

    internal class Program
    {
        static void Main(string[] args)
        {
        // create an instance with a string data type
        Animal<string> animalName = new Animal<string>("Animal Name: Bat");

        //create an instance with an string data type
        Animal<string> animalHabitat = new Animal<string>("Animal Habitat: Caves");

        //create an instance with a bool data type
        Animal<bool> endangered = new Animal<bool>(true);

        // create an instance with a bool value
        Animal<bool> extinct = new Animal<bool>(false);

        // create an instance with  an int type
        Animal<int> averageLifeSpan = new Animal<int>(10);

        // c# recognizes that the objects created with the generic are not the same
        /*var objEqual = animalName.Equals(animalHabitat);
        Console.WriteLine(objEqual);
        var objEquals = animalName.Equals(endangered);
        Console.WriteLine(objEquals); */

        }
    }

