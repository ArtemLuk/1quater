//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

string[] GetArray(int N){    //Ввод элементов массива с клавиатуры
    string [] arr = new string [N];
    for (int i=0; i<N; i++){
        Console.WriteLine($"Pleasee enter {i+1} string: ");
        arr[i]= Console.ReadLine();
    }
    return arr;
}

string[] NewArray(string[] array, int maxLength){   //Поиск размера нового массива и его заполнение
    int i = 0;
    foreach (string el in array)
        if (el.Length <= maxLength)
            i++;
    string[] newarray = new string[i];
    i = 0;
    foreach (string el in array)
        if (el.Length <= maxLength){
            newarray[i] = el;
            i++;
        }
    return newarray;
}

void Printarray(string [] array){  // Вывод массива строк в консоль
    Console.Write("[");
    foreach (string el in array)
        Console.Write(el + ", ");
Console.Write("]");
}

Console.Clear();
Console.WriteLine("Please the quantity of strings: ");
int a = int.Parse(Console.ReadLine());


string [] A = GetArray(a);
//string [] A = new string[] {"Hello", "2", "world", ":-)"};
//string [] A = new string[] {"1234", "1567", "-2", "computer science"};
//string [] A = new string[] {"Russia", "Denmark", "Kazan"};
Console.WriteLine("Current array is: ");
Printarray(A);
Console.WriteLine();
Console.WriteLine("Updated array is: ");
Printarray(NewArray(A, 3));