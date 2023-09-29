using System;

int[] arr = { 1, 5, 2, 17, 32, 8, 91, 32, 9 };

int i = Partition(arr,1,4);
Console.WriteLine("i = "+i);


static void QuickSort(int[] arr,int start,int end) 
{
    if(start<end)
    {
        int special = Partition(arr, start, end);

        QuickSort(arr, start, special - 1);
        QuickSort(arr, special + 1, end);
    }
}


static int Partition(int[] arr, int start,int end)
{
    int special = end;

    int currentSwapPos = start;
    for (int i = start; i < end-1; i++)
    {
        if (arr[i]<arr[special])
        {
            int temp = arr[i];
            arr[i] = arr[currentSwapPos];
            arr[currentSwapPos] = temp;

            currentSwapPos++;
        }
    }
    int temp1=arr[special];
    arr[special] = arr[currentSwapPos];
    arr[currentSwapPos]=temp1;

    return currentSwapPos;
}
