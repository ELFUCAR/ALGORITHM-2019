
// C# code to create a Dictionary 
using System; 
using System.Collections.Generic; 
  
class GFG { 
  
    // Driver code 
    public static void Main() 
    { 
  
        // Create a new dictionary of 
        // strings, with string keys. 
        Dictionary<string, int> myDict =  new Dictionary<string, int>(); 
  
        // Adding key/value pairs in myDict 
        myDict.Add("İstanbul", 17070000); 
        myDict.Add("Ankara", 5545000); 
        myDict.Add("Sivas", 359259); 
        myDict.Add("Edirne", 411528); 
        myDict.Add("İzmir", 428000); 
        myDict.Add("Çanakkale", 540662); 
  
        // To get count of key/value pairs in myDict 
        Console.WriteLine("Total cities"+ 
              " in myDict are : " + myDict.Count); 
  
        // Displaying the key/value pairs in myDict 
        Console.WriteLine("\nThe key/value pairs"+ 
                           " in myDict are : "); 
  
        foreach(KeyValuePair<string, string> kvp in myDict) 
        { 
            Console.WriteLine("Key = {0}, Value = {1}", 
                              kvp.Key, kvp.Value); 
        } 
    } 
} 


