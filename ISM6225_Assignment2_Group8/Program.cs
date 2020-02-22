using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2_CT_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1");
            int[] l1 = new int[] { 5, 6, 6, 9, 9, 12 };
            int target = 9;
            int[] r = TargetRange(l1, target);
            // Write your code to print range r here
            Console.WriteLine("[{0}]", string.Join(", ", r));
            Console.WriteLine();
            Console.WriteLine("Question 2");
            string s = "University of South Florida";
            string rs = StringReverse(s);
            Console.WriteLine(rs);
            Console.WriteLine();
            Console.WriteLine("Question 3");
            int[] l2 = new int[] { 2, 2, 3, 5, 6 };
            int sum = MinimumSum(l2);
            Console.WriteLine(sum);
            Console.WriteLine();
            Console.WriteLine("Question 4");
            string s2 = "Dell";
            string sortedString = FreqSort(s2);
            Console.WriteLine(sortedString);
            Console.WriteLine();
            Console.WriteLine("Question 5-Part 1");
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };
            int[] intersect1 = Intersect1(nums1, nums2);
            Console.WriteLine("Part 1- Intersection of two arrays is: ");
            DisplayArray(intersect1);
            Console.WriteLine("\n");
            Console.WriteLine("Question 5-Part 2");
            int[] intersect2 = Intersect2(nums1, nums2);
            Console.WriteLine("Part 2- Intersection of two arrays is: ");
            DisplayArray(intersect2);
            Console.WriteLine("\n");
            Console.WriteLine();
            Console.WriteLine("Question 6");
            char[] arr = new char[] { 'a', 'g', 'h', 'a' };
            int k = 3;
            Console.WriteLine(ContainsDuplicate(arr, k));
            Console.WriteLine("Question 7");
            int rodLength = 4;
            int priceProduct = GoldRod(rodLength);
            Console.WriteLine(priceProduct);
            Console.WriteLine();
            Console.WriteLine("Question 8");
            string[] userDict = new string[] { "rocky", "usf", "hello", "apple" };
            string keyword = "hhllo";
            Console.WriteLine(DictSearch(userDict, keyword));
            Console.WriteLine();
            Console.WriteLine("Question 9");
            SolvePuzzle();
        }

        public static int[] TargetRange(int[] l1, int t)
        {

            try
            {
                //Write your code here;
                int sizeQ1 = 0;
                foreach (int numQ1 in l1)
                {
                    if (numQ1 == t)
                    {
                        sizeQ1++;
                    }
                }
                int[] arrayQue1 = new int[sizeQ1];
                int countQue1 = 0;
                for (int indexQue1 = 0; indexQue1 < l1.Length; indexQue1++)
                {
                    if (l1[indexQue1] == t)
                    {
                        arrayQue1[countQue1] = indexQue1;
                        countQue1++;
                    }
                }
                if (countQue1 == 0)
                {
                    arrayQue1 = new int[2] { -1, -1 };
                }
                return arrayQue1;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public static string StringReverse(string s)
        {
            try
            {
                //write your code here
                string[] arrayQ2 = s.Split(' ');
                int sizeArrayQ2 = arrayQ2.Length;
                string[] resortArrayQ2 = new string[sizeArrayQ2];
                for (int countQ2 = 0; countQ2 < sizeArrayQ2; countQ2++)
                {
                    if (arrayQ2[countQ2] == " ")
                    {
                        resortArrayQ2[countQ2] = arrayQ2[countQ2];
                    }
                    else
                    {
                        char[] charArrayQ2 = arrayQ2[countQ2].ToCharArray();
                        int sizeCharArrayQ2 = charArrayQ2.Length;
                        char[] resortCharArrayQ2 = new char[sizeCharArrayQ2];
                        for (int indexQ2 = 0; indexQ2 < sizeCharArrayQ2; indexQ2++)
                        {
                            resortCharArrayQ2[sizeCharArrayQ2 - 1 - indexQ2] = charArrayQ2[indexQ2];
                        }
                        resortArrayQ2[countQ2] = new string(resortCharArrayQ2);
                    }
                }
                string resortWords = string.Join(" ", resortArrayQ2);
                return resortWords;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int MinimumSum(int[] l2)
        {
            try
            {
                //Write your code here;
                int sumQ3 = 0;
                for (int indexQ3 = 0; indexQ3 < l2.Length; indexQ3++)
                {
                    sumQ3 += l2[indexQ3];
                }
                return sumQ3;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string FreqSort(string s2)
        {
            try
            {
                //Write Your Code Here
                char[] charArrayQ4 = s2.ToCharArray();
                int sizeCharArrayQ4 = charArrayQ4.Length;
                char[] resortCharArrayQ4 = new char[sizeCharArrayQ4];
                for (int indexQ4 = 0; indexQ4 < sizeCharArrayQ4; indexQ4++)
                {
                    resortCharArrayQ4[sizeCharArrayQ4 - 1 - indexQ4] = charArrayQ4[indexQ4];
                }
                string resortWordsQ4 = new string(resortCharArrayQ4);

                return resortWordsQ4;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void DisplayArray(int[] a)
        {
            foreach (int n in a)
            {
                Console.Write(n + " ");
            }
        }

        public static int[] Intersect1(int[] nums1, int[] nums2)
        {
            try
            {
                //Write your code here
                // Create a list to store the intersect numbers
                List<int> outputList = new List<int>();
                var dict = new Dictionary<int, int>();
                Array.Sort(nums1);
                Array.Sort(nums2);
                int i = 0;
                int j = 0;
                int indexS1 = 0, indexS2 = 0;
                //while either array still has an element
                while (indexS1 < nums1.Length || indexS2 < nums2.Length)
                {
                    //if both arrays have elements  
                    if (indexS1 < nums1.Length && indexS2 < nums2.Length)
                    {
                        //If item on left array is less than item on right array, add that item to the result array 
                        if (nums1[indexS1] == nums2[indexS2])
                        {
                            outputList.Add(nums1[indexS1]);
                            indexS1++;
                            indexS2++;
                        }
                        // else the item in the right array wll be added to the results array
                        else
                        {
                            if (nums1[indexS1] < nums2[indexS2])
                            {
                                indexS1++;
                            }
                            else if (nums1[indexS1] > nums2[indexS2])
                            {
                                indexS1++;
                            }
                        }
                    }
                }
                return outputList.ToArray();
            }
            catch
            {
                throw;
            }
        }

        public static int[] Intersect2(int[] nums1, int[] nums2)
        {
            try
            {
                // Write your code here
                // Create a new dictionary of int, with char keys. 
                Dictionary<int, int> myDictQ5b = new Dictionary<int, int>();
                // Adding key/ value pairs in myDictQ5b from nums1
                for (int i = 0; i < nums1.Length; i++)
                {
                    myDictQ5b.Add(i, nums1[i]);
                }
                // Create a list to store the intersect numbers
                List<int> outputList = new List<int>();
                // Scan nums2, check whether there is a same number 
                for (int t = 0; t < nums2.Length; t++)
                {
                    if (myDictQ5b.ContainsValue(nums2[t]))
                        outputList.Add(nums2[t]);
                }

                return outputList.ToArray();
            }
            catch
            {
                throw;
            }
        }

        public static bool ContainsDuplicate(char[] arr, int k)
        {
            try
            {
                //Write your code here;
                // Create a new dictionary of int, with char keys. 
                Dictionary<char, int> myDict = new Dictionary<char, int>();
                // Scan char[] arr, check whether there is a same letter in the input array and the 
                //absolute difference of index of these two letter is k.
                for (int i = 0; i < arr.Length; i++)
                    if (myDict.ContainsKey(arr[i]) && i - myDict[arr[i]] <= k)
                        return true;
                    // if there isn't any same letter, adding key/value pairs in myDict
                    // and returen false
                    else
                        myDict[arr[i]] = i;
                return false;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int GoldRod(int rodLength)
        {
            try
            {
                //Write Your Code Here13
            }
            catch (Exception)
            {
                throw;
            }
            return 0;
        }
        public static bool DictSearch(string[] userDict, string keyword)
        {
            try
            {
                //Write Your Code Here
            }
            catch (Exception)
            {
                throw;
            }
            return default;
        }
        public static void SolvePuzzle()
        {
            try
            {
                //Write Your Code Here
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}