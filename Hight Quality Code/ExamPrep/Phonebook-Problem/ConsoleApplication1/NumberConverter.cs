namespace PhoneBook
{
    using System;
    using System.Linq;
    using System.Text;

    public class NumberConverter : INumberConverterStrategy
    {
        private const string BbCode = "+359";

        public string Convert(string number)
        {
            StringBuilder convertedNum = new StringBuilder();

            foreach (char character in number)
            {
                if (char.IsDigit(character) || (character == '+'))
                {
                    convertedNum.Append(character);
                }
            }

            if (convertedNum.Length >= 2 && convertedNum[0] == '0' && convertedNum[1] == '0')
            {
                convertedNum.Remove(0, 1);
                convertedNum[0] = '+';
            }

            while (convertedNum.Length > 0 && convertedNum[0] == '0')
            {
                convertedNum.Remove(0, 1);
            }

            if (convertedNum.Length > 0 && convertedNum[0] != '+')
            {
                convertedNum.Insert(0, BbCode);
            }

            return convertedNum.ToString();
        }
    }
}
