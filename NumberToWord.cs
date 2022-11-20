// Bank Cheque Writer Program in C#

using System;

namespace BankChequeWriter {

  class Program {

    static void Main(string[] args) {

      //Declare units value to be based on when changing numeric value which is higher than 1 and lower than 20 to word

      const string[] units = {

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

      //Declare units value to be based on when changing numeric value which is tens to word

      const string[] tens = {

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

      //Declared for units and tens to be used

      string word = "";

      //Ask user for amounts

      double amounts = double.Parse(Console.ReadLine());

      //Convert amounts value to integer

      int amount = (int) amounts;

      //Gets the cent(decimal value) from amounts

      double cent = amounts - Math.Truncate(amounts);

      //Convert cent to whole number

      cent *= 100;

      //Remove cent decimal value

      string s = cent.ToString("N0");

      //Check if the amount is within the range of 1 and 1,000

      if (amount >= 1 && amount <= 1000) {

        //Check if the amount is one thousand add THOUSAND

        if (amount / 1000 == 1) {

          word += units[amount / 1000] + " THOUSAND";

          amount %= 1000;

        }

        //Check if the amount is higher 100 add the word HUNDRED

        if (amount / 100 > 0) {

          word += units[amount / 100] + " HUNDRED";

          //Check if the amount will have remainder when divided by 100

          if (amount % 100 != 0) {

            word += " ";

          }

          amount %= 100;

        }

        //Check if the amount is lower than 20

        if (amount < 20) {

          word += units[amount];

          //Check if the amount is lower than 100 and divisible by 10

        } else if (amount < 100) {

          word += tens[amount / 10];

        }

        //Check if the amount is lower than 100 and lower than 20

        if (amount < 100 && amount > 20) {

          word += units[amount % 10];

        }

        //Check if cent has value

        if (cent > 0) {

          //Print Amount with cents

          Console.Write(word + " AND " + s + "/100 ONLY");

        } else {

          //Print Whole Amount

          Console.WriteLine(word + " PESOS ONLY");

        }

      } else {

        //Print Error when amount value is below 1.00 and higher than 1,000.00

        Console.WriteLine("Error");

      }

    }

  }

}
