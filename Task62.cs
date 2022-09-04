// See https://aka.ms/new-console-template for more information
void PrintMatrix(int[,] anyMatrix)
{
    for (int i = 0; i < anyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < anyMatrix.GetLength(1); j++)
        {
            Console.Write(anyMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int M = 4,
    N = 4;
int[,] matrix = new int[M, N];
int row = 0,
    col = 0,
    stepCol = 1,
    stepRow = 0,
    turn = 0,
    dist = N;

for (int i = 0; i < matrix.Length; i++)
{
    matrix[row, col] = i;
    if (--dist == 0) // что означает -- перед dist
    {
        dist = N * (turn % 2) + M * ((turn + 1) % 2) - 2 - (turn / 2 - 1);
        int temp = stepCol;
        stepCol = -stepRow;
        stepRow = temp;
        turn++;
    }
    col += stepCol;
    row += stepRow;
}
PrintMatrix(matrix);
