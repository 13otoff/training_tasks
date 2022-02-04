using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._1
{
    class MyString
    {

        private char[] myStr;

        public int L
        {
            get { return myStr.Length; }
            set
            {
                char[] temp = new char[value];

                if (value > myStr.Length)
                {
                    value = myStr.Length;
                }
                for (int i = 0; i < value; i++)
                {
                    temp[i] = myStr[i];
                    myStr = temp;
                }
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is MyString myStr) return L == myStr.L;
            return false;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
        public static bool operator ==(MyString s1, MyString s2)
        {
            if (s1.Equals(s2))
            {
                return true;
            }
            if (s1.myStr.Length != s2.myStr.Length)
            {
                return false;
            }
            for (int i = 0; i < s1.myStr.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool operator !=(MyString s1, MyString s2)
        {
            return !(s1 == s2);
        }

        public static explicit operator String(MyString myStr)
        {
            return new String(ToArray(myStr));
        }

        public static explicit operator MyString(String str)
        {
            return new MyString(ToMyString(str.ToCharArray()));
        }

        public static char[] ToArray(MyString myStr)
        {
            char[] res = new char[myStr.L];
            for (int i = 0; i < myStr.L; i++)
            {
                res[i] = myStr[i];
            }
            return res;
        }

        public static MyString ToMyString(char[] arr)
        {
            MyString res = new MyString(arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                res[i] = arr[i];
            }
            return res;
        }

        public MyString(String str)
        {
            myStr = new char[str.ToCharArray().Length];
            myStr = str.ToCharArray();
        }

        public MyString(int size)
        {
            myStr = new char[size];
        }

        public MyString(char[] arr)
        {
            myStr = new char[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                myStr[i] = arr[i];
            }
        }
        public MyString(MyString previousMyString)
        {
            if (this == previousMyString)
            {
                throw new ArgumentException("String cannot copy into itself!");
            }
            myStr = new char[previousMyString.myStr.Length];
            for (int i = 0; i < previousMyString.myStr.Length; i++)
            {
                myStr[i] = previousMyString.myStr[i];
            }
        }

        public char this[int index]
        {
            get
            {
                return myStr[index];
            }
            set
            {
                myStr[index] = value;
            }
        }

        public static MyString operator +(MyString myStr1, MyString myStr2)
        {
            int res = myStr1.L + myStr2.L;

            var sumstr = new MyString(res);

            for (int i = 0; i < myStr1.L; i++)
            {
                sumstr[i] = myStr1[i];
            }
            for (int i = 0; i < myStr2.L; i++)
            {
                sumstr[myStr1.L + i] = myStr2[i];
            }
            return sumstr;
        }

        public int FindSymbol(char symbol)
        {
            for (int i = 0; i < L; i++)
            {
                if (myStr[i] == symbol)
                {
                    return i;
                }
            }
            return -1;
        }


    }
}
