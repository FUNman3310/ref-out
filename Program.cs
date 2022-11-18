int[] arr = {1,2,3,4,5};
ChangeArr(arr);

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}


static void ChangeArr( params int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = 0;
    }
}