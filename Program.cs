using System;
using static System.Console;

Clear();
int[] array = randomArray(4);
WriteLine($"[{string.Join(",",array)}] -> {countOfEven(array)}");

int[] randomArray(int size) {
    Random random = new Random();
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++) {
        array[i] = random.Next(100,1000);
    }
    return array;
}

int countOfEven(int[] array) {
    int count = 0;
    for(int i = 0; i < array.Length; i++) {
        if(array[i] % 2 == 0) {
            count++;
        }
    }
    return count;
}