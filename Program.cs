using System;
using System.Collections.Generic;
using System.Linq;

namespace practice_c_ {
  class Program {
    static void Main (string[] args) {

      Console.WriteLine (Pattern.Get_Pattern ("love", "live")); // ve
      Console.WriteLine (Pattern.Get_Pattern ("love", "elon")); // lo
      Console.WriteLine (Pattern.Get_Pattern ("hellooooo", "hello")); // hello
      Console.WriteLine (Pattern.Get_Pattern ("look", "tooklook")); // look
      Console.WriteLine (Pattern.Get_Pattern ("ok.ok", "ok.ok")); // ok.ok
      Console.WriteLine (Pattern.Get_Pattern ("dddkokokdle", "bokds")); // okd
      Console.WriteLine (Pattern.Get_Pattern ("ttd", "dottttk")); //tt

      for (int i = 0; i < 10; i++) {
        Console.Write (Util.TestFactor () + " "); // test favtoer is true
      }

      System.Console.WriteLine ();

      for (int i = 0; i < 10; i++) {
        Console.Write (Util.TestSellect () + " "); //test sellect number is true 
      }

      System.Console.WriteLine ();

      for (int i = 0; i < 10; i++) {
        Console.Write (Util.TestIsDigits () + " "); // test isdigit is true 
      }
      Console.WriteLine ();
      for (int i = 0; i < 10; i++) {
        Console.Write (Util.TestIsPattern () + " "); // true ..
      }

    }
  }

}