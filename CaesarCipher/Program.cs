using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            /* ------ Prepare for Encryption ------ */

            Console.WriteLine("Provide message to encrypt.");
            string message = Console.ReadLine().ToLower();

            // convert to an array:
            char[] msgArr = message.ToCharArray();

            // create new empty arr (same length as message)
            char[] encryptedMessage = new char[message.Length];


            /* ------ Encrypt ------ */

            for(int i = 0; i < message.Length; i++)
            {
                char letter = msgArr[i];
                int index = Array.IndexOf(alphabet, letter);
                int encryptedIndex = (index + 3) % alphabet.Length;  // moving index by 3 to the right in alphabet.

                char encryptedChar = alphabet[encryptedIndex];
                encryptedMessage[i] = encryptedChar;
            }

            /*------ Test and improve ------ */

            string encryptedString = String.Join("", encryptedMessage);
            Console.WriteLine($"Your encrypted message is: {encryptedString}");


        }
    }
}
