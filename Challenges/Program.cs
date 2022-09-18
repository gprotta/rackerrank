using Challenge.PlusMinus;
using Challenge.MiniMaxSum;
using Challenge.TimeConversion;
using Challenge.BreakingTheRecords;
using Challenge.CamelCase4;
using Challenge.DivisibleSumPairs;
class Program
{
    public static void Main(String[] args)
    {
        //Plus Minus
        //List<int> arr = new List<int>(){-4,3,-9,0,4,1};
        //PlusMinus.plusMinus(arr);
        
        // Mini-Max Sum
        //List<int> arr = new List<int>(new int[] {1,2,3,4,5});   
        //MiniMaxSum.miniMaxSum(arr);

        // Time Conversion
        //Console.WriteLine(TimeConversion.timeConversion("07:05:45PM"));

        // Breaking the Records
        //List<int> scores = new List<int>(){503, 503, 503, 503, 503};
        //Console.WriteLine(BreakingTheRecords.breakingRecords(scores)[0] + 
        //" " + BreakingTheRecords.breakingRecords(scores)[1]);

        // Camel Case 4
        //string[] arr = {"C;V;mobile phone","C;C;coffee machine","C;M;white sheet of paper"};
        //String[] arr = {"S;M;plasticCup()","S;C;LargeSoftwareBook","S;V;pictureFrame"};        
        //for (int i = 0; i < arr.Length; i++)
        //{           
        //    Console.WriteLine(CamelCase4.camelCase4(arr[i]));
        //}
        List<int> arr =  new List<int>(){1, 3 ,2 ,6, 1, 2};
        //6, 3, 
        //List<int> arr =  new List<int>(){13,91,5,100,5,12,5,79,99,87,59,65,62,73,93,73,63,65,59,46,67,35,22,55,50,53,38,79,75,44,95,53,5,73,44,94,95,21,60,2,32,48,72,13,91,74,79,99,17,31,53,20,88,17,54,47,56,79,23,49,95,81,9,50,12,20,45,82,44,82,93,15,73,51,65,96,4,77,37,41,30,11,65,100,62,51,64,48,12,11,68,81,46,37,10,46,75,82,21,23};
        //100, 40, 
        // Divisible Sum Pairs
        int result = DivisibleSumPairs.divisibleSumPairsON(6, 3, arr);
        Console.WriteLine(result.ToString());
        
    }
}