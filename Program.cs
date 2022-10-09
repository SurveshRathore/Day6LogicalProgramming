// See https://aka.ms/new-console-template for more information

using Day6Program;

//Generate fibonacci series
p1FibonacciSeries fib = new();
fib.GenerateFibonacciSeries(5);

//display new line
Console.WriteLine();
Console.WriteLine();

//check whether the number is a perfect number or not
p2PerfectNumber perfNum = new();
perfNum.CheckPerfectNumber(28);

//display new line
Console.WriteLine();

//check whether the number is a prime number or not
p3PrimeNumber prime = new();
prime.CheckPrimeNumber(56);

//display new line
Console.WriteLine();

//find the reverse of a number
p4NumberReverse numRev = new();
numRev.GenerateReverse(12345);

//display new line
Console.WriteLine();

//generate the distinct coupon number
p5CouponNumber.generateNDistinctCouponNum(15);