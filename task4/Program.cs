/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int InputNum (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}

int [,,] SetArray3DRandom (int row, int line, int column)
{
    int start = 10;
    int [] number = new int [90];
    for (int i = 0; i < 90; i++)
    {
        number [i] = start++;
    }

    for (int i = 0; i < 90; i++)
    {
        int idx = new Random ().Next (0, 90);
        int tempNmr = number [idx];
        number [idx] = number [i];
        number [i] = tempNmr;
    }
    int nbrIdx = 0;
    int [,,] numArr3D = new int [row, line, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < line; j++)
        {
            for (int k = 0; k < column; k++)
            {
                numArr3D [i, j, k] = number [nbrIdx++];
            }
        }
    }
    return numArr3D;
}

void PrintArray3D (int [,,] array3D) 
{
    for (int i = 0; i < array3D.GetLength (0); i++)
    {
        for (int j = 0; j < array3D.GetLength (1); j++)
        {
            for (int k = 0; k < array3D.GetLength (2); k++)
            {
                Console.Write ($"{array3D [i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine ();
        }
    }
}

int k = InputNum ("Enter the number of array rows: ");
int m = InputNum ("Enter the number of array lines: ");
int n = InputNum ("Enter the number of array columns: ");
Console.WriteLine ();

if (k*m*n > 90)
{
    Console.WriteLine ("The dimension of the array exceeds the allowable, possible repetitions of numbers!");
    return;
}

int [,,] array3D = SetArray3DRandom (k, m, n);

Console.WriteLine ($"3D array with element indices:");
PrintArray3D (array3D);