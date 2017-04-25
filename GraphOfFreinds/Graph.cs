using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphOfFreinds
{
    class Graph
    {
        List<List<int>> matrixGraph;

        public void addNewPeople(string strIdofNewPeople)
        {
            List<int> freindofFreindsOfId = new List<int>();
            List<int> freindsOfstrId;
            freindsOfstrId = Global.speakerVk.giveListOfFreidsUser(strIdofNewPeople);
            
            freindofFreindsOfId.AddRange(freindsOfstrId);

            foreach(int x in freindsOfstrId)
                freindofFreindsOfId.AddRange(Global.speakerVk.giveListOfFreidsUser(Convert.ToString(x)));         

            freindofFreindsOfId.Sort(); // ToDo нормальное слияние списков, используя то, что они изначально отсортированы, а не вот так

            int a = 0;

        }

        private void Mergh(List<int> a, List<int> b) //не доделано
        {
            int iteratorA = 0, iteratorB = 0;

            if(a[iteratorA] < b[iteratorB])
            {
                //a.insert
            }
        }

    }
}
