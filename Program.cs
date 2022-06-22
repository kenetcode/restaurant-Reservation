using System;

/*
 * 1. Validar si es un usuario existente o si se debe registrar, y generar un sistema de registro o login
 * 2. El programa debe ser capaz de dar la bienvenida a un usuario existente si en efecto existe
 * 3. El programa debe repetirse hasta que se registren 10 personas
 */
namespace restaurant10TablesReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = new string[10];
            int arrayCurrentIndex = 0;
            bool userType;

            Console.WriteLine("Welcome to the best restaurant in the world!");
            while (arrayCurrentIndex < 10)
            {
                Console.WriteLine("\n\nAre you registered user? Write true, or write false to register");
                userType = Convert.ToBoolean(Console.ReadLine());
                if(userType == true)
                {
                    Console.WriteLine("Hello, you are a registered user, please enter your exact user name");
                    string userToSearch = Console.ReadLine();
                    Console.WriteLine("The user you searchead is {0}", userToSearch);
                    int index = Array.IndexOf(userNames, userToSearch);
                    if(index == -1)
                    {
                        Console.WriteLine("User not found, try again or register");
                    }
                    else
                    {
                        Console.WriteLine("Welcome {0} it's a pleasure to give you food", userNames[index]);
                    }
                }
                else if(userType == false)
                {
                    Console.WriteLine("Please write and remember your User name");
                    userNames[arrayCurrentIndex] = Console.ReadLine();
                    Console.WriteLine("Your User has been saved successfully\n" +
                        "Your user name is {0}", userNames[arrayCurrentIndex]);
                    arrayCurrentIndex++;
                }
            }
            Console.WriteLine("\nThe restaurant if full, try again next year\n These are the guests to the dinner: ");
            int auxIndex = 0;
            foreach(string element in userNames)
            {
                Console.WriteLine("User number {0} and user name: {1}", auxIndex+1, userNames[auxIndex]);
                auxIndex++;
            }
            Environment.Exit(0);
        }
    }
}

