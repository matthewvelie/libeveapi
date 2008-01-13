using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

using libeveapi;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            ResponseCache.Clear();
            ErrorList errorList = EveApi.GetErrorList();

            ResponseCache.SaveToFile("ResponseCache.xml");
            ResponseCache.Clear();
            ResponseCache.LoadFromFile("ResponseCache.xml");

            ErrorList cachedErrorList = ResponseCache.Get(errorList.Url) as ErrorList;
            Console.WriteLine(cachedErrorList.GetMessageForErrorCode("100"));
        }
    }
}
