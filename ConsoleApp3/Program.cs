public class Program
{
    public static void Main()
    {
        RomanNumber num_1 = new RomanNumber(1500);
        RomanNumber num_2 = new RomanNumber(2100);
        RomanNumber num_3 = new RomanNumber(100);
        RomanNumber num_4 = new RomanNumber(5);
        //RomanNumber num_5 = new RomanNumber(0); /*exception*/
        RomanNumber num_6 = new RomanNumber(2000);
        Console.WriteLine("Number №1 = 1500 = " + num_1.ToString());
        Console.WriteLine("Number №2 = 2100 = " + num_2.ToString());
        Console.WriteLine("Number №3 = 100 = " + num_3.ToString());
        Console.WriteLine("Number №4 = 5 = " + num_4.ToString());
        Console.WriteLine("Num№1 + Num№2 = " + RomanNumber.Add(num_1, num_2).ToString());
        Console.WriteLine("Num№2 - Num№1 = " + RomanNumber.Sub(num_2, num_1).ToString());
        //Console.WriteLine(RomanNumber.Add(num_2, num_6).ToString()); /*exception*/
        //Console.WriteLine(RomanNumber.Sub(num_2, num_1).ToString()); /*exception*/
        Console.WriteLine("Num№3 * Num№4 = " + RomanNumber.Mul(num_3, num_4).ToString());
        Console.WriteLine("Num№3 / Num№4 = " + RomanNumber.Div(num_3, num_4).ToString());
        //Console.WriteLine(RomanNumber.Mul(num_1, num_2).ToString()); /*exception*/
        //Console.WriteLine(RomanNumber.Div(num_4, num_3).ToString()); /*exception*/

        Console.WriteLine("\nSort");
        RomanNumber[] numbers = { num_1, num_2, num_3, num_4, num_6 };
        Array.Sort(numbers);
        for (int i = 0; i < 5; ++i)
        {
            Console.WriteLine(numbers[i].ToString());
        }
        Console.WriteLine("\nCopy");
        var f = (RomanNumber)num_1.Clone();
        Console.WriteLine(f.ToString());
    }
}