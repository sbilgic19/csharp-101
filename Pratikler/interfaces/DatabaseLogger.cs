using System;

namespace interfaces
{
    class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Database'e yazar.");
        }
        
    }


}