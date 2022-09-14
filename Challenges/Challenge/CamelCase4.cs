using System.Text.RegularExpressions;
namespace Challenge.CamelCase4
{
    // https://www.hackerrank.com/challenges/three-month-preparation-kit-camel-case/problem
    class CamelCase4
    {
        public static string camelCase4(string arr)
        {            
            char operation = Convert.ToChar(arr.Substring(0,1));
            char suBoperation = Convert.ToChar(arr.Substring(2,1));
            string text = arr.Substring(4);
            bool isMethod = arr.EndsWith("()");
            string finalText = String.Empty;
            if (operation == 'S')
            {
                
                if (isMethod){
                    text = text.Replace("()","");
                }
                string[] split =  Regex.Split(text, @"(?<!^)(?=[A-Z])");
                for (int j =0; j < split.Length; j++)
                { 
                    finalText += split.Length-1 == j ? split[j] : split[j]+" ";
                }
                finalText = finalText.ToLower();
                
            }
            if (operation == 'C')
            {
                for (int j =0; j < text.Split(" ").Length; j++)
                {
                    string subText = text.Split(" ")[j];
                    
                    if (suBoperation == 'M')
                    {
                        if(j > 0)
                        {
                            subText = char.ToUpper(subText[0]) + subText.Substring(1);
                        }                           
                        if (j == text.Split(" ").Length -1)
                        {
                            subText += "()";
                        }
                    }
                    if (suBoperation == 'C')
                    {
                        subText = char.ToUpper(subText[0]) + subText.Substring(1);
                    } 
                    if (suBoperation == 'V')
                    {
                        if(j > 0)
                        {
                            subText = char.ToUpper(subText[0]) + subText.Substring(1);
                        }   
                    }
                    finalText += subText;
                }
            }
            
            return finalText;
        }
    }
}