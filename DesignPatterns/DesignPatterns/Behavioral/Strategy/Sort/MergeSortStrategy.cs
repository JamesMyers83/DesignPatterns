namespace DesignPatterns.Behavioral.Strategy
{
    public class MergeSortStrategy : ISortStrategy
    {
        public void SortAscending(ref double[] numericArray)
        {
            numericArray = DivideAndSort(numericArray);
        }

        private double[] DivideAndSort(double[] numericArray)
        { 
            //if less than two elements, then nothing to split
            if (numericArray.Length < 2)
                return numericArray;

            //find middle index of array
            int middle = numericArray.Length / 2;

            //declare two arrays to split input into
            double[] a = new double[middle];
            double[] b = new double[numericArray.Length - middle];

            for (int indexA = 0; indexA < middle; indexA++)
                a[indexA] = numericArray[indexA];

            for (int indexB = 0; indexB < b.Length; indexB++)
                b[indexB] = numericArray[middle + indexB];

            a = DivideAndSort(a);
            b = DivideAndSort(b);
            
            return MergeArrays(a, b);
        }

        private double[] MergeArrays(double[] arrayA, double[] arrayB)
        {
            int aCount = arrayA.Length;
            int bCount = arrayB.Length;
            int cCount = aCount + bCount;
            double[] arrayC = new double[cCount];

            int a = 0;
            int b = 0;
            int c = 0;

            while (a < aCount || b < bCount)
            {
                if (a < aCount && b < bCount)
                {
                    if (arrayA[a] < arrayB[b])
                    {
                        arrayC[c] = arrayA[a];
                        a++;
                    }
                    else
                    {
                        arrayC[c] = arrayB[b];
                        b++;
                    }
                }
                else if (a < aCount)
                {
                    arrayC[c] = arrayA[a];
                    a++;
                }
                else if (b < bCount)
                {
                    arrayC[c] = arrayB[b];
                    b++;
                }

                c++;
            }

            return arrayC;
        }
    }
}
