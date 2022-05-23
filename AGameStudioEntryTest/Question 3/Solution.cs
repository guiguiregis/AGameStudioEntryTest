using System;
public class Solution
{
    public int solution(int[] A)
    {

        int r = 0;

        if (A.Length >= 1 && A.Length <= 100000)
        {
            for (int i = 0; i < A.Length; i++)
            {

                if (A[i] == 0)
                {
                    for (int j = 0; j < A.Length; j++)
                    {
                        if (A[j] == 1 && j > i)
                        {
                            r++;

                        }

                    }
                }
            }
        }

        if (r < 1000000000)
            return r;
        else return -1;

    }
}
