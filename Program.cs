using System;
using System.Linq;

namespace KeyValue.GetValueFromKey
{
    class Program
    {
        static void Main(string[] args)
        {
            string input, name;
            A:
            name = AskName();
            bool s = IsNameValid(name);
            while(!s)
            {
            name = AskName(1);
            goto A;
            }


            System.Console.WriteLine("{1} {0} nice to meet you", name, Greeter.Greet());
            System.Console.WriteLine("Type something to chat, To end chat pease type END");
            bool isChatActive = true;
            while (isChatActive)
            {
                input = Console.ReadLine();
                if (input.ToLower() == "End".ToLower())
                {
                    System.Console.WriteLine("By Hope to see you soon");
                    isChatActive = false;
                }
                else
                {
                    System.Console.WriteLine(GetValue(input));
                }
            }

        }
        public static string GetValue(string key)
        {
           
            var data = Data.MyKeyValue();
           
            var value = data.FirstOrDefault(x => x.Key.ToLower().Contains(key.ToLower())).Value;
            if (value == null)
            {
                return "Sorry";
            }
            return value;
        }
        public static bool IsNameValid(string userName)
        {
            if (userName == null || userName.Length < 3)
            {
                return false;

            }
            else
            {
                return true;
            }

        }
        public static string AskName(int count=0)
        {
           
           
            if(count==1)
            {
            System.Console.WriteLine("Hy I didnt hear your name");
            string name2 = Console.ReadLine();
            return name2;
             
            }
            System.Console.WriteLine("Hy whats your name");
            string yourname = Console.ReadLine();
            return yourname;

        }
        
    }
}
