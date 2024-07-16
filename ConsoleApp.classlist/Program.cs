
using System.Collections.Generic;

Console.WriteLine("********** - Class List - **********");

string name ="", surname;
List<string> classroom = new List<string>();

while(name is not "done")
{
    
    Console.WriteLine();
    Console.WriteLine("Add Learner:");
    Console.WriteLine();

    Console.Write("Name: ");
    name = Console.ReadLine();

    if(name == "done")
    {
        break;
    }
    Console.Write("Surname: ");

    surname = Console.ReadLine();

    AddLearner(name , surname);

    if(name == "Michael")
    {
        name = "Money Mike";
    }

    classroom.Add(AddLearner(name,surname));

}

ClassList();


void ClassList()
{
    foreach(string learner in classroom)
    {
        Console.Clear();
        Console.Write("***** - Class List - *****");
        Console.WriteLine();
        Console.WriteLine(learner);
    }
}

string AddLearner(string name, string surname)
{
    return name + " " + surname;
}