using static NewCalcolator.Operations;

double AskForNumber()
{
    double num;
    Console.WriteLine("Please enter a number:");
    num = Convert.ToDouble(Console.ReadLine());
    return num;
}
decimal AskForNumbers()
{
    decimal num;
    Console.WriteLine("Please enter a number:");
    num = Convert.ToInt32(Console.ReadLine());
    return num;
}


do
{
    double num1;
    double num2;
    int num3;
    int num4;
    decimal resultt;
    double result;


    Console.WriteLine("Select Operation: ");
    Console.WriteLine("+:Add\t-:Substract\t*:Multibly\t/:Divide");

    switch (Console.ReadLine())
    {
        case "+":
            Console.WriteLine("Choose the number you want: 1- Add two numbers.\n2- add more than two numbers");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1)
            {
                num1 = AskForNumber();
                num2 = AskForNumber();
                result = Addition(num1, num2);
                Console.WriteLine($"The Result : {num1} + {num2} = " + result);

            }
            else if (answer == 2)
            {
                Console.WriteLine("How many numbers would you like to get the sum for !");
                int count = int.Parse(Console.ReadLine());
                int[] arr = new int[count];
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("number{0}:", i + 1);
                    arr[i] = int.Parse(Console.ReadLine());
                }
                result = Addition(arr);
                Console.WriteLine($"The result of your numbers = {result}");

            }
            else Console.WriteLine("Wrong input!");
            break;


        case "-":
            Console.WriteLine("Choose the number you want: \n1- Substract two number.\n2- Substract more than two");
            int answer1 = Convert.ToInt32(Console.ReadLine());
            if (answer1 == 1)
            {
                num1 = AskForNumber();
                num2 = AskForNumber();
                result = Subtract(num1, num2);
                Console.WriteLine($"The Result: {num1} - {num2} = " + result);
            }
            else if (answer1 == 2)
            {
                Console.WriteLine("How many numbers would you like to get the sum for !");
                int count = int.Parse(Console.ReadLine());
                int[] arr = new int[count];
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("number{0}:", i + 1);
                    arr[i] = int.Parse(Console.ReadLine());
                }
                result = Subtract(arr);
                Console.WriteLine($"The result of your numbers = {result}");

            }
            else Console.WriteLine("Wrong input");

            break;
        case "*":
            num1 = AskForNumber();
            num2 = AskForNumber();
            result = Multiply(num1, num2);
            Console.WriteLine($"The Result: {num1} * {num2} =" + result);
            break;
        case "/":

           num3 = (int)AskForNumbers();
            num4 = (int)AskForNumbers();
            if (num4 != 0) try //added if here to recogoniz the 0 input
                {
                    resultt = (decimal)Divide(num3, num4);
                    Console.WriteLine($"The Result: {num3} / {num4}= " + resultt);
                }
                catch (DivideByZeroException msg)
                {
                    Console.WriteLine(msg);

                }
            else Console.WriteLine("Can not be divided!");
            break;
        default:
            Console.WriteLine("That was not valid option");
            break;

    }
    Console.WriteLine("Should we continue!(Press Y for Yes and N for No): ");
} while (Console.ReadLine().ToUpper() == "Y"); // the check condition for the loop

Exception DivideByZeroException()
{
    throw new NotImplementedException();
    Console.WriteLine("Can not be divided!");
}

Console.WriteLine("See You again!");
Console.ReadKey();
Environment.Exit(0);
