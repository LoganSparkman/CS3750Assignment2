using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardTrick
{
    class Board
    {
        public Column[] columns;
        
        public Board()
        {
            columns = new Column[3];
            Column one = new Column();
            Column two = new Column();
            Column three = new Column();
            columns[0] = one;
            columns[1] = two;
            columns[2] = three;
        }

        public void addToColumn(int column, Card card)
        {
            
            columns[column].addCard(card);
        }
        public void clearColumns()
        {
            columns = new Column[3];
            Column one = new Column();
            Column two = new Column();
            Column three = new Column();
            columns[0] = one;
            columns[1] = two;
            columns[2] = three;
        }
    }
}
