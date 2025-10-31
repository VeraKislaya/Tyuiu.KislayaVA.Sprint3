using System.Text;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KislayaVA.Sprint3.Task3.V29.Lib
{
    public class DataService : ISprint3Task3V29
    {
        public string DeleteCharInString(string value, char item)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in value)
            {
                if (c == item)
                {
                    value = value.Replace(item.ToString(), "");
                }
            }
            return value;
        }
    }
}
