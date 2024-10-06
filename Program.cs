
// for(int i = 1; i < 5; i ++)
// {
//     Console.Write(i);

//     for (int j = 0; j < 10; j++)
//     {
//         System.Console.Write("\t" + i*j);
//     }
//     System.Console.WriteLine();
// }

using System.Data;
using System.Net;
using System.Timers;

// Random random= new Random();
// int randomRows = random.Next(11);

// System.Console.WriteLine(randomRows);
// for(int i = 1; i < randomRows; i ++)
// {
//     Console.Write(i);

//     for (int j = 0; j < 10; j++)
//     {
//         System.Console.Write("\t" + i*j);
//     }
//     Console.WriteLine();
// }

string userChoice = DisplayMenu();

while (userChoice != "4"){
    RouteEm(userChoice);
    userChoice = DisplayMenu();
}

static string DisplayMenu(){
    System.Console.WriteLine("1. Display plain toppping pizza\n2. Cheese pizza\n3. Pepperoni pizza\n4. Exit");
    return Console.ReadLine();
}
static void RouteEm(string userChoice){
    if (userChoice == "1"){
        PlainPizza();
    }
    else if (userChoice == "2"){
        CheesePizza();
    }
    else if (userChoice == "3"){
        PepPizza();
    }
    else
    {
        System.Console.WriteLine("Invalid selection. Please try again.");
    }
}



static void PlainPizza(){
    Console.Clear();
    Random random = new Random();
    int randomRows = random.Next(8, 13);
    for (int i = 0; i < randomRows; i++)
        {
            for (int j = 0; j < randomRows - i; j++)
            {
                Console.Write("*");
            }
            System.Console.WriteLine();
        }
}

static void CheesePizza(){
    Console.Clear();
    Random random = new Random();
    int randomRows = random.Next(8, 13);
    

                

}

static void PepPizza(){

}