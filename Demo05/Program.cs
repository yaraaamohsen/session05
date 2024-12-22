using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Demo05
{
    // 0 -> 255
    enum Season
    {
        Spring, // 0
        Winter, // 1
        Summer, // 2
        Autumn  // 3
    }

    enum Gender
    {
        M = 100,
        F // By default dah hyb2a 101
    }

    // Read, Write, Delete, Excute
    enum Permissions
    {
        Read, 
        Write,
        Delete,
        Excute
    }
    internal class Program
    {
        static void DoSomeCode()
        {
            try
            {
                int X, Y, Z;
                X = int.Parse(Console.ReadLine());
                Y = int.Parse(Console.ReadLine());
                Z = X / Y;
                int[] arr = { 1, 2, 3 };
                arr[99] = 10;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // kda kda hytnfz
                Console.WriteLine("Finally");
                // Release || Deallocate || Disconnect || Dispose Unmanaged Resource
            }
        }

        static void DoSomeProtectiveCode()
        {
            try
            {
                int X, Y, Z;
                bool Flag;
                do
                {
                    Console.WriteLine("Enter Firsst Number: ");
                    Flag = int.TryParse(Console.ReadLine(), out X);
                }
                while (Flag == false);
                do
                {
                    Console.WriteLine("Enter Second Number: ");
                    Flag = int.TryParse(Console.ReadLine(), out Y);
                }
                while (Flag == false || Y == 0);

                Z = X / Y;
                int[] arr = { 1, 2, 3 };
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }
           
            
        }

        static void Main(string[] args)
        {
            #region Boxing And Unboxing
            //// Boxing And Unboxing

            //// Boxing: Casting From ValueType To ReferenceType
            //// Unboxing: Casting From ReferenceType To ValueType

            //object O1;
            //// O1 => Can Refer TO Instance Object Of "Object" Or Any Instance Of Any Type

            //O1 = 1;
            //O1 = "Ahmed";

            //O1 = 3;               // Cast From ValueType[int] To ReferenceType[object] => Boxing
            //O1 = 1.5;             // Cast From ValueType[double] To ReferenceType[object] => Boxing
            //O1 = 'A';             // Cast From ValueType[char] To ReferenceType[object] => Boxing
            //O1 = false;           // Cast From ValueType[Bool] To ReferenceType[object] => Boxing
            //O1 = new DateTime();  // Cast From ValueType[DateTime] To ReferenceType[object] => Boxing

            //int X = 5;
            //object O1 = /*(object)*/ X;

            //// Implicit Casting
            //// Safe Casting
            //// Parent = Child => Child Is Parent
            //// Animal = Dog => Dog Is Animal

            //object O1 = 3;

            //int X = O1;
            //// Unboxing
            //// Explicit Casting
            //// Unsafe Casting
            //// Dog = (Dog) Animal => Animal Is A Dog 
            #endregion

            #region Nullable ValueType
            // Nullable Types

            // Value Type
            // Reference Type

            //int X = 66;
            //X = null; // Not Value


            // Nullable Value Type : Allow Null As A Valid Value

            //// Nullable<int> : Allow Int Value Or Null As A Valid Value
            //int? Age = 3;
            //Age = null;

            //// Nullable<double> : Allow Int Value Or Null As A Valid Value
            //double? Salary = 2000.4;
            //Salary = null;

            //int X = 5;

            //// Y : Nullable<int>
            //// Y : Allow Int Or Null

            //int? Y = X;
            //// Implicit Cassting
            //// Safe Casting

            //int? X = 5;
            // Y : Nullable<int>
            // Y : Allow Int Or Null

            //int Y = (int)X;
            // Explicit Casting
            // Unsafe Casting
            // May Throw Exception


            // Defensive Code
            //if(X != null)
            //    Y = (int)X;
            //else
            //    Y = 0;

            //if (X.HasValue)
            //    Y = X.Value;
            //else
            //    Y = 0;

            //Y = X.HasValue? X.Value: 0;

            //Y = X is not null ? X.Value : 0;

            #endregion

            #region Null Coleasing Operator
            // Null Coleasing Operator ??
            //Y = X ?? 0; // Syntax Sugar for (Y = X is not null ? X.Value : 0;)
            // If X Is Not Null Take The Value, Else Y = 0 
            //Console.WriteLine(Y); 

            #endregion

            #region Nullable ReferenceType
            // Nullable ReferenceType [C# 10.0 .Net 6.0]
            // => referenceType DEfault Value is Null, So its Allow null

            string Message01 = "Ahmed";
            Message01 = null; // For Compiler Is Required
            string? Message02 = null; // For Compiler Is Nullable (Optional In Client Side)
            #endregion

            #region Null Propagation Operator
            // Null Propagation Operator ?

            //double X = default; // 0
            //char C = default; // null - space
            //bool Y = default; // False
            //int[] arr = default; // null
            //// Ay Reference Type default value = Null

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(i);
            //} // Throw Exception As It Null.Length

            //for (int i = 0; arr is not null && i < arr.Length; i++)
            //{
            //    Console.WriteLine(i);
            //} // zy elfol

            //// For Syntax Sugar (Best Practice)
            //if(arr is not null)
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for (int i = 0; i < arr?.Length; i++) // check if arr null or not
            //{
            //    Console.WriteLine(i);
            //}

            // select * from Employee E
            // E?.name // hena Htdene null msh ht-Throw Error

            //int Len = arr is not null? arr.Length : 0;
            //int? Len = arr?.Length; 
            #endregion

            #region Exception Handling And Protective Code
            // Exception Handling And Protective Code

            //DoSomeProtectiveCode();

            // Exceptions
            // 1. System Exception
            //  1.1. Format Exception
            //  1.2. IndexOutOf Exception
            //  1.3. NullReference Exception
            //  1.4. Arthimatic Exception
            //      1.4.1. OverFlow Excepion
            //      1.4.2. DividByZero Excepion

            // 2. Application Exception 
            #endregion

            #region Enum Ex01
            //// Class Library
            //// Enum : Value Type
            //// STACK

            //int Number = 18;
            //Season S01 = Season.Spring;
            //Console.WriteLine(S01);

            //// CLR represent ENUM as Integer in Memory (Stack)

            ////Gender G01 = (Gender) 1;
            //Gender G01;
            ////Console.WriteLine(G01);
            ////Gender G01 = (Gender) Enum.Parse(typeof(Gender), Console.ReadLine(), true); // true Ignore Case Sensitivity
            //Enum.TryParse(typeof(Gender), Console.ReadLine(), true, out object O1);
            //G01 = (Gender)O1;
            //Console.WriteLine(G01); 
            #endregion

            #region Enum Ex02
            //Permissions Per01 = Permissions.Read;
            ////Per01 ^= Permissions.Delete; // Toggle

            ////Console.WriteLine(Per01);

            ////Per01 |= Permissions.Delete; // Add Permission

            ////Console.WriteLine(Per01);

            //Per01 &= ~(Permissions.Delete); // ~ Not Bitwise
            //Console.WriteLine(Per01); // Delete Permission 

            //if( (Per01&Permissions.Delete) == Permissions.Delete)
            //{
            //    Console.WriteLine("Exist");
            //}
            //else
            //{
            //    Console.WriteLine("Not Exist");
            //} 

            /*
             & => Bitwise AND
             | => Bitwise OR
             ^ => Bitwise XOR
             ~ => Bitwise NOT
             << => Bitwise Left Shift
             >> => Bitwise Right Shift
             */
            #endregion

        }
    }
}
