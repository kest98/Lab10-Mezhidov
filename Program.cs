string subject = "Программирование";

foreach (char letter in subject)
{
    Console.WriteLine(letter);
}

Console.WriteLine($"Общее количество букв: {subject.Length}");




int[] grades = { 4, 5, 3, 5, 4 };
int sum = 0;

foreach (int grade in grades) {
    Console.WriteLine(grade);
    sum += grade;
}

double check = (double)sum / grades.Length;

Console.WriteLine($"Сумма всех оценок: {sum}");
Console.WriteLine($"Средний балл: {check}");



string[] students = { "Аня", "Ярослав", "Вика" };
int count = 0;

foreach (string student in students)
{
    Console.WriteLine(student);
    count++;
}

Console.WriteLine($"Всего учеников: {count}");




int[] points = { 10, 20, 15 };

foreach (int point in points)
{
    point = point + 5;
}




int[] points = { 10, 20, 15 };
for (int i = 0; i < points.Length; i++)
{
    points[i] = points[i] + 5;
    Console.WriteLine(points[i]);
}

