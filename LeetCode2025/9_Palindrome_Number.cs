using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode2025
{
    public class _9_Palindrome_Number
    {
        public static bool IsPalindrome2(int x)
        {
            int number = x;
            int revert = 0;
            while (number > 0)
            {
                revert = (revert * 10)+number%10;
                number = number/10;
            }
            return revert == x;
        }
    }
}
