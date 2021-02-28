using System.Collections.Generic;

namespace KeyValue.GetValueFromKey
{
    public static class Data
    {
       public static List<KeyValuePair<string,string>> MyKeyValue()  
       {
           var data = new List<KeyValuePair<string,string>>();
           data.Add(new KeyValuePair<string,string>("Hey", "hi"));
           data.Add(new KeyValuePair<string,string>("I love you", "i love you too"));
           data.Add(new KeyValuePair<string,string>("what", "i dont know"));
           data.Add(new KeyValuePair<string,string>("go", "ok bye"));
           data.Add(new KeyValuePair<string,string>("welcome", "thanks"));
           data.Add(new KeyValuePair<string,string>("leave", "byee leaving"));
           data.Add(new KeyValuePair<string,string>("how are you", "good"));
           data.Add(new KeyValuePair<string,string>("i am alone", "fuck off"));
           data.Add(new KeyValuePair<string,string>("help", "get shit"));
           data.Add(new KeyValuePair<string,string>("man", "shit"));
           return data;
       }
    }
}