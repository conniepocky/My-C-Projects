using System;

namespace the_adventures_of_octocat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Adventures of Octocat!");
	    Console.WriteLine(@" 
			    This is you
			     o
			    /|\
			     /\");
	    Console.WriteLine("Do you want to go to github offices(1) or go to windows xp land (2)");
	    var choice = Console.ReadLine();
	    if(choice == "1") {
		    Console.WriteLine(@"Yaaaay! You got on the plane to github offices :)
			_____________________	    
			|	    o       |\
			|	   /|\      | \
			|	    \\      | /
			|___________________|/
			");
		    Console.WriteLine("And then you met octocat!");
	    } else {
		    Console.WriteLine(@"You went to Windows XP Land and met clippy :)


    /  \
    |  |
    @  @
    |  |
    || |/
    || ||
    |\_/|
    \___/                   o
			   /|\      
			    /\"); 

	    }
	
	    Console.WriteLine("Then you went to go get some food. Do you want to waffles (1) or pancakes (2)?");
	    var food = Console.ReadLine();

	    if(food == "1") {
		Console.WriteLine(@"Yaaay! 

				_________
				|_|_|_|_|
				|_|_|_|_|
				|_|_|_|_|
				|_|_|_|_|");




	    }else {
		    Console.WriteLine(":(");
	    }

	   
	    Console.WriteLine("After that, you wanted to get a new pet! Do you want a cat (1) clippy (2) or octocat (3)");
	    var pet = Console.ReadLine();
	    if(pet == "1") {
		    Console.WriteLine(@"
    /\**/\
   ( o_o  )_)
   ,(u  u  ,),
  {}{}{}{}{}{}
				     ");
	    } else if(pet == "2") {
		    Console.WriteLine(@"
    /  \
    |  |
    @  @
    |  |
    || |/
    || ||
    |\_/|
    \___/");

	    } else {
		    Console.WriteLine(@"
           MMM.           .MMM
           MMMMMMMMMMMMMMMMMMM
           MMMMMMMMMMMMMMMMMMM      ___________________________________
          MMMMMMMMMMMMMMMMMMMMM    |                                   |
         MMMMMMMMMMMMMMMMMMMMMMM   | Waffles and Linux are the best :) |
        MMMMMMMMMMMMMMMMMMMMMMMM   |_   _______________________________|
        MMMM::- -:::::::- -::MMMM    |/
         MM~:~   ~:::::~   ~:~MM
    .. MMMMM::. .:::+:::. .::MMMMM ..
          .MM::::: ._. :::::MM.
             MMMM;:::::;MMMM
      -MM        MMMMMMM
      ^  M+     MMMMMMMMM
          MMMMMMM MM MM MM
               MM MM MM MM
               MM MM MM MM
            .~~MM~MM~MM~MM~~.
         ~~~~MM:~MM~~~MM~:MM~~~~
        ~~~~~~==~==~~~==~==~~~~~~
         ~~~~~~==~==~==~==~~~~~~
             :~==~==~==~==~~");

	    }

	    Console.WriteLine("Your pet wants to help you with coding!");

	    Console.WriteLine("But your pet doesn't know how to code! What Programming Language do you want to teach it?");

	    var language = Console.ReadLine();

	    Console.WriteLine("Yay! Your pet really enjoys learning " + language + "!");

	    Console.WriteLine(@"



			    ______________________   
			              |                  |    |     _____
			              |                  |    |     |
				      |                  |____|     |____
                                      |                  |    |     |
				      |                  |    |     |____
				      |




				      _____                    ____
				      |           |\    |      |   \  
				      |           | \   |      |    \ 
				      |____       |  \  |      |     |
				      |           |   \ |      |    /
				      |____       |    \|      |___/ ");
				      
				                             
	    
        }
    }
}
