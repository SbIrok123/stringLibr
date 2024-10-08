using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringLibr
{
    public class MyString
    {
        public char[] str { get; set; }
        public int length { get; }
        public MyString(char[] str)
        {
            this.str = str;
        }

        public char StartWith() => str[0];
        public char EndWith() => str[str.Length - 1];
        public char[] Substring(int startIndex, int endIndex)
        {
            char[] result = new char[endIndex - startIndex + 1];
            Array.Copy(str, startIndex, result, 0, endIndex - startIndex + 1);
            return result;
        }

        public void Remove(int startIndex, int endIndex)
        {
            char[] result = new char[str.Length - (endIndex - startIndex + 1)];
            Array.Copy(str, 0, result, 0, startIndex);
            Array.Copy(str, endIndex + 1, result, startIndex, str.Length - endIndex - 1);
            str = result;
        }
        public void RemoveAll()
        {
            str = new char[0];
        }
        public int IndexOf(char search)
        {
            for (int i = 0;i<str.Length;i++)
            {
                if (str[i] == search)
                {
                    return i;
                }
            }
            return 0;
        }
        public void Concat(char[] str1, char[] str2)
        {
            char[] result = new char[str1.Length + str2.Length];
            Array.Copy(str1, 0, result, 0, str1.Length);
            Array.Copy(str2, 0, result, str1.Length, str2.Length);
            this.str = result;
        }
        public void Replace(char[] newValue)
        {
            str = new char[newValue.Length];
            Array.Copy(newValue, str, newValue.Length);
        }
        public void Replace(char[] oldValue, char[] newValue)
        {
            Array.Clear(oldValue,0,oldValue.Length);
            oldValue = new char[newValue.Length];
            Array.Copy(newValue,oldValue,newValue.Length);
        }
        public void Trim(char ch)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    char[] result = new char[str.Length - 1];
                    Array.Clear(str, i, 1);
                }
            }
        }
        public bool CompareTo(char[] str1, char[] str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }
            for(int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
