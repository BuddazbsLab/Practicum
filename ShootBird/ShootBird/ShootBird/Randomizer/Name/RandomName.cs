using System.Text;

namespace L.S.D.Randomizer.Name
{
    /// <summary>
    /// RandomName class, используется для генерации случайного имени.
    /// </summary>
    public class RandomName
    {
        private char[] vowels;
        private char[] consonants;

        public RandomName()
        {
            vowels = "aeuoyi".ToCharArray();
            consonants = "qwrtpsdfghjklzxcvbnm".ToCharArray();
        }

        public char[] Vowels => vowels;
        public char[] Consonants => consonants;

        public string Generate()
        {
            // создаём пустой ник, который будем заполнять
            StringBuilder newNick = new StringBuilder();
            Random random = new Random();
            int nameLen = random.Next(3, 7);
            // заполняем ник до тех пор, пока его длина меньше указанной
            while (newNick.Length < nameLen)
            {
                // генерируем слог из двух букв.

                // сначала выбираем случайно с гласной или согласной будет начинаться слог
                bool firstVowel = random.Next(0, 2) == 0 ? true : false;

                // выбираем случайные буквы из обеих массивов, начиная с гласной или согласной
                if (firstVowel)
                {
                    newNick.Append(vowels[random.Next(0, vowels.Length)]);
                    newNick.Append(consonants[random.Next(0, consonants.Length)]);
                }
                else
                {
                    newNick.Append(consonants[random.Next(0, consonants.Length)]);
                    newNick.Append(vowels[random.Next(0, vowels.Length)]);
                }
            }
            // коррекция длины имени. Так как составляли по слогам из двух букв,
            // и если длина имени должна быть нечётной, то убираем последнюю букву.
            if (nameLen % 2 != 0) newNick.Remove(newNick.Length - 1, 1);

            // первую букву ника делаем с заглавной буквы.
            newNick[0] = char.ToUpper(newNick[0]);
            return newNick.ToString();
        }
    }
}
