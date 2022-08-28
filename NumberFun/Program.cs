// See https://aka.ms/new-console-template for more information
using NumberFun;
using System.Text;

int i = 0;
if (int.TryParse(Console.ReadLine(), out i))
{
    NumberService numberService = new NumberService();  
    string message = numberService.GetNumberString(i);
    Console.WriteLine(message);
}
else
{
    Console.WriteLine("Not a number");
}


Console.Read();