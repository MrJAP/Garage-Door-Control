// See https://aka.ms/new-console-template for more information

using GarageDoorControl.Common;

Console.WriteLine("Please attach debugger and hit enter");
Console.ReadLine();

//var x = new GpioTest();
//await x.ReadGpioPins();


//var y = new RelayTest();
//y.TurnAllRelaysOff();
//await y.ToggleRelay(1);

var z = new LcdTest();
z.SendMessage("Hello World!");


