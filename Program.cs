// string subject = "Программирование";

// foreach (char letter in subject)
// {
//     Console.WriteLine(letter);
// }

// Console.WriteLine($"Общее количество букв: {subject.Length}");




// int[] grades = { 4, 5, 3, 5, 4 };
// int sum = 0;

// foreach (int grade in grades) {
//     Console.WriteLine(grade);
//     sum += grade;
// }

// double check = (double)sum / grades.Length;

// Console.WriteLine($"Сумма всех оценок: {sum}");
// Console.WriteLine($"Средний балл: {check}");



// string[] students = { "Аня", "Ярослав", "Вика" };
// int count = 0;

// foreach (string student in students)
// {
//     Console.WriteLine(student);
//     count++;
// }

// Console.WriteLine($"Всего учеников: {count}");




// int[] points = { 10, 20, 15 };

// foreach (int point in points)
// {
//     point = point + 5;
// }




// int[] points = { 10, 20, 15 };
// for (int i = 0; i < points.Length; i++)
// {
//     points[i] = points[i] + 5;
//     Console.WriteLine(points[i]);
// }



// string[] students = { "Аня", "Борис", "Вика" };
// int number = 1;

// foreach (string student in students)
// {
//     Console.WriteLine($"{number}. {student}");
//     number++;
// }



// //А
// int[] numbers = { 1, 3, 5, 10, 7 };
// int sum = 0;

// foreach (int num in numbers)
// {
//     Console.WriteLine(num);
//     sum += num;
// }
// Console.WriteLine($"Сумма всех чисел: {sum}");


// //Г
// int[] grades = { 1, 2, 3, 4, 5, 4, 2 };

// int maxGrade = grades[0];

// foreach (int grade in grades)
// {
//     if (grade > maxGrade)
//     {
//         maxGrade = grade;
//     }
// }

// Console.WriteLine($"Наибольшая оценка: {maxGrade}");




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





//4
int[] prices = { 100, 600, 400, 1200, 300, 700 };

int sum = 0;
int count = 0;

foreach (int p in prices) {
    sum += p;

    if (p > 500) {
        count++; 
    }
}

Console.WriteLine($"Сумма: {sum}");
Console.WriteLine($"Количество товаров дороже 500: {count}");

//9
int[] a = { 10, 20, 30 };

for (int i = 0; i < a.Length; i++) {
    a[i] = a[i] + 1;
    Console.WriteLine(a[i]);
}

