using System;
using System.Linq;

public class Solution
{
    public int solution(int X, int[] A)
    {
        int ready = 0;
        int r = -1;
        int[] B = new int[A.Length];

        if (X >= 1 && X <= 100000 && A.Length >= 1 && A.Length <= 100000)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] >= 1 && A[i] <= X)
                {
                    if (!B.Contains<int>(A[i]))
                    {
                        B[i] = A[i];
                        r = i;
                        ready++;
                    }

                    if (ready == X)
                    {
                        break;
                    }
                }

            }
        }


        return r;
    }
}
