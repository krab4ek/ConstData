using ConstData;
var p = new MyMathClass();
Console.WriteLine("***** Fun with Const *****\n");
//Console.WriteLine($"The value of PI is: {MyMathClass.PI}");
Console.WriteLine($"The value of PI is: {p.PI}");

LocalConstStringVariable();




Console.ReadLine();

static void LocalConstStringVariable()
{
    const string fixedStr = "Fixed string Data";
    Console.WriteLine(fixedStr);
}
