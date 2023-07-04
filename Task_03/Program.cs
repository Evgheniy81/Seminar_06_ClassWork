

/*Мария Харченко, [27.06.2023 21:57]

Напишите программу, которая будет создавать копию заданного 
массива с помощью поэлементного копирования.
*/

int[] CreateArray(int size, int min, int max){
    int[] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(min, max);
    }
    return array;
}

int[] array = CreateArray(20, 0, 10);
Console.WriteLine($"Our list [{string.Join(", ", array)}]");


int[] CopyArray (int[] array){
    int[] copyArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++){
        copyArray[i] = array[i];
        //copyArray[i] = array[i]*-1; // Так можно получить отрицательные числа
    }
    return copyArray;
}

int[] copyArray = CopyArray(array);
Console.WriteLine($"Copy list[{string.Join(", ", copyArray)}]");
