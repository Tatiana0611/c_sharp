﻿int[] array = {1, 9, 2, 4, 3, 5, 6, 7, 8, 9};

int n = array.Length;
int find = 9;

int index = 0;
while (index < n)
{
    if (array[index] == find) 
        {
            Console.WriteLine(index);
            break;
        }
    index++;
}
