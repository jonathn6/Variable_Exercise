using System;
using System.Collections.Generic;
using System.Text;

namespace Variable_Exercise
{
    public class SQLDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from a SQL database");
        }
        public void SaveData()
        {
            Console.WriteLine("I am saving data to a SQL database");
        }
    }
}
