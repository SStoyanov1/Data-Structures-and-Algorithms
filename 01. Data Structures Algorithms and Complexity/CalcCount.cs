// What is the expected running time of the following C# code? Explain why.
    private static long CalcCount(int[,] matrix)
    {
        long count = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
            if (matrix[row, 0] % 2 == 0)
                for (int col = 0; col < matrix.GetLength(1); col++)
                    if (matrix[row, col] > -1)
                        count++;
        return count;
    }

    // ANSWER:
    // The method will run in O(n*m) time (quadratic).
    // The outer 'if' condition will be checked 'n' times, 
    // so the inner 'if' will be checked 'n*m' times in the worst case.