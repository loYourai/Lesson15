// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, Team!");


//int first = 10;
//int second = 20;


//string str1 = "123";
//string str2 = "456";

//string Print<U1, U2>(U1 param1, U2 param2)
//where U1 : class
//where U2 : class
//{
//    return param1.ToString() + param2.ToString();
//}

//string Print<U1, U2, U3>(U1 param1, U2 param2, U3 param3)
//    where U1 : class
//    where U2 : class
//    where U3 : class
//{
//    return param1.ToString() + param2.ToString() + param3.ToString();
//}


////Print(10, 20);
//Console.WriteLine(Print(str1, str2));


var strings = new ConsoleApp1.LinkedList<string>();
strings.Add("1");
strings.Add("2");
strings.Add("3");
strings.Add("4");
strings.Add("5");
//strings.Insert("6", 6);
//strings.Insert("100", 2);
//strings.Insert("200", 4);

strings.Insert("0", 1);

var count = strings.Count();
var lenght = strings.Length;

//strings.Clear();
//strings.Add("10");
//var count1 = strings.Count();
//var lenght1 = strings.Length;

Console.ReadLine();
//var fourhtElement = strings.Get(4);
//Console.WriteLine(fourhtElement);

//var integers = new ConsoleApp1.LinkedList<int>();
//integers.Add(1);
//integers.Add(2);
//integers.Add(3);
//integers.Add(4);
//integers.Add(5);

//var fourhtIntElement = integers.Get(3);
//Console.WriteLine(fourhtIntElement);

//Console.WriteLine(str1);
//Console.WriteLine(str2);