using System.Linq;

namespace CodingProblem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(ReverseString("Hello, World!"));

        }

        public static Boolean IsLetter(char character)
        {
            return character >= 'a' && character <= 'z' || character >= 'A' && character <= 'Z';
        }

        public static String ReverseString(string input)
        {
            //Split input string to words
            var words = input.Split(' ');
            List<String> updatedWords = new List<string>();

            foreach (var word in words)
            {
                //Split words to chars, check if its a alphanumeric
                char[] str = word.ToCharArray();
                var i = 0;
                var j = str.Length - 1;
                while (i < j)
                {
                    if (!IsLetter(str[i]))
                    {
                        ++i;
                    }
                    if (!IsLetter(str[j]))
                    {
                        --j;
                    }
                    if (IsLetter(str[i]) && IsLetter(str[j]))
                    {
                        var tempChar = str[i];
                        str[i] = str[j];
                        str[j] = tempChar;
                        ++i;
                        --j;
                    }
                }
                //Add updated words to result list
                updatedWords.Add(string.Join("", str));
            }
            return string.Join(" ", updatedWords);
        }

    }
}