// Вариант 1:

/*int[] CreateArray(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8)

{
    int[] array = {n1,n2,n3,n4,n5,n6,n7,n8};
  
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine(); 
}

Console.Write("Input number 1: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number 2: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number 3: ");
int n3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number 4: ");
int n4 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number 5: ");
int n5 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number 6: ");
int n6 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number 7: ");
int n7 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number 8: ");
int n8 = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(n1, n2, n3, n4, n5, n6, n7, n8);

ShowArray(myArray);*/

// Вариант 2:

int[] CreateArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next();
    }

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine(); 
}

Console.Write("Введите число элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size);
ShowArray(myArray);