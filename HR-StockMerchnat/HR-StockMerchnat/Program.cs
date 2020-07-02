
using System.IO;
using System.Linq;
using System;

class Solution
{
    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar)
    {
        int[] distinctElements = ar.Distinct().ToArray();
        int[] pairsArray = new int[distinctElements.Count()];
        decimal pairsCount = 0;
        for (int i = 0; i < distinctElements.Count(); i++)
        {
            pairsArray[i] = ar.Count(s => s == distinctElements[i]);
        }
        for(int j=0;j<pairsArray.Length;j++)
        {
            if(pairsArray[j]>2)
            {
                decimal d = pairsArray[j] / 2;
                pairsCount += Math.Floor(d);
            }
        }
        return (int)pairsCount;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int n = Convert.ToInt32(Console.ReadLine());
        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        int result = sockMerchant(n, ar);
        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}
