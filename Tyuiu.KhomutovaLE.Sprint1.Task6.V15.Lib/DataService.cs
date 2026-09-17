using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhomutovaLE.Sprint1.Task6.V15.Lib
{
    public class DataService : ISprint1Task6V15
    {
        public bool CheckLettersCount(string value)
        {
            value = value.Replace(",", "*");
            value = value.Replace(".", "*");
            value = value.Replace("!", "*");
            value = value.Replace("?", "*");
            int simb = 0;
            int text = 0;
            foreach (var i in value)
            {
                if (i == '*')
                {
                    simb++;
                }
                else
                {
                    text++;
                }
            }
            return text > simb;
        }
    }
}
