// See https://aka.ms/new-console-template for more information

using GarageDoorControl.Common;

var people = new List<Person>();
people.Add(new Person { Name = "Kelly Smith", FavoriteColor = "Orange", FavoriteIceCreamFlavor = "Chocolate", DateOfBirth = DateTime.Parse("12/15/1968") });
people.Add(new Person { Name = "Sam Richards", FavoriteColor = "Red", FavoriteIceCreamFlavor = "Mint", DateOfBirth = DateTime.Parse("4/1/1996") });


foreach (var person in people)
{
    Console.WriteLine(person.Name + "'s favorite color is " + person.FavoriteColor + " and they like " + person.FavoriteIceCreamFlavor + " ice cream, and is " + person.Age.Days + " days old.");
}


