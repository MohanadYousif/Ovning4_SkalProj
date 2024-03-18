using System;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        static void ExamineList()
        {
            // Initialize a new List<string> to store items
            List<string> theList = new List<string>();

            // Loop until user decides to exit
            while (true)
            {
                // Prompt user to input either '+' to add or '-' to remove an item
                Console.WriteLine("Please input either '+' to add an item or '-' to remove an item from the list:");
                string input = Console.ReadLine();
                char nav = input[0]; // Extract the first character from the input
                string value = input.Substring(1); // Extract the rest of the input after the first character

                // Switch statement to handle adding or removing items based on user input
                switch (nav)
                {
                    case '+': // If user wants to add an item
                        theList.Add(value); // Add the item to the list
                        Console.WriteLine($"Item '{value}' added to the list.");
                        break;
                    case '-': // If user wants to remove an item
                        if (theList.Contains(value)) // Check if the item exists in the list
                        {
                            theList.Remove(value); // Remove the item from the list
                            Console.WriteLine($"Item '{value}' removed from the list.");
                        }
                        else // If the item does not exist in the list
                        {
                            Console.WriteLine($"Item '{value}' not found in the list.");
                        }
                        break;
                    default: // If user input is not recognized
                        Console.WriteLine("Please use only '+' to add or '-' to remove an item.");
                        break;
                }

                // Print count and capacity of the list after each operation
                Console.WriteLine($"List count: {theList.Count}, List capacity: {theList.Capacity}");
                Console.WriteLine($"Press x if you want to go to main menu");
                if (Console.ReadLine().ToLower() == "x") break;
            }
        }


        static void ExamineQueue()
        {
            // Initialize a new Queue<string> to simulate a queue
            Queue<string> theQueue = new Queue<string>();

            // Loop until user decides to exit
            while (true)
            {
                // Prompt user to input either '+' to enqueue or '-' to dequeue an item
                Console.WriteLine("Please input either '+' to enqueue an item or '-' to dequeue an item from the queue:");
                string input = Console.ReadLine();
                char nav = input[0]; // Extract the first character from the input
                string value = input.Substring(1); // Extract the rest of the input after the first character

                // Switch statement to handle enqueuing or dequeuing items based on user input
                switch (nav)
                {
                    case '+': // If user wants to enqueue an item
                        theQueue.Enqueue(value); // Enqueue the item to the queue
                        Console.WriteLine($"Item '{value}' enqueued.");
                        break;
                    case '-': // If user wants to dequeue an item
                        if (theQueue.Count > 0) // Check if the queue is not empty
                        {
                            string dequeuedItem = theQueue.Dequeue(); // Dequeue the item from the queue
                            Console.WriteLine($"Item '{dequeuedItem}' dequeued.");
                        }
                        else // If the queue is empty
                        {
                            Console.WriteLine("Queue is empty.");
                        }
                        break;
                    default: // If user input is not recognized
                        Console.WriteLine("Please use only '+' to enqueue or '-' to dequeue an item.");
                        break;
                }

                // Print the current state of the queue after each operation
                Console.WriteLine($"Queue count: {theQueue.Count}, and contents: {string.Join(", ", theQueue)}");
                Console.WriteLine($"Press x if you want to go to main menu");
                if (Console.ReadLine().ToLower() == "x") break;
            }
        }


        static void ExamineStack()
        {
            // Initialize a new Stack<string> to simulate a stack
            Stack<string> theStack = new Stack<string>();

            // Loop until user decides to exit
            while (true)
            {
                // Prompt user to input either '+' to push or '-' to pop an item
                Console.WriteLine("Please input either '+' to push an item or '-' to pop an item from the stack:");
                string input = Console.ReadLine();
                char nav = input[0]; // Extract the first character from the input
                string value = input.Substring(1); // Extract the rest of the input after the first character

                // Switch statement to handle pushing or popping items based on user input
                switch (nav)
                {
                    case '+': // If user wants to push an item
                        theStack.Push(value); // Push the item onto the stack
                        Console.WriteLine($"Item '{value}' pushed onto the stack.");
                        break;
                    case '-': // If user wants to pop an item
                        if (theStack.Count > 0) // Check if the stack is not empty
                        {
                            string poppedItem = theStack.Pop(); // Pop the item from the stack
                            Console.WriteLine($"Item '{poppedItem}' popped from the stack.");
                        }
                        else // If the stack is empty
                        {
                            Console.WriteLine("Stack is empty.");
                        }
                        break;
                    default: // If user input is not recognized
                        Console.WriteLine("Please use only '+' to push or '-' to pop an item.");
                        break;
                }

                // Print the current state of the stack after each operation
                Console.WriteLine($"Stack count: {theStack.Count}, and contents: {string.Join(", ", theStack)}");
                Console.WriteLine($"Press x if you want to go to main menu");
                if (Console.ReadLine().ToLower() == "x") break;
            }
        }


        static void CheckParanthesis()
        {
            // Prompt the user to input a string containing parentheses
            Console.WriteLine("Please input a string containing parentheses:");
            string input = Console.ReadLine();

            // Initialize a new Stack<char> to keep track of opening parentheses
            Stack<char> parenthesesStack = new Stack<char>();

            // Iterate through each character in the input string
            foreach (char c in input)
            {
                // If the character is an opening parenthesis
                if (c == '(' || c == '{' || c == '[')
                {
                    parenthesesStack.Push(c); // Push the opening parenthesis onto the stack
                }
                // If the character is a closing parenthesis
                else if (c == ')' || c == '}' || c == ']')
                {
                    // If the stack is empty, there is an unmatched closing parenthesis
                    if (parenthesesStack.Count == 0)
                    {
                        Console.WriteLine("Unmatched closing parenthesis.");
                        return;
                    }

                    char top = parenthesesStack.Pop(); // Pop the topmost opening parenthesis from the stack

                    // Check if the closing parenthesis matches the corresponding opening parenthesis
                    if ((c == ')' && top != '(') || (c == '}' && top != '{') || (c == ']' && top != '['))
                    {
                        Console.WriteLine("Unmatched parenthesis.");
                        return;
                    }
                }
            }

            // If the stack is not empty, there are unmatched opening parentheses
            if (parenthesesStack.Count > 0)
            {
                Console.WriteLine("Unmatched opening parenthesis.");
            }
            else // Otherwise, all parentheses are balanced
            {
                Console.WriteLine("Parentheses are balanced.");
            }
        }


    }
}