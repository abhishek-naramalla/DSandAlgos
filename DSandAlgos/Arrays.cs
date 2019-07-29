using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlogrithms
{
    public class Arrays
    {
        //  private int i;
        private int j = 0;

        public string stringReverse(string sample)
        {
            // char[] stringChar = sample.ToCharArray();
            string reverse = string.Empty;
            // for (int i = 0,  j = sample.Length - 1; i <= j; i++, j--)          
            for (int i = sample.Length - 1; i >= 0; i--)
            {
                reverse = reverse + sample[i];

            }

            // for(in)
            return reverse;
        }

        public bool isPolindrome(string sample)
        {
            for (int i = 0, j = sample.Length - 1; i <= j; i++, j--)
            {
                if (sample[i] != sample[j])
                {
                    return false;
                }
            }
            return true;
        }

        //public string ReverseWords(string str)
        //{
        //    StringBuilder output = new StringBuilder();
        //    List<char> charlist = new List<char>();

        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (str[i] == ' ' || i == str.Length - 1)
        //        {
        //            if (i == str.Length - 1)
        //                charlist.Add(str[i]);
        //            for (int j = charlist.Count - 1; j >= 0; j--)
        //                output.Append(charlist[j]);

        //            output.Append(' ');
        //            charlist = new List<char>();
        //        }
        //        else
        //            charlist.Add(str[i]);
        //    }
        //    return output.ToString();
        //}

        public string ReverseString(string sample)
        {
            StringBuilder sb = new StringBuilder();
            List<char> part = new List<char>();
            for (int i = 0; i < sample.Length; i++)
            {
                if (sample[i] == ' ' || i == sample.Length - 1)
                {
                    if (i == sample.Length - 1)
                        part.Add(sample[i]);
                    for (int j = part.Count - 1; j >= 0; j--)
                    {
                        sb.Append(part[j]);
                    }
                    sb.Append(' ');
                    part = new List<char>();
                }
                else
                {
                    part.Add(sample[i]);
                }
            }
            return sb.ToString();

        }

        public void CharaterCountInString(string sample)
        {
            var dictionary = new Dictionary<char, int>();

            foreach (var c in sample)
            {
                if (c != ' ')
                {
                    if (!dictionary.ContainsKey(c))
                    {
                        dictionary.Add(c, 1);
                    }
                    else
                    {
                        dictionary[c]++;
                    }

                }

            }
            foreach (var c in dictionary)
            {

            }
        }

        public string RemoveDuplicates(string sample)
        {
            var finalString = string.Empty;
            for (int i = 0; i < sample.Length; i++)
            {
                if (!finalString.Contains(sample[i]))
                {
                    finalString += sample[i];
                }
            }

            return finalString;
        }
        public string findallsubstring(string str)
        {
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);
                for (int j = i; j < str.Length; ++j)
                {
                    subString.Append(str[j]);
                    // Console.Write(subString + " ");
                }
                s.Append(subString);
            }
            return s.ToString();
        }


        public void RotateLeft(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                var temp = array[array.Length - 1];
                array[array.Length - 1] = array[i - 1];
                array[i - 1] = temp;
            }
        }


        public bool FindPrime(int number)
        {
            int m = number / 2;
            for (int i = 2; i <= m; i++)
            {
                if (number % i == 0)
                {
                    return false;

                }
            }

            return true;
        }

        public void SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine(sum);
        }
        public int FindSecondLargeInArray(int[] arr)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;

            foreach (int i in arr)
            {
                if (i > max1)
                {
                    max2 = max1;
                    max1 = i;
                }
                else if (i > max2)
                {
                    max2 = i;
                }
            }
            return max2;
        }

        public void FindthirdLargeInArray(int[] arr)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;

            foreach (int i in arr)
            {
                if (i > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = i;
                }
                else if (i > max2)
                {
                    max3 = max2;
                    max2 = i;
                }
                else if (i > max3)
                {
                    max3 = i;
                }
            }
            Console.WriteLine(max3); ;
        }

        public void MultiToSingle(int[,] array)
        {
            int index = 0;
            int width = array.GetLength(0);
            int height = array.GetLength(1);
            int[] single = new int[width * height];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    single[index] = array[x, y];
                    Console.Write(single[index] + " ");
                    index++;
                }
            }
        }


        public int GetMajarityElement(int[] a)
        {

            Dictionary<int, int> dict = new Dictionary<int, int>();

            int majority = a.Length / 2;

            foreach (int i in a)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                    if (dict[i] > majority)
                    {
                        return dict[i];
                    }
                }
                else
                {
                    dict.Add(i, 1);
                }
            }
            throw new Exception("No majority element in array");


        }

        public  bool isAnagram(String s, String t)
        {
            if (s.Length != t.Length)
                return false;

            for (int i = 0; i < t.Length; i++)
            {
                var n = s.IndexOf(t[i]);
                if (n < 0)
                    return false;
                s = s.Remove(n, 1);
            }
            return String.IsNullOrEmpty(s);
        }

        public bool TwoIntegersSumToTarget(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = 0; k < arr.Length; k++)
                {
                   // if (i != k)
                    //{
                        int sum = arr[i] + arr[k];
                        if (sum == target)
                            return true;
                    //}
                }
            }
            return false;
        }

        public string RemoveDuplicateChars(string key)
        {
            // --- Removes duplicate chars using string concats. ---
            // Store encountered letters in this string.
            string table = "";

            // Store the result in this string.
            string result = "";

            // Loop over each character.
            foreach (char value in key)
            {
                // See if character is in the table.
                if (table.IndexOf(value) == -1)
                {
                    // Append to the table and the result.
                    table += value;
                    result += value;
                }
            }
            return result;
        }
        public int sumRecursive(int num)
        {
            if (num != 0)
            {
                return (num % 10 + sumRecursive(num / 10));
            }
            else
            {
                return 0;
            }
        }

        public static void mergeArrays(int[] arr1, int[] arr2,
                                   int[] arr3)
        {
            int i = 0, j = 0, k = 0;

            // Traverse both array 
            while (i < arr1.Length && j < arr2.Length)
            {
                // Check if current element  
                // of first array is smaller 
                // than current element 
                // of second array. If yes,  
                // store first array element  
                // and increment first array 
                // index. Otherwise do same  
                // with second array 
                if (arr1[i] < arr2[j])
                    arr3[k++] = arr1[i++];
                else
                    arr3[k++] = arr2[j++];
            }

            // Store remaining  
            // elements of first array 
            while (i < arr1.Length)
                arr3[k++] = arr1[i++];

            // Store remaining elements 
            // of second array 
            while (j < arr2.Length)
                arr3[k++] = arr2[j++];
        }

        public static void MinMaxSwap2(int[] x)
        {
            int min = 0;
            int max = 0;

            for(int i = 1; i < x.Length; i++)
            {
                if (x[i] < x[min])
                {
                    min = i;
                }
                if (x[i] > x[max])
                {
                    max = i;
                }
                //swap now with temp
                int temp = x[min];
                x[min] = x[max];
                x[max] = temp;
            }
        }
    }
}
