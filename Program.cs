using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string doAnother;

            //start with a do while loop 
            do
            {
                try
                {

                    Console.WriteLine("Please enter a number..");
                    string UserNumber = Console.ReadLine();
                    //conver string to int using parse, we also made varaible because not used anywhere else. 
                    // named UserNumberInt because variable not used yet.
                    int UserNumberInt = int.Parse(UserNumber);

                    Console.WriteLine("Please enter a second number");
                    string UserNumber2 = Console.ReadLine();
                    int UserNumberInt2 = int.Parse(UserNumber2);

                    //do some match using the output of the two number
                    int userDivide = UserNumberInt / UserNumberInt2;
                    Console.WriteLine("Here is the division answer... {0}", userDivide);

                    // enter social # 
                    Console.WriteLine("Please enter you social security number");
                    string ssn = Console.ReadLine();
                    SocialSecurityNumber userSSN = new SocialSecurityNumber();

                    //set objects ssn property to user input, getting a property by calling on the object the user just put in. 
                    userSSN.SSN = ssn;
                    Console.WriteLine("SSN is valid");
                    

                    
                }        
                catch (SSNFormatException ssnEx)
                {
                    Console.WriteLine("Please enter a valid SSN ###-##-####");
                }
                catch (DivideByZeroException zeroEx)
                {
                    Console.WriteLine("The second number can not be 0");
                }
                catch (Exception ex) //our exception variable is now called "ex"
                {
                    Console.WriteLine("Error Message; {0} /nException type: {1} ", ex.Message, ex.GetType());
                }                
                finally
                {
                    Console.WriteLine("This runs all the time");
                }
                Console.WriteLine("Does this run all the time?");
                Console.WriteLine("Do you want ot continue? y/n");
                doAnother = Console.ReadLine();
            } while (doAnother == "y");
            Console.ReadLine();

        }
    }
}
