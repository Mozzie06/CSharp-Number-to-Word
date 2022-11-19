using System;

namespace SoloLearn {

  class Program {

  

    static void Main(string[] args) {

    

      string[] units = {

        "",

        "ONE",

        "TWO",

        "THREE",

        "FOUR",

        "FIVE",

        "SIX",

        "SEVEN",

        "EIGHT",

        "NINE",

        "TEN",

        "ELEVEN",

        "TWELVE",

        "THIRTEEN",

        "FOURTEEN",

        "FIFTEEN",

        "SIXTEEN",

        "SEVENTEEN",

        "EIGHTEEN",

        "NINETEEN"

      };

      string[] tens = {

        "",

        "",

        "TWENTY ",

        "THIRTY ",

        "FOURTY ",

        "FIFTY ",

        "SIXTY ",

        "SEVENTY ",

        "EIGHTY ",

        "NINETY "

      };

      string word = "";

      int amount = int.Parse(Console.ReadLine());

      

      if (amount >= 1 && amount <= 1000) {

        if (amount / 1000 == 1) {

          word += units[amount / 1000] + " THOUSAND";

          amount %= 1000;

        }

        if (amount / 100 > 0) {

          word += units[amount / 100] + " HUNDRED";

          if (amount % 100 != 0) {

            word += " ";

          }

          amount %= 100;

        }

        if (amount < 20) {

          word += units[amount];

        } else if (amount < 100) {

          word += tens[amount / 10];

        }

        if (amount < 100 && amount > 20) {

          word += units[amount % 10];

        }

        Console.WriteLine(word + " PESOS ONLY");

      } else {

        Console.WriteLine("Error");

      }

    }

  }

}
