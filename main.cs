using System;
using System.Diagnostics;

class MainClass {
  public static void Main (string[] args) {


Console.WriteLine ("Enter an integer: ");
    int decimalValue = 0;
    
    int i = 0;
    decimalValue = Convert.ToInt32(Console.ReadLine());
    
    string binaryValue = "";

    
    while(decimalValue > 0)
    {
      if(decimalValue % 2 == 0)
      {
        binaryValue += 0;
      }
      else if(decimalValue % 2 != 0)
      {
        binaryValue += 1;
      }

      
      decimalValue /= 2;

    }

char[] array = binaryValue.ToCharArray();
        Array.Reverse(array);
        
  
  Console.WriteLine(array);
  
  

  }


}

