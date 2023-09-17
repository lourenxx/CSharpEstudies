namespace CSharp;

class Program
{
    static void Main(string[] args)
    {
        int productCode;
        int productQuant;
        string payment; 

        Console.WriteLine("enter the product code: ");
        productCode = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the the product quantity: ");
        productQuant = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the payment method: ");
        payment = Console.ReadLine();

        if (productCode == 5)
        {
            double finalValue = 32 * productQuant;
            if (payment == "money")
            {
                if (finalValue >= 500)
                {
                    double discountValue = finalValue * 0.15;
                    Console.WriteLine($"the final valor with the discount now is: {discountValue}");
                }
            }
        }

    }
}