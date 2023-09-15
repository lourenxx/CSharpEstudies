namespace CSharp;

class Program
{
    static void Main(string[] args)
    {

        string name;
        int age;

        Console.WriteLine("enter your NAME: ");
        name = Console.ReadLine();
        Console.WriteLine("enter you AGE");
        age = Convert.ToInt32(Console.ReadLine());

        if (age < 0)
        {
            Console.WriteLine($"{name.ToUpper()} you have {age} years old: BABY!");
        }

        else if (age <= 10)
        {
            Console.WriteLine($"{name.ToUpper()} you have {age} years old: CHILD!");
        }

        else if (age <= 18)
        {
            Console.WriteLine($"{name.ToUpper()} you have {age} years old: TEENAGER!");
        }

        else if (age <= 60)
        {
            Console.WriteLine($"{name.ToUpper()} you have {age} years old: ADULT!");
        }

        else if (age <= 100)
        {
            Console.WriteLine($"{name.ToUpper()} you have {age} years old: ELDERLY!");
        }

        else if (age > 100)
        {
            Console.WriteLine($"{name.ToUpper()} you have {age} years old: MUMMY!");
        }


    }
}