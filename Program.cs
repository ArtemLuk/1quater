
string[] GetArray(int N){
    string [] arr = new string [N];
    for (int i=0; i<N; i++){
        Console.WriteLine($"Pleasee enter {i+1} string: ");
        arr[i]= Console.ReadLine();
    }
    return arr;
}

string[] NewArray(string[] array, int maxLength){
    int i = 0;
    foreach (string el in array)
        if (el.Length <= maxLength)
            i++;

    string[] newarray = new string[i];
    i = 0;
    foreach (string el in array)
        if (el.Length <= maxLength)
        {
            newarray[i] = el;
            i++;
        }
    return newarray;
}

void Printarray(string [] array){
    Console.Write("[");
    foreach (string el in array)
        Console.Write(el + ", ");
    
Console.Write("]");
}

Console.Clear();
Console.WriteLine("Please the quantity of strings: ");
int a = int.Parse(Console.ReadLine());


string [] A = GetArray(3);
Console.WriteLine("Current array is: ");
Printarray(A);
Console.WriteLine();
Console.WriteLine("Updated array is: ");
Printarray(NewArray(A, 3));