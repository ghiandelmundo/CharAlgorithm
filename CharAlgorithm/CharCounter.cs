using System.Linq;

namespace CharAlgorithm
{
    public class CharCounter
    {
        public CharCounter() { }

        public string SplitAndCount(string input)
        {
            string result = string.Empty;
            char[] chars = input.ToCharArray();
            int? count = 1;
            for(int i = 0; i < chars.Length; i++)
            {
                if ((i + 1 < chars.Length) && chars[i] == chars[i + 1])
                {
                    count++;
                }
                else
                {
                    result += string.Format("{0}{1}", chars[i], ((count > 1) ? count : null));
                    count = 1;
                }
            }
            return result;
        }
    }
}
