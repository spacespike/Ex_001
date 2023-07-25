Console.Write ("Write your name: ");
string username = Console.ReadLine();

if(username.ToLower == "huckleberry")
{
    Console.WriteLine("Hey, are you mine Huckleberry?");
}
else 
{
    Console.Write("Howdy, ");
    Console.WriteLine(username);
}