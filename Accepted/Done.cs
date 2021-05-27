using System;
using System.Collections.Generic;
using System.Linq;

class Done
{

    public string DayOfTheWeek()
    {
        DateTimeOffset date = new DateTime(2019, 8, 17);
        return date.DayOfWeek.ToString();
    }
    public static int DaysBetweenDates(string date1, string date2)
    {
        DateTimeOffset dateOne = DateTimeOffset.Parse(date1);
        DateTimeOffset dateTwo = DateTimeOffset.Parse(date2);

        switch (dateOne.CompareTo(dateTwo))
        {
            case 1:
                {
                    var dateDiff = dateOne.Subtract(dateTwo);
                    return Convert.ToInt32(dateDiff.ToString().Split(".")[0]);
                }
            case 0:
                {
                    break;
                }
            case -1:
                {
                    var dateDiff = dateTwo.Subtract(dateOne);
                    return Convert.ToInt32(dateDiff.ToString().Split(".")[0]);
                }
        }
        return 0;
    }
    public static IEnumerable<int> GetDigits(int source)
    {
        while (source > 0)
        {
            var digit = source % 10;
            source /= 10;
            yield return digit;
        }
    }
    public static int SubtractProductAndSum(int n)
    {
        var digits = GetDigits(n).Reverse();
        int product = 1;
        int sum = 0;
        foreach (var digit in digits)
        {
            product *= digit;
            sum += digit;
        }
        return product - sum;
    }
    public static int FindNumbers(int[] nums)
    {
        var count = 0;
        foreach (var num in nums)
        {
            var stringNum = num.ToString();
            if (stringNum.Length % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
    private static string getStringAlpha(string input)
    {
        switch (input)
        {
            case "1":
                {
                    return "a";
                }
            case "2":
                {
                    return "b";
                }
            case "3":
                {
                    return "c";
                }
            case "4":
                {
                    return "d";
                }
            case "5":
                {
                    return "e";
                }
            case "6":
                {
                    return "f";
                }
            case "7":
                {
                    return "g";
                }
            case "8":
                {
                    return "h";
                }
            case "9":
                {
                    return "i";
                }
            case "10":
                {
                    return "j";
                }
            case "11":
                {
                    return "k";
                }
            case "12":
                {
                    return "l";
                }
            case "13":
                {
                    return "m";
                }
            case "14":
                {
                    return "n";
                }
            case "15":
                {
                    return "o";
                }
            case "16":
                {
                    return "p";
                }
            case "17":
                {
                    return "q";
                }
            case "18":
                {
                    return "r";
                }
            case "19":
                {
                    return "s";
                }
            case "20":
                {
                    return "t";
                }
            case "21":
                {
                    return "u";
                }
            case "22":
                {
                    return "v";
                }
            case "23":
                {
                    return "w";
                }
            case "24":
                {
                    return "x";
                }
            case "25":
                {
                    return "y";
                }
            case "26":
                {
                    return "z";
                }
            default: return "";
        }
    }
    public static string FreqAlphabets(string s)
    {
        string returnStr = "";
        int i = 0;
        try
        {
            while (i <= s.Length)
            {
                if (s[i + 2].Equals('#'))
                {
                    string doubleDigit = s[i].ToString() + s[i + 1].ToString();
                    returnStr += getStringAlpha(doubleDigit);
                    i += 3;
                }
                else
                {
                    returnStr += getStringAlpha(s[i].ToString());
                    i++;
                }
            }
        }
        catch (IndexOutOfRangeException)
        {

            if (i == s.Length - 1)
            {
                returnStr += getStringAlpha(s[i].ToString());
            }
            else if (i == s.Length - 2)
            {
                returnStr += getStringAlpha(s[i].ToString());
                returnStr += getStringAlpha(s[i + 1].ToString());
            }
        }
        return returnStr;
    }
    public static string DefangIPaddr(string address)
    {
        return address.Replace(".", "[.]");
    }
    public string TruncateSentence(string s, int k)
    {
        string[] splitstr = s.Split(" ");
        string returnStr = "";
        for (int i = 0; i < k; i++)
        {
            if (i < k - 1)
            {
                returnStr += splitstr[i] + " ";
            }
            else
            {
                returnStr += splitstr[i];
            }

        }
        return returnStr;
    }
    public bool CheckIfPangram(string sentence)
    {
        IDictionary<char, bool> foundDictionary = new Dictionary<char, bool>();
        foreach (var value in sentence)
        {
            if (!foundDictionary.ContainsKey(value))
            {
                foundDictionary.Add(value, true);
            }
        }
        return foundDictionary.Count == 26 ? true : false;
    }

    public static int[] SmallerNumbersThanCurrent(int[] nums)
    {
        var returnArray = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            var count = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                {
                    ++count;
                }
            }
            returnArray[i] = count;
        }
        return returnArray;
    }
    public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        string builtWord1 = "";
        string builtWord2 = "";
        if (word1.Length > 1)
        {
            foreach (var word in word1)
            {
                builtWord1 += word;
            }
        }
        else
        {
            builtWord1 = word1[0];
        }
        if (word2.Length > 1)
        {
            foreach (var word in word2)
            {
                builtWord2 += word;
            }
        }
        else
        {
            builtWord2 = word2[0];
        }
        if (builtWord1.Equals(builtWord2))
        {
            return true;
        }
        return false;
    }
    public static int NumIdenticalPairs(int[] nums)
    {
        IDictionary<int, int> numberOfPairs = new Dictionary<int, int>();

        foreach (var number in nums)
        {
            if (numberOfPairs.ContainsKey(number))
            {
                numberOfPairs[number]++;
            }
            else
            {
                numberOfPairs.Add(number, 1);
            }
        }
        var returnVal = 0;
        foreach (var value in numberOfPairs.Values)
        {
            var tempVal = value * (value - 1) / 2;
            returnVal += tempVal;
        }
        return returnVal;
    }
    public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        IList<bool> returnList = new List<bool>();
        var maxValue = candies.Max();
        foreach (var candy in candies)
        {
            returnList.Add(candy + extraCandies >= maxValue ? true : false);
        }
        return returnList;
    }
    static public int MaximumWealth(int[][] accounts)
    {
        int returnVal = 0;
        foreach (var account in accounts)
        {
            if (account.Length == 1)
            {
                returnVal = returnVal >= account[0] ? returnVal : account[0];
            }
            else
            {
                int[] returnSums = new int[account.Length];
                returnSums[0] = account[0];
                int accountSum = 0;
                for (int i = 1; i < account.Length; i++)
                {
                    accountSum = accountSum + returnSums[i - 1] + account[i];
                }
                returnVal = returnVal >= accountSum ? returnVal : accountSum;
            }

        }
        return returnVal;
    }
    public static int[] RunningSum(int[] nums)
    {
        int[] returnSums = new int[nums.Length];
        returnSums[0] = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            returnSums[i] = nums[i] + returnSums[i - 1];
        }
        return returnSums;
    }
}