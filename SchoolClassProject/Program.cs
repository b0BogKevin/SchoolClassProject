using SchoolClassProject.Model;
using SchoolClassProject.Repo;

SchoolClass schoolClass = new SchoolClass(9,'a',9000,2);
SchoolClass schoolClass2 = new SchoolClass(9, 'b', 6000,4);

Console.WriteLine(schoolClass);
Console.WriteLine(schoolClass.HigherFee(schoolClass2));

SchoolClassRepo repo = new();

Console.WriteLine("Osztályonkénti összes osztálypénz 10hónap alatt: ");
foreach (var sc in repo.SchoolClasses)
{
    Console.WriteLine($"{sc.Year}.{sc.SchoolType}: {sc.MonthlyFee * sc.NumberOfStudents * 10}");
}