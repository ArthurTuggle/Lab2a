using System;
class HelloWorld {
static void Main() {
  
Console.WriteLine("Enter the name of item");
string str;
str = Console.ReadLine(); 
Console.WriteLine("Enter the quantity");
string a1;
a1 = Console.ReadLine();
int a2;
a2 = Convert.ToInt32(a1);
  
Console.WriteLine("Enter the price");
string b1;
b1 = Console.ReadLine();
float b2 = 0.0f;
b2 = Single.Parse(b1); 
  
float price = a2 * b2; 

Console.WriteLine("Total price of {0} = {1}", str, price);
}
}