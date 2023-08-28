// See https://aka.ms/new-console-template for more information

using Singleton;

var cf = Configuration.GetInstance();
var cf2 = Configuration.GetInstance();

if (ReferenceEquals(cf, cf2))
{
    Console.WriteLine("ok");
}