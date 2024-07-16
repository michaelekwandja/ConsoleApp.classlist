
List<string> classroom = new List<string>();
string name = ""; 
string surname;

while (name != "done")
{
    Console.WriteLine();
    Console.WriteLine("Add Learner:");
    Console.WriteLine();

    Console.Write("Name: ");
    name = Console.ReadLine();

    if (name == "done")
    {
        break;
    }

    Console.Write("Surname: ");
    surname = Console.ReadLine();

    if (name == "Michael")
    {
        name = "Money Mike";
    }

    classroom.Add($"{name} {surname}");
}


Console.Clear();
Console.WriteLine("***** - Class List - *****");
foreach (string learner in classroom)
{
    Console.WriteLine(learner);
}