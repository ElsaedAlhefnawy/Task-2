namespace Task_Day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> List = new List<int>() ;

            bool X  = true;

            do
            {
                Console.WriteLine("Choose what you want from the menu\n" +
                    "P - Print numbers.\n" +
                    "A - Add a number.\n" +
                    "M - Display mean of the numbers.\n" +
                    "S - Display the smallest number.\n" +
                    "L - Display the largest number.\n" +
                    "F - Find a number.\n" +
                    "C - Clearing the list. \n" +
                    "Q - Quit.\n ");

                char Choice = char.Parse(Console.ReadLine());
                Choice = char.ToUpper(Choice);
                switch (Choice)
                {
                    // Print elements of the list ::
                    case 'P':
                        {
                            if (List.Count == 0)
                            {
                                Console.WriteLine($"\"[] The list is empty :: \"");
                            }
                            else
                            {
                                Console.Write("[");
                                for (int i = 0; i < List.Count; i++)
                                {

                                    Console.Write($" {List[i]}");

                                }
                                Console.WriteLine("]");
                            }
                            break;
                        }
                    // Ask user for number of elemnt to be added in the list then add nummber in the list without duplication ::
                    case 'A':
                        {
                            Console.WriteLine("How many numbers you want to add ?? ");
                            int numOfAddedNumber = int.Parse(Console.ReadLine());
                            for (int i = 1; i <= numOfAddedNumber; i++)
                            {
                                Console.WriteLine($"Plz enter value num {i}:");
                                int numFromUser = int.Parse(Console.ReadLine());

                                List.Add(numFromUser);
                                Console.WriteLine($"the number {numFromUser} is added");
                                for (int j = 0; j < List.Count - 1; j++)
                                {
                                    if (List[j] == numFromUser)
                                    {

                                        Console.WriteLine("The number you enter is repeated !!!.");
                                        List.RemoveAt(j);
                                        break;
                                    }
                                }
                                
                            }
                            break;
                        }
                    // Calculate sum of list first then calculate mean ::
                    case 'M':
                        {
                         
                            int meanList = 0;
                            int sumList = 0;

                            if (List.Count == 0)
                            {
                                Console.WriteLine("Unable to calculate the mean - no data");
                            }
                            else
                            {
                                for (int i = 0; i < List.Count; i++)
                                {
                                    sumList += List[i];
                                }
                                meanList = sumList / List.Count;
                                Console.WriteLine($"the mean is : {meanList}");
                            }
                            break;
                        }
                    // Calculate minimum value of the list by assign min value to first element then check if the element smaller than first element ::
                    case 'S':
                        {
                            int minList = List[0];
                            if (List.Count == 0)
                            {
                                Console.WriteLine("Unable to determine the smallest number - list is empty");
                            }
                            else
                            {
                                for (int i = 0; i < List.Count; i++)
                                {
                                    if (List[i] < minList)
                                    {
                                        minList = List[i];
                                    }
                                }
                                Console.WriteLine($"the smallest number is : {minList}");
                            }
                            break;
                        }
                    // Calculate maximum value of the list by assign max value to first element then check if the element greater than first element ::
                    case 'L':
                        {
                            int maxList = List[0];
                            if (List.Count == 0)
                            {
                                Console.WriteLine("Unable to determine the largest number - list is empty");
                            }
                            else
                            {
                                for (int i = 0; i < List.Count; i++)
                                {
                                    if (List[i] > maxList)
                                    {
                                        maxList = List[i];
                                    }
                                }
                                Console.WriteLine($"the largest number is : {maxList}");
                            }
                            break;
                        }
                     // Find the index of element that the user enter
                    case 'F':
                        {
                            int findElement = List[0];

                            if (List.Count == 0)
                            {
                                Console.WriteLine(" list is empty ");
                            }
                            else
                            {
                                Console.WriteLine("inter the number can you get :");
                                findElement = int.Parse(Console.ReadLine());
                                for (int j = 0; j <= List.Count; j++)
                                {
                                    if (List[j] == findElement)
                                    {
                                        Console.WriteLine($"the number {findElement} is in index {j}");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Element {findElement} is not in the list !!");
                                        break;
                                    }
                                }
                            }
                            break;
                        }
                    // Delete all elements of the list 
                    case 'C':
                        {
                            
                                if (List.Count == 0)
                                {
                                    Console.WriteLine("the list is absloutly empty !! ");
                                }
                                else
                                {
                                    List.Clear();
                                    Console.WriteLine("the list has cleared");
                                }
                            
                             break;
                        }
                     // Exit the program
                    case 'Q':
                        {
                            Console.WriteLine("Goodbye!!!!!");
                            X = false;
                            break;
                        }
                    // Default of enter wrong choice
                    default:
                        Console.WriteLine("\"Unknown selection, please try again\"");

                        Console.ReadKey();
                        break;

                }
            }
            while (X = true);
            
           
        }
    }
}
