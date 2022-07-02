using ConstData;

Console.WriteLine("***** Fun with Const *****\n");
Console.WriteLine($"The value of PI is: {MyMathClass.PI}");

LocalConstStringVariable();




Console.ReadLine();

static void LocalConstStringVariable()
{
    const string fixedStr = "Fixed string Data";
    Console.WriteLine(fixedStr);
}
