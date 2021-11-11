using System;
using System.Collections.Generic;
using System.Text;

namespace Variable_Exercise
{
    public class DataAccessFactory 
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch (databaseType)
            {
                case "L":
                    return new ListDataAccess();
                case "M":
                    return new MongoDataAccess();
                case "S":
                    return new SQLDataAccess();
            }
            return null;
        }
    }
}
