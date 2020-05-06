using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chinesezodiac
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] cz = { "원숭이", "닭", "개", "돼지", "쥐", "소", "호랑이", "토끼", "용", "뱀", "말", "양" };

            Console.Write("태어난 년도 입력 : ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(cz[year % 12]);
        }
    }
}
