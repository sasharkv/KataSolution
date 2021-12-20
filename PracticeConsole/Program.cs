using System;

namespace PracticeConsole
{
    class Program
    {

        public static string ToCamelCase(string str)
        {
            string[] afterSplit = str.Split(new char[] { '_', '-' }, StringSplitOptions.RemoveEmptyEntries);

            string firstStrInList = afterSplit[0];
            char firstChar = firstStrInList[0];

            if (char.IsUpper(firstChar))
            {
                // Console.WriteLine("it's upper case");
                for (int i = 0; i < afterSplit.Length; i++)
                {
                    string thisString = afterSplit[i];
                    thisString = char.ToUpper(thisString[0]) + thisString.Substring(1).ToLower();
                    afterSplit[i] = thisString;
                }
            }
            else
            {
                // Console.WriteLine("it's lower case");
                for (int i = 1; i < afterSplit.Length; i++)
                {
                    string thisString = afterSplit[i];
                    thisString = char.ToUpper(thisString[0]) + thisString.Substring(1).ToLower();
                    afterSplit[i] = thisString;
                }
            }

            string afterSplitStr = string.Join("", afterSplit);
            return afterSplitStr;
        }
        static void Main(string[] args)
        {

            string testString = "The_stealth-waRrior";

            Console.WriteLine(ToCamelCase(testString));

        }
    }
}
