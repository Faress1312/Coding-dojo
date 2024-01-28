// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// int start = 1 ;
// int end = 255;
 
// // for (int i = start; i <= end; i++)
 
// //  System.Console.WriteLine(i);
// Random rand = new Random();
// // for(int j = 0; j <= 20; j++)
// {
//     // Console.WriteLine(rand.Next(10,20));
// }

//         for (int i = 1; i <= 100; i++){
//             if (i % 3 == 0) 
//         {
            
            
                 
//                     System.Console.WriteLine("fizz");
//                 }else {
            
//         System.Console.WriteLine(i);
//         }
//         }
// string[] namesArray =  { " Tim", "nikki", "sarra ", "chiraz "}; 
// bool[] boolArray = new bool[10] ;
// for (int i = 0 ; i < boolArray.Length ; i++)
// {   
//  boolArray[i] = i % 2 == 0;
// }
// System.Console.WriteLine("Names:");
//         foreach (string name in namesArray)
//         {
//             Console.WriteLine(name);
//         }

//         Console.WriteLine("\nBoolean Array:");
//         foreach (bool value in boolArray)
//         {
//             Console.WriteLine(value);
//         }
// string[] drivers = new string[] { "FRUITS", "PANDA", "TAZ", "MA MEN" };
// // The 'Length' property tells us how many values are in the array (4 in our example here). 
// // We can use this to determine where the loop ends
// for (int idx = 0; idx < drivers.Length; idx++)
// {
//     Console.WriteLine($"iam {drivers[idx]}\n idrive these bikes :");
// }






// List<string> bikes = new List<string>();
// bikes.Add("Kawasaki");
// bikes.Add("Triumph");
// bikes.Add("BMW");
// bikes.Add("Moto Guzzi");
// bikes.Add("Harley Davidson");
// bikes.Add("Suzuki");

// // Console.WriteLine(bikes[2]); 
// // Console.WriteLine($"We currently know of {bikes.Count} motorcycle manufacturers.");


//     // Using our list of motorcycle manufacturers from before
// // we can easily loop through the list of them with a for loop
// // this time, however, Count is the attribute for a number of items.
// Console.WriteLine("The current manufacturers we have seen are:");
// for (int idx = 0; idx < bikes.Count; idx++)
// {
//     Console.WriteLine("-" + bikes[idx]);
// }
// // Insert a new item between a specific index
// bikes.Insert(2, "Yamaha");
// // Removal from List
// // Remove is a lot like Javascript array pop, but searches for a specified value
// // bikes.Remove("Suzuki");
// // bikes.Remove("Yamaha");
// bikes.Remove(bikes[3]);  
// System.Console.WriteLine(bikes.Count);
// // Console.WriteLine("List of Non-Japanese Manufacturers:");
// // foreach (string manu in bikes)
// // {
// //     Console.WriteLine("-" + manu);
// // }




// Dictionary<string,string> profile = new Dictionary<string,string>();
// // We add values to our dictionary the same way we add in Lists
// // But remember to specify the key AND value
// // When we add, we first specify the key, then the value
// profile.Add("Name", $"{drivers[0]}");
// profile.Add("bike", $"{bikes[3]}");
// profile.Add("Location", "England");
// // Now we can render the data like so
// Console.WriteLine("Student profile");
// // Notice how we use ["KeyName"] to pull the value out
// Console.WriteLine("Name - " + profile[$"{drivers[0]}"]);
// Console.WriteLine("From - " + profile["Location"]);
// Console.WriteLine("Favorite Language - " + profile[$"{bikes[3]}"]);



// class Program
// {
//     static void Main()
//     {
//         // Create a List of ice cream flavors
//         List<string> flavors = new List<string> { "Chocolate", "Vanilla", "Strawberry", "Mint Chip", "Rocky Road", "Cookie Dough" };

//         // Output the length of the List after adding flavors
//         Console.WriteLine($"Length of flavors List: {flavors.Count}");

//         // Output the third flavor in the List
//         Console.WriteLine($"Third flavor in the List: {flavors[2]}");

//         // Remove the third flavor using its index location
//         flavors.RemoveAt(2);

//         // Output the length of the List again
//         Console.WriteLine($"Length of flavors List after removal: {flavors.Count}");

//         // Create a dictionary to store user names and ice cream flavors
//         Dictionary<string, string> userDictionary = new Dictionary<string, string>();

//         // Add key/value pairs to the dictionary
//         string[] names = { "Alice", "Bob", "Charlie", "David", "Eva" };

//         Random random = new Random();
//         foreach (string name in names)
//         {
//             int randomIndex = random.Next(flavors.Count);
//             string randomFlavor = flavors[randomIndex];
//             userDictionary.Add(name, randomFlavor);
//         }

//         // Loop through the dictionary and print out each user's name and their associated ice cream flavor
//         foreach (var pair in userDictionary)
//         {
//             Console.WriteLine($"{pair.Key}: {pair.Value}");
//         }
//     }
// }
// Notice how we specify that we will take in a string called firstName within the parentheses


// static void PrintList(List<string> MyList)
// {
// }
// List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
// PrintList(TestStringList);
// for (int idx = 0; idx < TestStringList.Count; idx++)
// {
//     // Console.WriteLine("-" + TestStringList[idx]);
// }

// static void SumOfNumbers(List<int> IntList)
// {
//     int sum = 0;
//     foreach (int num in IntList)
//     {
//         sum += num;
//     }
//     Console.WriteLine(sum);}
// List<int> TestIntList = new List<int>() {2,7,12,9,3};
// SumOfNumbers(TestIntList);

// static int FindMax(List<int> IntList)
// {
//     int max = IntList[0];
//     foreach (int num in IntList)
//     {
//         if (num > max)
//         {
//             max = num;
//         }
//     }
//     return max;
//     }
// List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};
// FindMax(TestIntList2);
// System.Console.WriteLine(FindMax(TestIntList2));




// class Program
// {
//     static List<int> SquareValues(List<int> IntList)
//     {
//         List<int> squaredList = new List<int>();
        
//         foreach (int num in IntList)
//         {
//             squaredList.Add(num * num);
//         }
        
//         return squaredList;
//     }

//     static void Main(string[] args)
//     {
//         List<int> TestIntList3 = new List<int>() {1, 2, 3, 4, 5};
//         List<int> squaredValues = SquareValues(TestIntList3);

//         Console.Write("[");
//         foreach (int num in squaredValues)
//         {
//             Console.Write(num + ",");
//         }
//         Console.WriteLine("]");
//     }
// }




// static int[] NonNegatives(int[] IntArray)
// {
//     for (int i = 0; i < IntArray.Length; i++)
//     {
//         if (IntArray[i] < 0)
//         {
//             IntArray[i] = 0;
//         }
//     }
//     return IntArray;
// }
// int[] TestIntArray = new int[] {-1,2,3,-4,5};
//     int[] result = NonNegatives(TestIntArray);

//     // Print the result
//     Console.Write("[");
//     foreach (int num in result)
//     {
//         Console.Write(num + ",");
//     }
//     Console.WriteLine("]");NonNegatives(TestIntArray);





// static void PrintDictionary(Dictionary<string,string> MyDictionary)
// {
//     // Your code here
// }
// Dictionary<string,string> TestDict = new Dictionary<string,string>();
// TestDict.Add("HeroName", "Iron Man");
// TestDict.Add("RealName", "Tony Stark");
// TestDict.Add("Powers", "Money and intelligence");
// PrintDictionary(TestDict);

// Console.WriteLine("heros dictionary: ");
// // Notice how we use ["KeyName"] to pull the value out
// Console.WriteLine("Name - " + TestDict["HeroName"]);
// Console.WriteLine("From - " + TestDict["RealName"]);
// Console.WriteLine("Favorite Language - " + TestDict["Powers"]);







// class Program
// {
//     static bool FindKey(Dictionary<string, string> MyDictionary, string SearchTerm)
//     {
//         foreach (string key in MyDictionary.Keys)
//         {
//             if (key == SearchTerm)
//             {
//                 return true;
//             }
//         }
//         return false;
//     }

//     static void Main(string[] args)
//     {
//         Dictionary<string, string> TestDict = new Dictionary<string, string>()
//         {
//             {"Name", "maaked"},
//             {"Age", "30"},
//             {"RealName", "Jaser"}
//         };

       
//         Console.WriteLine(FindKey(TestDict, "RealName")); 
//         Console.WriteLine(FindKey(TestDict, "azazaz"));     
//     }
// }






// class Program
// {
//     static Dictionary<string, int> GenerateDictionary(List<string> Names, List<int> Numbers)
//     {
//         Dictionary<string, int> resultDict = new Dictionary<string, int>();

//         if (Names.Count != Numbers.Count)
//         {
//            System.Console.WriteLine("Number of names must match the number of numbers.");
//         }

//         for (int i = 0; i < Names.Count; i++)
//         {
//             resultDict.Add(Names[i], Numbers[i]);
//         }

//         return resultDict;
//     }

//     static void Main(string[] args)
//     {
//         List<string> names = new List<string>() { "Julie", "Harold", "James", "Monica" };
//         List<int> numbers = new List<int>() { 6, 12, 7, 10 };

//         Dictionary<string, int> result = GenerateDictionary(names, numbers);

//         System.Console.WriteLine("Generated Dictionary:");
//         foreach (var amg in result)
//         {
//             System.Console.WriteLine($"\"{amg.Key}\": {amg.Value}");
//         }
//     }
// }







//PUZZLE








string flipResult = CoinFlip();
Console.WriteLine("The coin landed on: " + flipResult);


static string CoinFlip()
{
    Random random = new Random();
    int result = random.Next(2);

    if (result == 0)
    {
        return "heads";
    }
    else
    {
        return "tails";
    }
}




int dicerolll = DiceRoll();
Console.WriteLine( dicerolll);


static int DiceRoll()
{
    Random random = new Random();
    int result = random.Next(6);


 

        return result+1;

}


    static void StatRoll()
    {
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(RollDice());
        }
    }

    static int RollDice()
    {
        Random random = new Random();
        return random.Next(1, 7);
    }

    StatRoll();



static void RollUnit()
{
       int targetNumber = 3; 
        string rollResult = RollUntil(targetNumber);
        Console.WriteLine(rollResult);
}
 static string RollUntil(int targetNumber)
    {
        Random random = new Random();
        int count = 0;
        int result;

        do
        {
            result = random.Next(1, 7);
            count++;
        } while (result != targetNumber);

        return $"Rolled a {targetNumber} after {count} tries";
    }

RollUnit();