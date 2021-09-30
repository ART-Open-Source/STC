using System;
using System.Net;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Simple Tool By Soud :)");
    var req = new WebClient();
    var res = req.DownloadString("https://soud.me/api/STC");
    Console.WriteLine($"STC Card: {res}");
    Console.ReadLine();
  }
}
