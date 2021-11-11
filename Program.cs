using System;

namespace Variable_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variable Exercise!");

            bool loopcontrol = false;
            string userInput = "";

            do
            {
                Console.Write("What type of database would you like to create (L)ist, (S)QL, or (M)ongo, or (E)xit? ");
                userInput = Console.ReadLine().ToUpper();

                if (userInput == "L" || userInput == "S" || userInput == "M")
                {
                    var dataBaseType = DataAccessFactory.GetDataAccessType(userInput);
                    dataBaseType.LoadData();
                    dataBaseType.SaveData();
                }
                else
                {
                    if (userInput == "E")
                    {
                        loopcontrol = true;
                    } else
                    {
                        Console.WriteLine("That is not a valid input.  Please try again.");
                    }
                }
            }
            while (!loopcontrol);

        }
    }
}
