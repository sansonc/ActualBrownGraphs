using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World! " + ConcatName("Sanson", "Cruz") + " is Here!");
  }

  private static string ConcatName(string firstname, string lastname) {
    return firstname + " " + lastname;
  }
}