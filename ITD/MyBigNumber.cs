using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITD
{
    class MyBigNumber
    {
        String s1;

        public String S1
        {
            get { return s1; }
            set
            {
                s1 = value;
            }
        }
        String s2;

        public String S2
        {
            get { return s2; }
            set { s2 = value; }
        }
        public MyBigNumber(String str1, String str2)
        {
            this.S1 = str1;
            this.S2 = str2;
        }
        // Hàm này sẽ đưa chuỗi có độ dài nhỏ về độ dài của chuỗi lớn: ví dụ: str1 = "123" str2 = "4" => kết quả : "123" và "004"
        void formatString()
        {
            int length = 0;
            string result = "";
            if (s2.Length < s1.Length)
            {
                length = s1.Length;
                for (int i = length - s2.Length; i >= 1; i--)
                {
                    result += '0';
                }
                result += s2;
                s2 = result;
            }
            else
            {
                length = s2.Length;
                for (int i = length - s1.Length; i >= 1; i--)
                {
                    result += '0';
                }
                result += s1;
                s1 = result;
            }
        }
        //Hàm tính tổng
        public String sum()
        {
            formatString();// Chỉnh lại format
            int length = s1.Length; //Lấy độ dài
            string result = ""; // biến kết quả
            int memory = 0;// lưu trữ cho phép toán nhớ 1, 19 + 4 = 13 nhớ 1 
            for (int i = length - 1; i >= 0; i--) //Vòng lặp, lặp từ phần tử cuối của chuỗi
            {

                int temp = s1[i] + s2[i] - 96; // ~ s1[i] - 48 + s2[i] - 48  (trên bảng mã ascii): ví dụ: s1[i] = '7' = 55(dec) => int i = 55-48 = 7 (dec) 
                int temp2 = temp + memory;// Nếu phép tính trước đó có dư sẽ cộng thêm 1  (*)
                if (temp2 >= 10)// Nếu kết quả phép toán cộng lại lớn hơn 10 thì sẽ nhớ 1: vi du: temp2 = 14
                {
                    temp2 -= 10;// temp =4
                    memory = 1; // lưu trữ nhớ một, nhớ này sẽ được cộng ở (*) cho phép tính tiếp theo
                    result += temp2;// "4"
                    if (i == 0 && memory == 1)//trường hợp 299 + 1 = 300 // nhớ một ở đầu chuỗi
                        result += temp2 + memory;
                    continue;
                }
                else
                {
                    result += temp + memory;
                    memory = 0;// memory = 0
                }
                
            }
            return reverseString(result);// đảo ngược lại chuỗi để có kết quả
        }
        //Hàm đảo chuỗi
        private String reverseString(String str1)
        {
            string kq = "";
            int dodai = str1.Length;
            for (int i = dodai - 1; i >= 0; i--)
            {
                kq += str1[i];
            }
            return kq;
        }
    }
}
