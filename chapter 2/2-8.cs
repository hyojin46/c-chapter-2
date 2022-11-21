//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace chapter_2
//{
//    internal class _2_8
//    {
//        static void Main()
//        {
//            string y;
//            int year;
//            Console.WriteLine("연도를 입력하세요: "); 
//            y = Console.ReadLine(); //ReadLine()은 문자열을 입력받는 함수
//            year = Convert.ToInt32(y); //문자열 형태인 y를 정수형으로 변환

//            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) //윤년일 경우는 4의 배수면서 100의 배수가 아닐때 또는 400의 배수일 때다.
//                Console.WriteLine(year + "연도는 윤년입니다.");
            
//            else //윤년이 아닐경우
//                Console.WriteLine(+ year +"연도는 윤년이 아닙니다."); 
//        }
//    }
//}
