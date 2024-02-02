namespace QuickSortHoarePartition.App.Algoritmos
{
    public static class AlgoritmoMergeSort
    {
        public static void MergeSort(int[] arr, int esquerda, int direita)
        {
            if (esquerda < direita)
            {
                int metade = esquerda + (direita - esquerda) / 2;
                MergeSort(arr, esquerda, metade);
                MergeSort(arr, metade + 1, direita);
                Merge(arr, esquerda, metade, direita);
            }
        }

        private static void Merge(int[] arr, int esquerda, int metade, int direita)
        {
            int n1 = metade - esquerda + 1;
            int n2 = direita - metade;
            int[] arrEsquerda = new int[n1];
            int[] arrDireita = new int[n2];
            int i;
            for (i = 0; i < n1; i++)
            {
                arrEsquerda[i] = arr[esquerda + i];
            }
            int j;
            for (j = 0; j < n2; j++)
            {
                arrDireita[j] = arr[metade + 1 + j];
            }
            i = 0;
            j = 0;
            int k = esquerda;
            while (i < n1 && j < n2)
            {
                if (arrEsquerda[i] <= arrDireita[j])
                {
                    arr[k] = arrEsquerda[i];
                    i++;
                }
                else
                {
                    arr[k] = arrDireita[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = arrEsquerda[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = arrDireita[j];
                j++;
                k++;
            }
        }
    }
}