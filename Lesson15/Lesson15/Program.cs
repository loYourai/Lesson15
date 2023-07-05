// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;




const string FileName = "vote topic2.txt";
const int MaximumRoomLenght = 25;
const int MaximumNameLenght = 50;


const string FileName2 = "vote topic3.txt";
const int MaximumRoomLenght2 = 25;
const int MaximumNameLenght2 = 50;






int[] golos2;
    golos2 = new int[2];




void showgolos()
{
    Console.WriteLine( $"{"Yes",20}"
        + $"{"No",20}");
    var fileContent = File.ReadAllLines(FileName2);

    foreach (var line in fileContent)
    {
        var meetingContent = line.Split(",");

        Console.WriteLine($"{golos2[0],20} "
            + $"{golos2[1],20}");


    }
    Console.ReadLine();
}




void Golos()
{
    Console.WriteLine("Если вы за напишите 2, если напишите 3");
    int golos = int.Parse(Console.ReadLine());
    int a = 2;
    if (golos == a)
    {

        //int av = 0;
        // Yes =  av++;
        golos2[0]++;
       

        //File.AppendAllText(FileName, $"{Yes} ");
    }
    int b = 3;
    if (golos == b)
    {
        golos2[1]++;
    }
    File.AppendAllText(FileName2, $"{golos2[0]} {golos2[1]}");

}
void Showalltopic()
{

    Console.WriteLine($"{"Topic",20}"
       );

    var fileContent = File.ReadAllLines(FileName);
    
    foreach (var line in fileContent)
    {
        var meetingContent = line.Split(",");

        Console.WriteLine($"{meetingContent[0],20} "
            );

        
    }   
      Console.ReadLine();
}     



void Addvotetopic() 
{
    Console.WriteLine("Topic void: ");
    var room = Console.ReadLine();
    File.AppendAllText(FileName, $"{room}" + Environment.NewLine);
}


void Exit()
{
    Environment.Exit(0);
}
void Menu()
{
    Console.Clear();
    Console.WriteLine("5. показать результаты");
    Console.WriteLine("4. Голосовать");
    Console.WriteLine("3. Show all topic");
    Console.WriteLine("2. Add vote topic");
    Console.WriteLine("1. Exit ");
}



while (true)
{
    Menu();
    var keyInfo = Console.ReadKey();
    switch (keyInfo.Key)
    {
        case ConsoleKey.D1:
            Exit();
            break;
        case ConsoleKey.D2:
            Addvotetopic();
            break;
        case ConsoleKey.D3:
            Showalltopic();
            break;
        case ConsoleKey.D4:
            Golos();
            break;
        case ConsoleKey.D5:
            showgolos();
            break;


        default: break;
    }
}

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

/*
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
*/
//strings.Clear();
//strings.Add("10");
//var count1 = strings.Count();
//var lenght1 = strings.Length;

//Console.ReadLine();
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













