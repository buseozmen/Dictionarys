using System.Collections;

namespace Dictionarys
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string>  myDictionary = new MyDictionary<string>( );
            Console.WriteLine(myDictionary.Count);
            myDictionary.Add("a");
            Console.WriteLine(myDictionary.Count);
            myDictionary.Add("b");
            Console.WriteLine(myDictionary.Count);
            myDictionary.Add("c");
            Console.WriteLine(myDictionary.Count);
            myDictionary.Add("d");
            Console.WriteLine(myDictionary.Count);
            myDictionary.Add("e");
            Console.WriteLine(myDictionary.Count);
        }
    }
}