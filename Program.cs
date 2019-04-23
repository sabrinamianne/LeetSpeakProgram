using System;

public class Program
{
  public static char Translate(char newArray)
  {
    foreach (char letter in newArray)
    {
      if (letter == 'e')
      {
        return '3';
      }

    }
    string result = string.Join("", array);
    Console.WriteLine(result);
  }

  public static void Main()
  {
    Console.WriteLine("Welc0m3 70 L337 Zp3ak! 3n73r a Z7ring: ");
    string userInput = Console.ReadLine();
    char[] newArray = userInput.ToCharArray();

    Translate(newArray);
    
  }
  
}

