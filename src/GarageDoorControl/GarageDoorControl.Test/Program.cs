// See https://aka.ms/new-console-template for more information

using GarageDoorControl.Common;


Console.WriteLine("Pick a number...");

var userNumber = Console.ReadLine();

var number = Convert.ToInt32(userNumber);
var numberSquared = number * number;

Console.WriteLine(numberSquared);

Console.ReadLine();


