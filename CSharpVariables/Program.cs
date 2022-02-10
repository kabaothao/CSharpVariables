using System; //all these stuffs are configuring the files. we can specify these things we can use. 

namespace StaticClassAttributes //same name as the project we are using. we are in the project.
                                //these two curly brackets is where we start our coding
{
    public static class Program //class is like a container that we can put our code. 
    {
        static void Main(string[] args) //this is sort of like another container we can put our code. This Main method any code we put inside of these curly brackets it will execute our code. 
        {

            //Console.WriteLine("Hello World");//writes a line on to the screen
            //Console.ReadLine(); //read the line and then close the screen

            Console.WriteLine("   /|"); //once its done with the first instruction.. it will execute in order. the order of our program matters. 
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");



            //type of data that i want the variables to store. remember variables are like containers. 
            string characterName = "John"; //giving a value
            int characterAge; //declaring a variable 
            characterAge = 35; //assigning a value to the variable

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);




            Console.ReadLine();




        }




    }


}

/*
 Topic: What is the set up for program.cs?
Just a set of instructions that the computer is going to follow the order of those instructions.


Topic: What is variables?
variable store a specific data valu. and then when i want to use that data value. 
 */