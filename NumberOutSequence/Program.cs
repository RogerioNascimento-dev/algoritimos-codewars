

Console.WriteLine(NumberOutSequence(new int[] { 1, 3, 6, 5, 4, 1, 2 }));

/*
 * Menor numero restante na sequencia maior q 0 ou próximo número
 */
int NumberOutSequence(int[] A)
{
    Array.Sort(A);


    int ret = 1;
    bool found = false;
    if (A[A.Length - 1] < 0)
    {
        ret = 1;
    }
    else
    {
        int cont = 0;
        while (!found)
        {
            if (!A.Any(ale => ale == A[cont] + 1))
            {
                ret = A[cont] + 1;
                found = true;
            }
            cont++;
        };
    }

    return ret;
}