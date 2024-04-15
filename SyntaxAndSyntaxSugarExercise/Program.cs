namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int answer = 4;
            string response;
            if (answer < 9)
            {
                response = answer + " is less than nine";
            }
            else
            {
                response = answer + " is greater than or equal to nine";
            }
            //String Interpolation
            int answer = 4;
            string response;

            if (answer < 9)
            {
                response = $"{answer} is less than nine";
            }
            else
            {
                response = $"{answer} is greater than or equal to nine";
            }


            //Inferred Typing

            var response = (answer < 9) ? "is less than nine" : "is greater than or equal to nine";

            //Ternary Operator
            string response = (answer <9) ? "is less than nine" : "is greater than or equal to nine"; 
        
        }
    }
}
