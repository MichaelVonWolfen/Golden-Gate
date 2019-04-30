using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golden_Gate
{
   public class Sort
    {
        //TO DO: Implementare parte de Merge
        private void Merge(ref int[]desortat, int start, int mij, int end, bool asc_desc)
        {
            int lenL = mij - start + 1;
            int lenR = end - mij;

            int[] tempL = new int[lenL];
            int[] tempR = new int[lenR];

            int i, j, k;

            int crestere;
            if (asc_desc) //Daca asc_desc este true se va ordona cresc, altel descrescator
                crestere = -1;
            else crestere = 1;

            for (i = 0; i < lenL; i++)
                tempL[i] = desortat[i + start];

            for (j = 0; j < lenR; j++)
                tempR[j] = desortat[j + mij + 1];

            i = 0;
            j = 0;
            k = 0;

            while (i < lenL && j < lenR)
            {
                if(tempL[i] >= tempR[j])
                    desortat[start + k++] = tempL[i++];
                else desortat[start + k++] = tempR[j++];
            }
            while (i < lenL)
                desortat[start + k++] = tempL[i++];
            while (j < lenR)
                desortat[start + k++] = tempR[j++];
        }
        //TO DO: Implementare metoda Merge Sort
        public void MergeSort(ref int[] vec, int left, int rigth, bool asc_desc)
        {
            if(left < rigth)
            {
                int mid = (left + rigth) / 2;
                MergeSort(ref vec, left, mid, asc_desc);
                MergeSort(ref vec, mid + 1, rigth, asc_desc);
                Merge(ref vec, left, mid, rigth, asc_desc);
            }
        }
        public void bublesort(ref int[] vec, int n, bool asc_desc)
        {
            bool ok = true;
            int aux;

            int crestere;
            if (asc_desc) //Daca asc_desc este true se va ordona cresc, altel descrescator
                crestere = -1;
            else crestere = 1;

            while (ok)
            {
                ok = !ok;
                for (int i = 0; i < n - 1; i++)
                {
                    if (vec[i] * crestere  > vec[i + 1] * crestere)
                    {
                        aux = vec[i];
                        vec[i] = vec[i + 1];
                        vec[i + 1] = aux;
                        ok = true;
                    }
                }
            }

        }
    }
}