// Challenge 1 task 1
String[] carManufacturers = new String[4] { "Ford", "Toyota", "BMW", "Honda" };

// Task 2
foreach (var car in carManufacturers)
{
    Console.WriteLine(car);
    
}
Console.WriteLine(" ");

// Task 3
Array.Sort(carManufacturers);

foreach (var car in carManufacturers)
{
    Console.WriteLine(car);
}
Console.WriteLine(" ");

//Task 4
//for (int carIndex = 0; carIndex < carManufacturers.Length; carIndex++)
//{
  //  Console.WriteLine(carManufacturers[carIndex]); 
//}


// Challenge 2 Task 1
List<String> months = new List<String>();

// Task 2
months.Add("January");
months.Add("February");
months.Add("March");
months.Add("April");
months.Add("May");
months.Add("June");
months.Add("July");
months.Add("August");
months.Add("September");
months.Add("October");
months.Add("November");
months.Add("December");

Console.WriteLine(months.Count);

//Task 3
months.Remove("September");
months.Remove("November");

Console.WriteLine(months.Count);

// Task 4
carManufacturers.IndexOf("December");
Console.WriteLine("The index of December is: " + months.IndexOf("December"));

List<string> monthNamesArray = new List<string>();
Array<string> temp = new List<string>();
// Task 5 
temp = monthNamesArray.ToArray();