using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardTrick
{
    class Board
    {
        public Column[] columns = new Column[3];
        
        public void addToColumn(int column, Card card)
        {
            columns[column].addCard(card);
        }
        public void clearColumns()
        {
            columns = new Column[3];
        }
    }
}
