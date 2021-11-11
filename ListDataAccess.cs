using System;
using System.Collections.Generic;
using System.Text;

namespace Variable_Exercise
{
    public class ListDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from a List Data Access database");
        }
        public void SaveData()
        {
            Console.WriteLine("I am saving data to a List Data Access database");
        }
    }
}
