using System;
using System.Linq;

namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //  let's play with arrays of numbers using the LINQ statements
            double total = 0, average;
            double[] numbers = { 12, 3, 2, 43, 6, 2, 2242, 5, 3312, 3, 62, 2, 5, 4 };
            foreach (var num in numbers)
            {
                total += num;
            }
            average = total / numbers.Length;
            Console.WriteLine("The total of the array is " + total + " and the average is " + average);
            average = numbers.Average();
            bool allPositive = numbers.All(nextNum => nextNum > 0);
            bool anyPositive = numbers.Any(nextNum => nextNum > 0);

            bool contains5 = numbers.Contains(5);

            var unique = numbers.Distinct();
            var firstNum = numbers.First();
            var lastNum = numbers.Last();
            //All, Any, Average, Contains, Count, Distinct, ElementAt, Empty, First, Last, 
            //Max, Min, OrderBy(Descending), Reverse, Skip, Sum, Take, TakeLast, Where
            int[] randomNums = { 43, 6, 31, 84, -21, -8, 5, 6, -21, 64, 6, 43, -8, -100, -8, 874, 42 };
            var average2 = randomNums.Average();
            var max2 = randomNums.Max();
            var min2 = randomNums.Min();
            Console.WriteLine("the average of random nums is " + average2);
            Console.WriteLine("The largest number in random nums is " + max2 + " and the smallest number is " + min2);
            int countDistinct = randomNums.Distinct().Count();
            Console.WriteLine("there are " + countDistinct + " distinct numbers in random nums");
            var take = randomNums.Take(3);
            //  ask for a number Utils.GetNumber......
            //  use All to find out if all numbers in randomNums are greater than that number
            int userNum = Utils.GetNumber("enter a number: ");
            bool greaterThan = randomNums.All(nums => nums > userNum);
            Console.WriteLine("All numbers in random nums are greater than the user inputed number: " + greaterThan);
            var divisBy7 = randomNums.Where(divis => divis % 7 == 0);
            foreach (var divis in divisBy7)
            {
                Console.WriteLine(divis + " is divisable by 7");
            }
            int[] scores = { 21, 32, 7, 4, -2, 6, 3, -46, 6, 54, -87, 57, 89, 57, -6, 3, 43, 6, 7, -45, 5, 24, 6 };
            //  Count the scores
            //  What is the Average and Max scores
            //  How many Distinct scores are there
            //  add up the Distinct scores
            //  add up all numbers greater than 44
            //  what is the average of numbers less than 0
            //  how many numbers are between -20 and 30
            var scoreCount = scores.Count();
            Console.WriteLine("there are " + scoreCount + " scores in the array");
            var averageScore = scores.Average();
            Console.WriteLine("The average score is " + averageScore);
            var maxScore = scores.Max();
            Console.WriteLine("the max score is " + maxScore);
            var countDistinct2 = scores.Distinct().Count();
            Console.WriteLine("There are " + countDistinct2 + " distinct scores in the array");
            var distinctSum = scores.Distinct().Sum();
            Console.WriteLine("the sum of all the distinct scores is: " + distinctSum);
            var sumGreater44 = scores.Where(score => score > 44).Sum();
            Console.WriteLine("The sum of all numbers greater than 44 is " + sumGreater44);
            var averageLess0 = scores.Where(score => score < 0).Average();
            Console.WriteLine("The average scores less than 0 is " + averageLess0);
            var numBetween = scores.Where(score => score > -20 && score < 30).Count();
            Console.WriteLine("There are " + numBetween + " numbers between -20 and 30 in scores");
        }
    }
}