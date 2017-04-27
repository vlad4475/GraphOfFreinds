using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GraphOfFreinds
{
    class Graph
    {
        public List<Person> _allPersonInGraph;

        public Graph()
        {
            _allPersonInGraph = new List<Person>();
        }

        public void addNewPerson(string strIdofNewPeople)
        {
            List<int> freindofFreindsOfId = new List<int>();
            List<int> freindsOfstrId;
            freindsOfstrId = Global.speakerVk.giveListOfFreidsUser(strIdofNewPeople);
            
            freindofFreindsOfId.AddRange(freindsOfstrId);

            foreach(int x in freindsOfstrId)
                freindofFreindsOfId.AddRange(Global.speakerVk.giveListOfFreidsUser(Convert.ToString(x)));         

            freindofFreindsOfId.Sort(); // ToDo нормальное слияние списков, используя то, что они изначально отсортированы, а не вот так

            HashSet<int> set = new HashSet<int>();

            foreach (int x in freindofFreindsOfId)
                set.Add(x);

            int a = 0;

        }


        /*
         * Здесь только  strIdofNewPeople будет Сердцем(Heart) графа. Остальных его друзей мы включам,
         * но их друзья будут запомнины, но не будут отрисованы.
         */
        public void addNewPersonWithThimFreinds(string strIdofNewPeople)
        {            
            List<int> freindofFreindsOfId = new List<int>();

            List<int> freindsOfstrId;
            freindsOfstrId = Global.speakerVk.giveListOfFreidsUser(strIdofNewPeople);
            _allPersonInGraph.Add(new Person(Convert.ToInt32(strIdofNewPeople), freindsOfstrId, true));  //Добавляю в список нового человека

            freindofFreindsOfId.AddRange(freindsOfstrId);

            foreach (int x in freindsOfstrId)
            {
                freindsOfstrId = Global.speakerVk.giveListOfFreidsUser(Convert.ToString(x));
                _allPersonInGraph.Add(new Person(Convert.ToInt32(strIdofNewPeople), freindsOfstrId, false));
            }                

            freindofFreindsOfId.Sort(); // ToDo нормальное слияние списков, используя то, что они изначально отсортированы, а не вот так

            HashSet<int> set = new HashSet<int>();

            foreach (int x in freindofFreindsOfId)
                set.Add(x);

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
