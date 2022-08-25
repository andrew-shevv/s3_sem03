// Доп. задача
// Написать программу для разворота массива

void FillArray(int[] collection){
    for (int i = 0; i < collection.Length; i++){
        collection[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] collection){
    for (int i = 0; i < collection.Length; i++){
        Console.Write(collection[i] + " ");
    }
}

void Reverse(int[] collection){
    for (int i = 0; i < collection.Length / 2; i++){
        int temp = collection[i];
        collection[i] = collection[collection.Length - i - 1];
        collection[collection.Length - i - 1] = temp;
    }
}

int[] array = new int[7];

FillArray(array);
PrintArray(array);

Console.WriteLine();

Reverse(array);
PrintArray(array);

// Альтернатива без составления собственного метода: Array.Reverse(array);