using System;
using System.Collections.Generic;
using System.Linq;
namespace bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define Vairables
            Random rnd = new Random();
            int menu = 0;
            int currentnumber;
            int d = 0;
            
            
            //intro, ask for an upper limit, assign that upper limit and create a list
            Console.WriteLine("Welcome to this fun game of Bingo! To begin, enter the upper limit of numbers to be drawn.");
            int x = Convert.ToInt32(Console.ReadLine());
            x++;
            List<int> numbers = new List<int>();

            
            //Check that it is larger than 0
            while(x <=0){
                Console.WriteLine("Please enter a number greater than 0...");
                x = Convert.ToInt32(Console.ReadLine());
                x++;
            }
            //Define variable for upper array check limit
            int check = x+2;
            //While loop allows main menu to repeat
            while( menu != 4){
            
            //Main Menu
                Console.WriteLine("Welcome to the Swinburne Bingo Club");
                Console.WriteLine("1. Draw next number");
                Console.WriteLine("2. View all drawn numbers");
                Console.WriteLine("3. Check specific number");
                Console.WriteLine("4. Exit");
            
            //Select a menu option
                menu = Convert.ToInt32(Console.ReadLine());
                while(menu > 4){
                    Console.WriteLine("Please enter a number specified in the menu...");
                    menu = Convert.ToInt32(Console.ReadLine());
                }
                while(menu < 1){
                    Console.WriteLine("Please enter a number specified in the menu...");
                    menu = Convert.ToInt32(Console.ReadLine());
                }
                
            //Draw next number
                if(menu == 1){                   
                //Create random number and check if it's already been used
                    currentnumber = rnd.Next(1, x);
                    if(d == (x-1)){
                        Console.WriteLine("All the numbers have been drawn!");
                        Console.WriteLine("");
                    }
                    else{
                        while(numbers.Contains(currentnumber)){
                        currentnumber = rnd.Next(1, x);
                        }
                    //New number is placed into next position in list, then announced
                        d++;
                        numbers.Add(currentnumber);
                        
                        Console.WriteLine("The number drawn is " + currentnumber + "!");
                        Console.WriteLine("");
                    }
                }
                
            //View all drawn numbers
                if(menu ==2){
                    Console.WriteLine("1. Print numbers in order they were drawn");
                    Console.WriteLine("2. Print numbers in numerical order");
                    int menu2 = Convert.ToInt32(Console.ReadLine());
                    if(menu2 == 1 ){
                        Console.Write("Your Numbers: ");
                        
                        foreach(int i in numbers){
                            Console.Write(i + ", ");
                        }
                    }
                    if(menu2 == 2){
                        int[] numbersarray = numbers.ToArray();
                        Array.Sort(numbersarray);
                        Console.Write("Your Numbers: ");
                        foreach(int i in numbersarray){
                            Console.Write(i + ", ");
                        }
                    }
                    Console.WriteLine("");
                }
            
            //Check specific number
                if(menu ==3){
                    Console.Write("Enter the number you want to check: ");
                    check = Convert.ToInt32(Console.ReadLine());
                    while(check > x){
                        Console.WriteLine("");
                        Console.Write("Please enter a number within the bounds of numbers drawn...:");
                        check = Convert.ToInt32(Console.ReadLine());
                     }
                    if(numbers.Contains(check)){
                       Console.WriteLine("This number has already been listed.");
                       Console.WriteLine("");
                    }
                    else{
                       Console.WriteLine("This number has not been listed.");
                       Console.WriteLine("");
                    }           
                }
            }  
            //4. Exit
            Console.WriteLine("Thanks for playing!");
        }
    }
}
