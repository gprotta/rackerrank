namespace Challenge.BreakingTheRecords
{
    // https://www.hackerrank.com/challenges/three-month-preparation-kit-breaking-best-and-worst-records/problem
    class BreakingTheRecords
    {
         public static List<int> breakingRecords(List<int> scores)
        {
            int min = 0;
            int max = 0;
            int lastMin = scores[0];
            int lastMax = scores[0];
            int currentMin = scores[0];
            int currentMax = scores[0];
            for (var i = 0;i < scores.Count;i++)
            {              
                if (i > 0) 
                {
                    if (scores[i] > scores[i-1])
                    {
                        currentMax = scores[i];
                        currentMin = scores[i-1];                   
                    }
                    if (scores[i] < scores[i-1])
                    {
                        currentMax= scores[i-1];  
                        currentMin= scores[i];                      
                    }
                    if(currentMin < lastMin){
                        min++;
                        lastMin = currentMin;
                    }
                    if(currentMax > lastMax){
                        max++;
                        lastMax = currentMax;
                    }                    
                }
            }
            
            return new List<int>(){max,min};
        }
    }
}