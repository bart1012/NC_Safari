using Animals.Birds;
using Animals.Mammals;

namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tiger fluffy = new Tiger(70.5f);
            Penguin penny = new Penguin(21);

            fluffy.MakeSound();
            penny.MakeSound();

            fluffy.Hunt(); //prints "Tiger is hunting on land!"
            penny.Hunt(); //prints "Penguin is hunting in the water!"
            penny.Swim(); //prints "Penguin is swimming!"
        }
    }
}
