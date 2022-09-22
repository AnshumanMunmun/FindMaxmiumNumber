using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
    public class FindMaximumNumb
    {
        public int FindMaxIntNumber(int firstNum, int secondNum, int thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
                return firstNum;
            if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) > 0)
                return secondNum;
            else
                return thirdNum;
        }
        public float FindMaxFloatNumber(float firstNum, float secondNum, float thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
                return firstNum;
            if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) > 0)
                return secondNum;
            else
                return thirdNum;
        }
        public string FindMaxStringNumber(string firstString, string secondNum, string thirdNum)
        {
            if (firstString.CompareTo(secondNum) > 0 && firstString.CompareTo(thirdNum) > 0)
                return firstString;
            if (secondNum.CompareTo(firstString) > 0 && secondNum.CompareTo(thirdNum) > 0)
                return secondNum;
            else
                return thirdNum;
        }
    }
}
