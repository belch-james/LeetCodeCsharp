using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class InProgress
{
   
    
    public static int HeightChecker(int[] heights) {
        var sortedHeights = heights.OrderBy(height => height).ToList();
        var i = 0;
        var count = 0;
        while (i < heights.Length){
            if(heights[i] != sortedHeights[i]){
                count++;
            }
            i++;
        }
        return count;
    }

    public static int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
    {
        int matches = 0;
        foreach (var item in items)
        {
            switch (ruleKey)
            {
                case "type":
                    {
                        if (item.Contains(ruleValue))
                        {
                            matches++;
                        }
                        break;
                    }
                case "color":
                    {
                        if (item.Contains(ruleValue))
                        {
                            matches++;
                        }
                        break;
                    }
                case "name":
                    {
                        if (item.Contains(ruleValue))
                        {
                            matches++;
                        }
                        break;
                    }
            }

        }
        return matches;
    }

    public static int[] TwoSum(int[] nums, int target)
    {
        int[] returnNums = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    returnNums[0] = i;
                    returnNums[1] = j;
                }
            }
        }
        return returnNums;
    }
}