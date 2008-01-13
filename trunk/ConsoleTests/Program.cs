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
            Console.WriteLine(EveApi.ParseCCPTimestamp("0001-01-01 00:00:00"));
        }
    }
}
