using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dictionarys
{
    public class MyDictionary<T>
    {
        T[] myDictionary;
        T[] tempArray;
        public MyDictionary() 
        {
            myDictionary = new T[0];
        }       
        public void Add(T item)
        {
            tempArray = myDictionary;
            myDictionary = new T[myDictionary.Length+1];
            for(int i = 0; i < tempArray.Length; i++)
            {
                myDictionary[i] = tempArray[i];
            }
            myDictionary[myDictionary.Length-1] = item;
        }
        
        public int Count
        {
            get {  return myDictionary.Length;  }
        }
    }
}
