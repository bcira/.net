using System;

namespace PasswordStrengthChecker
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
        
            int strength = 0;

            foreach (char c in password) //lowercase
            {
                if (c >= 'a' && c <= 'z')
                {
                    strength++;
                    break;
                }
            }
        

            foreach (char c in password)  //Uppercase
            {
                if (c >= 'A' && c <= 'Z')
                {
                    strength++;
                    break;
                }
            }
                

            foreach (char c in password)  //digits
            {
                if (c >= '0' && c <= '9')
                {
                    strength++;
                    break;
                }
            }
                
            char[] special = { '@', '#', '$', '%', '^', '&', '+', '=', '*' ,'!', '.'}; 
            
            foreach (char c in password)   //special char
            {
                if (password.IndexOfAny(special, 0) > -1)
                {
                    strength++;
                    break;
                }
            }
          

            switch (strength)
            {
                case 1:
                    Console.WriteLine("weak password!"); //only lowercase
                    break;
                case 2:
                    Console.WriteLine("medium strength password!"); //uppercase and lowercase
                    break;
                case 3:
                    Console.WriteLine("strong password!"); //uppercase or lowercase and digits
                    break;
                case 4:
                    Console.WriteLine("extremely strong password!"); // both uppercase and lowercase, digit and special char
                    break;
                
            }  

        
        }
    }
}