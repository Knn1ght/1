using System.Threading.Tasks.Dataflow;
using Tamagochi;
try
{
    var dog = new Dog();
    //new - new object then name
    var who = dog.WhoamI();
    Console.WriteLine(who);

    var dog2 = new Dog();
    

    while (true)
    {
        var toss = dog.Do();

        Console.WriteLine($"Hunger is {dog.Hunger}");
        Console.WriteLine($"Boredom is {dog.Boredom}");

        Console.WriteLine($"Toss was {toss}");

        if (toss > 10)
        {
            var action = Console.ReadLine();
            if (action == "F")
            {
                dog.Feed();
            }
            if (action == "P")
            {
                dog.Play();

            }
            while (action != "exit");
            break;
        }


        Console.WriteLine();

        Thread.Sleep(500);
    }
}
catch (DeadPetException)
{ Console.WriteLine("SHAME - PET IS DEAD"); }



