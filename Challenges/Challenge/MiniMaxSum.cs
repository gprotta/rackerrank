namespace Challenge.MiniMaxSum
{
    // https://www.hackerrank.com/challenges/three-month-preparation-kit-mini-max-sum/problem
    class MiniMaxSum
    {
        public static void miniMaxSum(List<int> arr)
        {
            List<long> arrTemp = new List<long>();   
            long sum = 0;  
            for(int j = 0; j < arr.Count; j++)
            {
                sum += arr.ElementAt(j);
            }       
            for(int i =0; i< arr.Count;i++)
            {  
                arrTemp.Add(sum - Convert.ToInt64(arr.ElementAt(i)));
            }
            arrTemp.Sort();
            Console.WriteLine(arrTemp.First() + " " + arrTemp.Last());
        }
    }
}