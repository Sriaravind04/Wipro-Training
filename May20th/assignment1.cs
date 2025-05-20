using System;
using System.Diagnostics;

class SortingAlgorithm {


    //Generating random array
    static int[] GenerateRandomArray(int size) {
        Random r = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++) {
            array[i] = r.Next(1,100);
        }
        return array;
    }

    //Bubble sort
    static void BubbleSort(int[] array) {
        for (int i = 0; i < array.Length; i++) {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }


    //selection sort
    static void SelectionSort(int[] array) {
        for (int i = 0; i < array.Length - 1; i++) {
            int min = i;
            for (int j = i + 1; j < array.Length; j++) {
                if (array[j] < array[min]) {
                    min = j;
                }
                if (min != i)
                {
                    int temp = array[i];
                    array[i] = array[min];
                    array[min] = temp;
                }
            }
        }
    }
    //Insertion sorting algorithm
    static void InsertionSort(int[] array) {
        for (int i = 0; i < array.Length; i++) { 
            int key = array[i];
            int j = i - 1;
            while (j >= 0 && array[j] > key) {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
            }
        }
    static void Main()
    {
        int[] originalArray = GenerateRandomArray(20);

        //Bubble sort
        int[] bubbleArray = (int[])originalArray.Clone();
        Stopwatch sw1 = Stopwatch.StartNew();
        BubbleSort(bubbleArray);
        sw1.Stop();

        //selection sort
        int[] selectionArray = (int[])originalArray.Clone();
        Stopwatch sw2 = Stopwatch.StartNew();
        SelectionSort(selectionArray);
        sw2.Stop();

        //insertion sort
        int[] insertionArray = (int[])originalArray.Clone();
        Stopwatch sw3 = Stopwatch.StartNew();
        InsertionSort(insertionArray);
        sw3.Stop();

        Console.WriteLine("Original Array:     " + string.Join(", ", originalArray));
        Console.WriteLine("Bubble sorted:      " + string.Join(", ", bubbleArray) + $" | Time: {sw1.ElapsedTicks} ticks");
        Console.WriteLine("Selection sort:     " + string.Join(", ", selectionArray) + $" | Time: {sw2.ElapsedTicks} ticks");
        Console.WriteLine("Insertion sort:     " + string.Join(", ", insertionArray) + $" | Time: {sw3.ElapsedTicks} ticks");

    }
}