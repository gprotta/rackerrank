namespace Challenge.PlusMinus
{
    // https://www.hackerrank.com/challenges/three-month-preparation-kit-plus-minus/problem
    class PlusMinus
    {
        public static void plusMinus(List<int> arr)
        {
            int positive = 0;
            int negative = 0;
            int zero = 0;
            for (int i = 0; i < arr.Count;i++)
            {
                if (arr.ElementAt(i) > 0){
                    positive++;
                }
                if(arr.ElementAt(i) < 0){
                    negative++;
                }
            
                if (arr.ElementAt(i) == 0 )
                    zero++;
            }
            float pos = (float)positive/arr.Count;
            float neg = (float)negative/arr.Count;
            float zer = (float)zero/arr.Count;

            Console.WriteLine(String.Format("{0:0.000000}",pos));
            Console.WriteLine(String.Format("{0:0.000000}",neg));
            Console.WriteLine(String.Format("{0:0.000000}",zer));
        }

    } 
}

 