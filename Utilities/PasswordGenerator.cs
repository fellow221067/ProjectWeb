using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class PasswordGenerator
    {
        public static string GenerateRandomPassword(int length)
        {
            var lettersUpper = Enumerable
                .Range('A', 'Z' - 'A' + 1)
                .Select(x => (char)x);
            var lettersLower = Enumerable
                .Range('a', 'z' - 'a' + 1)
                .Select(x => (char)x);
            var numbers = Enumerable
                .Range('0', '9' - '0' + 1)
                .Select(x => (char)x);
            /*var specialCharacters = new[] { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '[', ']', '{', '}', ';', ':', ',', '.', '/', '<', '>', '?' };*/

            var key = lettersUpper
                .Union(lettersLower)
                .Union(numbers)
                /*.Union(specialCharacters)*/
                .ToArray();

            var random = new Random();
            var password = new char[length];
            for (int i = 0; i < length; i++)
            {
                password[i] = key[random.Next(key.Length)];
            }
            return new string(password);
        }
    }
}
