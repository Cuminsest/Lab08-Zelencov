/*int lessonNumber = 5;
int totalLessons = 5;

while (lessonNumber <= totalLessons)
{
    Console.WriteLine($"Пара {lessonNumber}");
    lessonNumber--;
}


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



int sum = 0;
int count = 0;
int max = int.MinValue;

Console.WriteLine("Введите оценки, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());

while (grade != -1)
{
    sum += grade;
    count++;

    if (grade > max)
    {
        max = grade;
    }

    grade = int.Parse(Console.ReadLine());
}

if (count > 0)
{
    Console.WriteLine($"Средний балл: {(double)sum / count}");
    Console.WriteLine($"Наибольшая оценка: {max}");
}
else
{
    Console.WriteLine("Оценок не было введено");
}

string correctPassword = "qwerty123";
int attempts = 0;

while (true)
{
    Console.Write("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();

    if (password == correctPassword)
    {
        Console.WriteLine("Доступ разрешён");
        break;
    }

    attempts++;
    Console.WriteLine("Неверный пароль, попробуйте снова");
}

Console.WriteLine($"Неудачных попыток: {attempts}");


string answer;

do
{
    Console.Write("Введите дату посещения (например, 01.09): ");
    string date = Console.ReadLine();
    Console.WriteLine($"Запись добавлена: {date}");

    Console.Write("Добавить ещё одну запись? (да/нет): ");
    answer = Console.ReadLine();
} while (answer == "да");

Console.WriteLine("Дневник сохранён");


int N = 7;
int i = 1;

while (i <= 10)
{
    Console.WriteLine($"{N} x {i} = {N * i}");
    i++;
}



int count = 0;

Console.WriteLine("Введите имена учеников, для завершения введите «конец»:");
string name = Console.ReadLine();

while (name != "конец")
{
    Console.WriteLine($"Принято: {name}");
    count++;
    name = Console.ReadLine();
}

Console.WriteLine($"Всего имён введено: {count}");



Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();
if (string.IsNullOrEmpty(surname)) {
Console.WriteLine("Фамилия не введена. Завершение работы.");
return;
}
Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
var assigned = Enumerable.Range(1, 10)
.OrderBy(_ => rnd.Next())
.Take(2)
.OrderBy(x => x)
.ToList();
Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


int count = 0;

Console.WriteLine("Вводите символы по одному, для завершения введите q:");
string symbol = Console.ReadLine();

while (symbol != "q")
{
    count++;
    symbol = Console.ReadLine();
}

Console.WriteLine($"Введено символов до q: {count}");
*/

Console.WriteLine("Введите целое положительное число:");
int number = int.Parse(Console.ReadLine());
int count = 0;

while (number != 0)
{
    number /= 10;
    count++;
}

Console.WriteLine($"Количество цифр: {count}");
