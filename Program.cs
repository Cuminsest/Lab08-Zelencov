/*int lessonNumber = 5;
int totalLessons = 5;

while (lessonNumber <= totalLessons)
{
    Console.WriteLine($"Пара {lessonNumber}");
    lessonNumber--;
}
*/

Console.WriteLine("Введите оценки по одной, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());
int count = 0;

while (grade != -1)
{
    Console.WriteLine($"Оценка принята: {grade}");
    count++;
    grade = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Введено оценок: {count}");
Console.WriteLine("Ввод завершён");
