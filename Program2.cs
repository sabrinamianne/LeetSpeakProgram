using System;

public class Program
{
  static void Main()
  {
    Console.WriteLine("H3ll0, w3lc0m3 70 L337 Sp3ak 7ranzla70r! 7yp3 a s3n73nc3 f0r m3 7o 7ranzla73: ");
    string UserInput = Console.ReadLine();
    char[]newArray = UserInput.ToCharArray();
    for (int i=0; i<newArray.Length; i++)
    {
      char let = newArray[i];
      if (let == 'e' || let == 'E')
      newArray[i]= '3';
      else if (let == 'o')
      newArray[i] = '0';
      else if (let == 't')
      newArray[i] = '7';
      else if (let == 'I')
      newArray[i] = '1';
    }
    for (int i= 0; i<newArray.Length; i++)
    {
      int indexS = newArray.IndexOf('s');
    }

    string result = new string (newArray);
    Console.WriteLine(result);
  }
}
