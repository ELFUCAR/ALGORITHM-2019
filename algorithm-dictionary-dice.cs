/*************************************************************************
Dictionary Dice

**************************************************************************/

// C# code to create a Dictionary 
using System; 
using System.Collections.Generic; 
  
class GFG { 
  
    // Driver code 
    public static void Main() 
    { 
  
        // Create a new dictionary of 
        // strings, with string keys.
        
        Dictionary<int, int> Dice =  new Dictionary<int, int>(); 
  
  
        // Adding key/value pairs in myDict 
       for(int i=2;i<=12;i++)
       
       {
        Dice.Add(i, 0); 
       }
       
       
        int result,result2,result1;
       int numberOfThrows=1000000;
       Random rnd=new Random();
      
       
       
      for(int i=0;i<numberOfThrows;i++)
      {
           result1=rnd.Next(1,7);
           result2=rnd.Next(1,7);
           
            result=result1+result2;
            
           Dice[result]++;
          
      }
        
        // To get count of key/value pairs in myDict 
        Console.WriteLine("Total dices"+ 
              " in Dice are : " + Dice.Count); 
  
        // Displaying the key/value pairs in myDict 
        Console.WriteLine("\nThe Dice pairs"+ 
                           " in Dice are : "); 
  
        foreach(KeyValuePair<int, int> kvp in Dice) 
        { 
            Console.WriteLine("Dice = {0}, Value = {1}", 
                              kvp.Key, kvp.Value); 
        } 
    } 
} 

