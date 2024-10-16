namespace TupleBasedKeyforDictionary
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a dictionary using a Tuple as the key
            Dictionary<Tuple<int, string>, string> dictionary = new Dictionary<Tuple<int, string>, string>();

            // Add elements to the dictionary
            dictionary.Add(Tuple.Create(1, "apple"), "red");
            dictionary.Add(Tuple.Create(2, "banana"), "yellow");
            dictionary.Add(Tuple.Create(3, "orange"), "orange");

            // Access elements using the tuple key
            string color = dictionary[Tuple.Create(2, "banana")];
            Console.WriteLine("Color of banana: " + color);

            // Iterate through the dictionary
            foreach (KeyValuePair<Tuple<int, string>, string> kvp in dictionary)
            {
                Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
            }
        }
    }
}
