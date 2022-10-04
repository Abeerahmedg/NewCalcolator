using NewCalcolator;
using static NewCalcolator.Operations;

double AskForNumber()
{
    double num;
    Console.WriteLine("Please enter a number:");
    num = Convert.ToDouble(Console.ReadLine());
    return num;
}
 do
{
    double num1;
    double num2;
    double result;

    Console.WriteLine("Select Operation: ");
    Console.WriteLine("\t+:Add\t-:Substract\t*:Multibly\t/:Divide");

    switch (Console.ReadLine())
    {
        case "+":
            Console.WriteLine("Choose the number you want: 1- Add single number.\n2- add array");
           int add=Convert.ToInt32(Console.ReadLine());

            while(Console.ReadLine()= 1)
            {
            num1 = AskForNumber();
            num2 = AskForNumber();
                result = Addition(num1, num2);
                Console.WriteLine($"The Result : {num1} + {num2} = " + result);
           
            }
            break;

            
        case "-":
            num1=AskForNumber();
            num2=AskForNumber();
            result = Substract(num1, num2);
            Console.WriteLine($"The Result: {num1} - {num2} = " + result);
            break;
        case "*":
            num1=AskForNumber();
            num2=AskForNumber();
            result = Multiply(num1, num2);
            Console.WriteLine($"The Result: {num1} * {num2} =" + result);
            break;
        case "/":
            num1=AskForNumber();
            num2 = AskForNumber();
            if (num2 != 0) //added if here to recogoniz the 0 input
            {
                result = Divide(num1, num2);
                Console.WriteLine($"The Result: {num1} / {num2}= " + result);
            }
            else Console.WriteLine("Can not be divided!");
            break;
        default:
            Console.WriteLine("That was not valid option");
            break;

    }
    Console.WriteLine("Should we continue!(Press Y for Yes and N for No): ");
} while (Console.ReadLine().ToUpper() == "Y"); // the check condition for the loop
Console.WriteLine("See You again!");
Console.ReadKey(); //to read the key press from the user