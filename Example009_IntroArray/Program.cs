﻿//Нахождение максимума
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = { 12, 23, 34, 43, 55, 26, 717, 28, 19 };
int result = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));
Console.WriteLine(result);

//array[0] = 12;
//Console.WriteLine(array[8]);

//int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3)); 
//Console.WriteLine(max);
