//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace chapter_2
//{
//    internal class _2_9
//    {
//        static void Main()
//        {
//            string su;
//            Console.WriteLine("일련의 정수를 입력하시오 : ");
//            su = Console.ReadLine(); //정수를 입력받음
//            int length = su.Length;

//            int[] int_su = new int[length]; //배열생성
//            int index = 0;

//            foreach(char i in su)//foreach: su배열을 처음부터 끝까지 반복할때마다 값을 i에 저장하는 메소드
//            {
//                int num = i - '0'; //su의 단어가 char데이터라서 int로 변환하면 아스키코드값이 나옴
//                int_su[index] = num; //배열에 값을 저장
//                index++;
//            }

//            int max = int_su[0];
//            for (int i = 0; i < length; i++)
//            {
//                if (max < int_su[i]) //max값이 기준이 되어 값을 비교
//                    max = int_su[i];
//            }

//            Console.WriteLine("결과 = " + max);
//        }
//    }
//}
