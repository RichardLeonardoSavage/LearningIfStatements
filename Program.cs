namespace LearningIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isMale = true;
            bool isTall = true; 

            if(isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            // the '!' stands for false or negation - so basically saying 1st condition is true but 2nd is not
            else if(isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            //1st condition is not true but the 2nd condition is true
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male but you are tall");
            }
            else
            //this else statement is saying if no condiitons are met
            {
                Console.WriteLine("You are not tall or male");
            }
            Console.ReadLine();
        }
    }
}