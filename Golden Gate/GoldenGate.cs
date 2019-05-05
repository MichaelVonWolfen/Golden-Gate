using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golden_Gate
{
    class GoldenGate
    {
        void Gates(ref int[] vec, int val, bool st_dr, int amplit, int def)//st_dr = 1 => se pune el la st, 0 se pune la dr 
        {                                                                        //AMPLITUDINE => locatia din vector unde incepe amplitudinea
                                                                                 //defazaj=> cate elem la st sau dreapta trebuie mers pt a pune acel element
            if (st_dr)
                vec[amplit + def] = val;
            else vec[amplit - def] = val;
        }
        public int[] GoldGate(int[] vec)
        {
            int ampl1, ampl2;
            int defazaj = 0, counter = 0;
            int[] copy = new int[vec.Length];
            if ((vec.Length - 5) % 4 != 0)
            {
                if (vec.Length % 4 == 0)
                    ampl1 = vec.Length / 4 - 1;
                else ampl1 = vec.Length / 4;
                ampl2 = (vec.Length * 3) / 4;
            }
            else
            {
                if (vec.Length % 4 == 0)
                    ampl1 = vec.Length / 4;
                else ampl1 = vec.Length / 4;
                ampl2 = (vec.Length * 3) / 4 + 1;
            }
            foreach (int i in vec)
            {
                if ((defazaj == 0 && counter == 2) || counter == 4)
                {
                    defazaj++;
                    counter = 0;
                }
                if (defazaj == 0) // Primele 2 elemente vor fi puse ca si amplitudini
                    if (counter++ == 0)
                        Gates(ref copy, i, true, ampl1, defazaj);
                    else
                        Gates(ref copy, i, true, ampl2, defazaj);

                if(defazaj > 0)
                {
                    counter++;
                    /*if (i == 3 && (vec.Length - 1) % 4 == 0)
                        counter++; //caz special in care se suprapun valori iar programul nu merge cum ar trebui
                   */ 
                   switch (counter)
                    {
                        case 1:
                            Gates(ref copy, i, true, ampl1, defazaj);
                            break;
                        case 2:
                            Gates(ref copy, i, false, ampl2, defazaj);
                            break;
                        case 3:
                            Gates(ref copy, i, false, ampl1, defazaj);
                            break;
                        case 4:
                            Gates(ref copy, i, true, ampl2, defazaj);
                            break;

                    }
                }

            }
            return copy;


        }
    }
}
