using System;
using System.Linq;

public class Solution
{
    public int solution(int[] A)
    {
        int r = 1;

        if (A.Length >= 1 && A.Length <= 100000)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < -1000000 || A[i] > 1000000)
                    return r;
            }
            int max = A.Max();

            if (max < 1) return 1;

            if (!A.Contains<int>(1)) return 1;
            else
            {

                for (int i = 0; i < A.Length; i++)
                {
                    r++;
                    if (!A.Contains<int>(r)) break;
                }
            }
        }

        return r;
    }
}
