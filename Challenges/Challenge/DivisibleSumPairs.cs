namespace Challenge.DivisibleSumPairs
{   
    // https://www.hackerrank.com/challenges/three-month-preparation-kit-divisible-sum-pairs/problem?
    public class DivisibleSumPairs
    {
        //O(N^2)
        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
           int result = 0;
            for(int i = 0; i< ar.Count;i++)
            {
                for(int j = i + 1; j< ar.Count;j++)
                {                 
                    int r = ar[i] + ar[j];
                    if ( r % k == 0)
                    {
                        result++;
                    }                    
                }
            }
            return result;
        }
        //O(N)
        public static int divisibleSumPairsON(int n, int k, List<int> ar)
        {
            int count = 0;
            Dictionary<int,int> map = new Dictionary<int, int>();

            for(int i = 0; i < ar.Count; i++)
            {
                int mod = ar[i] % k;
                int compl = mod == 0 ? 0 : k-mod;

                if (map.ContainsKey(compl))
                {
                    count = count + map[compl];      
                }

                if (map.ContainsKey(mod))
                {
                    map[mod] = map[mod] + 1;
                }
                else
                {
                    map.Add(mod, 1);
                }
            }

            return count;
        }
    }
}