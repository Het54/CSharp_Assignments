// See https://aka.ms/new-console-template for more information

using Classes;
using Classes.Abstraction;

Console.WriteLine("Designing and Building Classes using object-oriented principles");
Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine();

Console.WriteLine("Welcome to School Management System");
Console.WriteLine();

ManageStudent manageStudent = new ManageStudent();

ManageInstructor manageInstructor = new ManageInstructor();


Console.WriteLine("Press 1 to Manage Student's Record");
Console.WriteLine("Press 2 to Manage Instructor's Record");
Console.WriteLine("Press 9 to Exit");



int choice = int.Parse(Console.ReadLine());

while (choice != 9)
{
    switch (choice)
    {
        case 1: 
            Console.Clear();
            manageStudent.Run();
            break;
        case 2:
            Console.Clear();
            manageInstructor.Run();
            break;
        default:
            Console.WriteLine("Invalid Option");
            break;
    }
    Console.Clear();
    Console.WriteLine("--------------------School Management System--------------------");
    Console.WriteLine("Press 1 to Manage Student's Record");
    Console.WriteLine("Press 2 to Manage Instructor's Record");
    Console.WriteLine("Press 9 to Exit");
    choice = int.Parse(Console.ReadLine());
}



