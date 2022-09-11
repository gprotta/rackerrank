namespace Challenge.TimeConversion
{
    // https://www.hackerrank.com/challenges/three-month-preparation-kit-time-conversion/problem
    class TimeConversion
    {
        public static string timeConversion(string s)
        {
            bool isPM =  s.Substring(8,2) == "PM" ? true : false;
            string hour, minute, second = String.Empty;
            if(isPM)
            {
                int time = Int32.Parse(s.Substring(0,2));
                if (time > 1 && time < 12){
                    hour = (time+12).ToString();
                }else{
                    hour = time.ToString();
                }
            
            }else{
                int time = Int32.Parse(s.Substring(0,2));
                if (time == 12){
                    hour = "00";
                }else{
                    hour = s.Substring(0,2);  
                }
                
            }
            
            minute = s.Substring(3,2);
            second = s.Substring(6,2);
            
            return String.Format("{0}:{1}:{2}",hour,minute,second);
        }
    }    
}