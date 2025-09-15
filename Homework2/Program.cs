// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Lida Shubitidze");
Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Magenta;

Console.WriteLine("Please input your text here:");
string inputFromUser = Console.ReadLine();
Console.WriteLine($"You input was: {inputFromUser}");

Console.WriteLine("Bye, bye for now.");
*/


using Homework2;

#region Exercise 1
Employee employee = new Employee("Lana", "Beradze", 23, "Manager", [8, 8, 8, 8, 9, 0, 0]);
Console.WriteLine(employee.weeklyTotal());
employee.weeklyAmount = [9, 9, 9, 9, 9, 4, 4];
Console.WriteLine(employee.weeklyTotal());
employee.position = "tester";
employee.weeklyAmount = [9, 9, 9, 9, 9, 9, 4];
Console.WriteLine(employee.weeklyTotal());

// Foreign Company
Company company = new Company(true);
Console.WriteLine(company.toGovernment(employee.weeklyTotal()));
// Local Company
company.isForeign = false;
Console.WriteLine(company.toGovernment(employee.weeklyTotal()));
#endregion

#region Exercise 2
Student student = new Student("Lana", 20, 2024);
student.yearsLeftUntilGraduation();
Teacher teacher = new Teacher("Lana", true);
teacher.getSubjectFromStudent(student.getRandomSubject());
#endregion


#region Exercise 3

GoodStudent goodStudent = new GoodStudent("Lana");
goodStudent.Relax();
goodStudent.Write();
LazyStudent lazyStudent = new LazyStudent("Luise");
lazyStudent.Relax();
lazyStudent.Write();
Student1 student1 = new Student1("Hana");
ClassRoom classRoom = new ClassRoom(new List<Student1>([student1, goodStudent, lazyStudent]));
classRoom.getAllStudentInfo();
#endregion