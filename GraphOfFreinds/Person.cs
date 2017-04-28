using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphOfFreinds
{
    class Person
    {
        public int _ID;
        public bool _isHeart; //Тру, если мы добавим всех его друзей в наш список и всех их изобразим. Это сделает его одной из центральных фигур графа
        List<int> _listFriends;

        public Person(int ID, List<int> listFreinds, bool isHeart)
        {
            _ID = ID;
            _listFriends = listFreinds;
            _isHeart = _isHeart;
        }
    }
}
