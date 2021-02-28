using System;

namespace KeyValue.GetValueFromKey
{
    public static class Greeter
    {
        public static string Greet()
        {
            int currentHour = DateTime.Now.Hour;
            if(currentHour<=12 && currentHour>=5)
            {
                return "Good Morning";
            }
             if(currentHour>=12)
             {
             return "Good Afternoon";
             }
              if(currentHour>=16)
             {
             return "Good Evening";
             }

            return "Good Night";
        }
        
    }
}