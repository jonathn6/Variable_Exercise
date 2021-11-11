using System;
using System.Collections.Generic;
using System.Text;

namespace Variable_Exercise
{
    public class MongoDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from a Mongo database");
        }
        public void SaveData()
        {
            Console.WriteLine("I am saving data to a Mongo database");
        }
    }
}
