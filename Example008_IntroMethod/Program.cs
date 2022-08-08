int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 2;
int b1 = 23;
int c1 = 690;
int a2 = 4;
int b2 = 24;
int c2 = 65;
int a3 = 9;
int b3 = 25;
int c3 = 83;

int result = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));
Console.Write(result);