namespace QuickSortHoarePartition.App.Algoritmos
{
    public static class AlgoritmoQuickSort
    {
        public static void QuickSort(int[] arr, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int particao = UsarParticaoHoare(arr, inicio, fim);
                QuickSort(arr, inicio, particao);
                QuickSort(arr, particao + 1, fim);
            }
        }

        private static int UsarParticaoHoare(int[] arr, int inicio, int fim)
        {
            int pivo = arr[inicio];
            int i = inicio - 1;
            int j = fim + 1;
            while (true)
            {
                do
                {
                    i++;
                } while (arr[i] < pivo);
                do
                {
                    j--;
                } while (arr[j] > pivo);
                if (i >= j)
                {
                    return j;
                }
                (arr[j], arr[i]) = (arr[i], arr[j]);
            }
        }
    }
}