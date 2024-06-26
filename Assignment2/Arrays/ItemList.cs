namespace Assignment2;

public class ItemList
{
    public List<string> itemList { get; set; }

    public void Tally()
    {
        while (true)
        {
            
            Console.WriteLine("Current List: ");
            if (itemList.Count == 0)
            {
                Console.WriteLine("List Empty");
            }
            else
            {
                foreach (string itemInList in itemList)
                {
                    Console.WriteLine($"- {itemInList}");
                }
            }
            
            Console.WriteLine("");
            
            
            Console.WriteLine("Enter command (+ item, - item, or -- to clear. Write 'exit' to end the application)):");
            string command = Console.ReadLine();
        
            string item = command.Substring(2).Trim();
        
            if (string.IsNullOrEmpty(command))
            {
                Console.WriteLine("Enter a valid command");
            }
        
            else if (command.StartsWith("+ "))
            {
                itemList.Add(item);
                Console.WriteLine($"Added: {item}");
            }
             
            
            else if (command.StartsWith("- "))
            {
                if (itemList.Remove(item))
                {
                    Console.WriteLine($"Removed: {item}");
                }
                else
                {
                    Console.WriteLine("Item not found");
                }
                
            }
            
            else if (command.StartsWith("--"))
            {
                itemList.Clear();
                Console.WriteLine("List Cleared!!");
            }
            
            else if(command.Equals("exit"))
            {
                break;
            }
        
            else
            {
                Console.WriteLine("Invalid command. Please try again.");
            }

        
        }
    }
    
    
}