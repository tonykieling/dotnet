using System;
class Chal {
  static void Main(string[] args) {
    // string txt = "Rada'rX.";
    // string txt = "-Rada'r.";
    // string txt = "No 'X' in Nixon!";
    // string txt = "A man, a plan, a canal Panama!";
    // string txt = "Madam, I'm Adam!";
    string txt;
    while (1 == 1) {
      Console.Write("- Type your word, phrase, or sentence: ");
      txt = Console.ReadLine();

      if (txt == "exit") {
        Console.WriteLine("\t That's all, folks! 👋\n");
        break;
      }

      Console.WriteLine($" Checking for: \" {txt} \"" );

      (bool, int) result = isPalindrome(txt);
      Console.WriteLine("\tThe result is => Palindrome: {0}, Lenght: {1} {2}\n", result.Item1, result.Item2, result.Item2 > 0 ? "👌" : "👎");
    }
  }

  static (bool, int) isPalindrome(string str) {
    bool isPalindromeBool = false;

    // strip out any char but alfabetich ones + assembly the reverse string
    string newStr = "";
    string reversedString = "";

    foreach(char c in str) {
      if (((int)c >= 65) && ((int)c <= 122)) {
        newStr += c;
        reversedString = c + reversedString;
      }
    }

    // all lower case
    newStr = newStr.ToLower();
    reversedString = reversedString.ToLower();

    // reverse: did it on line 36
    
    // compare whether palindrome or not
    isPalindromeBool = newStr.Equals(reversedString);
    
    // return answer
    return (isPalindromeBool, isPalindromeBool ? str.Length : 0);
  }
}