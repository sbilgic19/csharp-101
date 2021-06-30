using System;

namespace interfaces
{
    class SmsLogger:ILogger
    {
        public void WriteLog(){
            Console.WriteLine("Sms olarak log yazar");
        }
    }


}