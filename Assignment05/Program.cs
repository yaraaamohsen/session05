using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;

namespace Assignment05
{
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum Season
    {
        Spring,
        Summer,
        Winter,
        Autumn
    }

    [Flags]
    enum Permissions
    {
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }

    enum Colors
    {
        Red,
        Green,
        Blue
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //foreach (var day in Enum.GetValues(typeof(WeekDays)))
            // {
            //     Console.WriteLine(day);
            // }
            #endregion

            #region 2. Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            //string userInput = Console.ReadLine();

            //try
            //{
            //    Season Season = (Season)Enum.Parse(typeof(Season), userInput, true);

            //    if (Season == Season.Spring)
            //    {
            //        Console.WriteLine("Spring: March To May");
            //    }
            //    else if (Season == Season.Summer)
            //    {
            //        Console.WriteLine("Summer: June To August");
            //    }
            //    else if (Season == Season.Autumn)
            //    {
            //        Console.WriteLine("Autumn: September To November");
            //    }
            //    else if (Season == Season.Winter)
            //    {
            //        Console.WriteLine("Winter: December To February");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Season.");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            #endregion

            #region 3. Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            /*Create Variable from previous Enum to Add and Remove Permission from variable, 
            check if specific Permission is existed inside variable*/
            //Permissions userPermissions = new Permissions();

            //userPermissions |= Permissions.Read;
            //userPermissions |= Permissions.Write;
            //Console.WriteLine("After Adding Read nd Write: " + userPermissions);

            //Console.WriteLine("Has Write Permission: " + userPermissions.HasFlag(Permissions.Write));
            //Console.WriteLine("Has Execute Permission: " + userPermissions.HasFlag(Permissions.Execute));

            //userPermissions &= ~Permissions.Write;
            //Console.WriteLine("After Removing Write: " + userPermissions);

            //Console.WriteLine("Has Write Permission After Removal: " + userPermissions.HasFlag(Permissions.Write));
            #endregion

            #region 4. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //Console.WriteLine("Enter a color name:");
            //string userInput = Console.ReadLine();
            //try
            //{
            //    Colors Color = (Colors)Enum.Parse(typeof(Colors), userInput, true);

            //    if (Color == Colors.Red || Color == Colors.Green || Color == Colors.Blue)
            //    {
            //        Console.WriteLine($"{Color} is a primary color.");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            #endregion

        }
    }
}
