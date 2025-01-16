using System;

public class Calculator
{
  
  private static int num1 = 0;
  private static int num2 = 0;
  
  public static void Main(string[] args)
  {
    printMessages();
    Console.WriteLine("Type a first number and enter");
    num1 = toInt(Console.ReadLine());
    Console.WriteLine("Type a first number and enter");
    num2 = toInt(Console.ReadLine());
    printOptions();
  }
  
  private static int getValue(string entry) {
    switch (entry)
    {
      case Keys.SUM:
        return num1 + num2;
      case Keys.SUBTRACT:
        return num1 - num2;
      case Keys.MULTIPLY:
        return num1 * num2;
      case Keys.DIVIDE:
        return nonZero(num1) / nonZero(num2);
      default:
        throw new ArgumentException("Invalid entry");
    }
  }
  
  private static string getSymbol(string entry) {
    switch (entry)
    {
      case Keys.SUM:
        return "+";
      case Keys.SUBTRACT:
        return "-";
      case Keys.MULTIPLY:
        return "*";
      case Keys.DIVIDE:
        return "/";
      default:
        throw new ArgumentException("Invalid entry");
    }
  }
  
  private static void printMessages()
  {
    Console.WriteLine("-------------- Calculator Brazil Goated\r");
    Console.WriteLine("--------------\n");
  }
  
  private static void printOptions()
  {
    Console.WriteLine("Choose an option from the list:");
    Console.WriteLine($"\t{Keys.SUM} - Sum"); 
    Console.WriteLine($"\t{Keys.SUBTRACT} - Subtract");
    Console.WriteLine($"\t{Keys.MULTIPLY} - Multiply");
    Console.WriteLine($"\t{Keys.DIVIDE} - Divide");
    Console.Write("your option? ");
    var entry = Console.ReadLine();
    Console.WriteLine($"Your result: {num1} " + getSymbol(entry) + " " + num2 + " = " + getValue(entry));
  }
  
  public static int toInt(string v)
  {
    if (int.TryParse(v, out int value))
    {
      return Convert.ToInt32(v);
    }
    return 1; // return 1, because 0 crashe's if is divide operation
  }
  
  public static int nonZero(int input) 
  {
    if (input == 0) return 1;
    return input;
  }
  
  private static class Keys
  {
    public const string SUM = "a";
    public const string SUBTRACT = "s";
    public const string MULTIPLY = "m";
    public const string DIVIDE = "d";
  }
}