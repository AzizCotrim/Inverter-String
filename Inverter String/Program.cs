using System;

namespace Inverter_String {
    internal class Program {
        static void Main(string[] args) {
            string originalString = "Hello, world!";

            string invertedString = InvertString(originalString);

            Console.WriteLine("String original: " + originalString);
            Console.WriteLine("String invertida: " + invertedString);
            Console.ReadLine();

        }
        static string InvertString(string str) {
            char[] charArray = str.ToCharArray();

            int end = charArray.Length - 1;

            for (int i = 0; i < charArray.Length / 2; i++) {
                char temp = charArray[i];

                charArray[i] = charArray[end - i];

                charArray[end - i] = temp;
            }

            return new string(charArray);
        }
    }
}
