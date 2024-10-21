const int ArraySize = 10;
string[] hashTable = new string[ArraySize];

static int BasicHashFunction(string key, int arraySize)
{
    int hash = 0;
    foreach (char c in key)
    {
        hash += c;
    }
    return hash % arraySize;
}

static void Insert(string key, string value, string[] hashTable)
{
    int index = BasicHashFunction(key, hashTable.Length);

    if (hashTable[index] == null)
    {
        hashTable[index] = value;
        Console.WriteLine($"Inserted {value} at index {index}");
    }
    else
    {
        Console.WriteLine($"Collision occured at index {index} for key {key}. Consider using collision resolution.");
    }
}

static string Retrieve(string key, string[] hashTable)
{
    int index = BasicHashFunction(key, hashTable.Length);
    return hashTable[index];
}

Insert("Alice", "Alice's Record", hashTable);
Insert("Bob", "Bob's Record", hashTable);
Insert("Charlie", "Charlie's Record", hashTable);
Insert("David", "David's Record", hashTable);

Console.WriteLine($"\nRetrieved: {Retrieve("Alice", hashTable)}");
Console.WriteLine($"Retrieved: {Retrieve("Bob", hashTable)}");
Console.WriteLine($"Retrieved: {Retrieve("Charlie", hashTable)}");
Console.WriteLine($"Retrieved: {Retrieve("David", hashTable)}");

Insert("Eve", "Eve's Record", hashTable);