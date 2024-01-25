// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int start = 1 ;
int end = 255;
 
// for (int i = start; i <= end; i++)
 
//  System.Console.WriteLine(i);
Random rand = new Random();
// for(int j = 0; j <= 20; j++)
{
    // Console.WriteLine(rand.Next(10,20));
}

        for (int i = 1; i <= 100; i++){
            if (i % 3 == 0) 
        {
            
            
                 
                    System.Console.WriteLine("fizz");
                }else {
            
        System.Console.WriteLine(i);
        }
        }
string[] namesArray =  { " Tim", "nikki", "sarra ", "chiraz "}; 
bool[] boolArray = new bool[10] ;
for (int i = 0 ; i < boolArray.Length ; i++)
{   
 boolArray[i] = i % 2 == 0;
}
System.Console.WriteLine("Names:");
        foreach (string name in namesArray)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("\nBoolean Array:");
        foreach (bool value in boolArray)
        {
            Console.WriteLine(value);
        }
string[] drivers = new string[] { "FRUITS", "PANDA", "TAZ", "MA MEN" };
// The 'Length' property tells us how many values are in the array (4 in our example here). 
// We can use this to determine where the loop ends
for (int idx = 0; idx < drivers.Length; idx++)
{
    Console.WriteLine($"iam {drivers[idx]}\n idrive these bikes :");
}






List<string> bikes = new List<string>();
bikes.Add("Kawasaki");
bikes.Add("Triumph");
bikes.Add("BMW");
bikes.Add("Moto Guzzi");
bikes.Add("Harley Davidson");
bikes.Add("Suzuki");

// Console.WriteLine(bikes[2]); 
// Console.WriteLine($"We currently know of {bikes.Count} motorcycle manufacturers.");


    // Using our list of motorcycle manufacturers from before
// we can easily loop through the list of them with a for loop
// this time, however, Count is the attribute for a number of items.
Console.WriteLine("The current manufacturers we have seen are:");
for (int idx = 0; idx < bikes.Count; idx++)
{
    Console.WriteLine("-" + bikes[idx]);
}
// Insert a new item between a specific index
bikes.Insert(2, "Yamaha");
// Removal from List
// Remove is a lot like Javascript array pop, but searches for a specified value
// bikes.Remove("Suzuki");
// bikes.Remove("Yamaha");
bikes.Remove(bikes[3]);  
System.Console.WriteLine(bikes.Count);
// Console.WriteLine("List of Non-Japanese Manufacturers:");
// foreach (string manu in bikes)
// {
//     Console.WriteLine("-" + manu);
// }




Dictionary<string,string> profile = new Dictionary<string,string>();
// We add values to our dictionary the same way we add in Lists
// But remember to specify the key AND value
// When we add, we first specify the key, then the value
profile.Add("Name", $"{drivers[0]}");
profile.Add("bike", $"{bikes[3]}");
profile.Add("Location", "England");
// Now we can render the data like so
Console.WriteLine("Student profile");
// Notice how we use ["KeyName"] to pull the value out
Console.WriteLine("Name - " + profile[$"{drivers[0]}"]);
Console.WriteLine("From - " + profile["Location"]);
Console.WriteLine("Favorite Language - " + profile[$"{bikes[3]}"]);



class Program
{
    static void Main()
    {
        // Create a List of ice cream flavors
        List<string> flavors = new List<string> { "Chocolate", "Vanilla", "Strawberry", "Mint Chip", "Rocky Road", "Cookie Dough" };

        // Output the length of the List after adding flavors
        Console.WriteLine($"Length of flavors List: {flavors.Count}");

        // Output the third flavor in the List
        Console.WriteLine($"Third flavor in the List: {flavors[2]}");

        // Remove the third flavor using its index location
        flavors.RemoveAt(2);

        // Output the length of the List again
        Console.WriteLine($"Length of flavors List after removal: {flavors.Count}");

        // Create a dictionary to store user names and ice cream flavors
        Dictionary<string, string> userDictionary = new Dictionary<string, string>();

        // Add key/value pairs to the dictionary
        string[] names = { "Alice", "Bob", "Charlie", "David", "Eva" };

        Random random = new Random();
        foreach (string name in names)
        {
            int randomIndex = random.Next(flavors.Count);
            string randomFlavor = flavors[randomIndex];
            userDictionary.Add(name, randomFlavor);
        }

        // Loop through the dictionary and print out each user's name and their associated ice cream flavor
        foreach (var pair in userDictionary)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
