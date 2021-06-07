using System;
using System.Collections.Generic;
using System.Text;

namespace B_Bingo.Model
{
    class BingoField
    {
        private string fieldText1;
        private bool isFieldMarked1;

        /*hint for me: to get full property:
         * - right click on property
         * - click on quick actions and refactoring
         * - choose ...full property...*/
        public string fieldText { get => fieldText1; set => fieldText1 = value; }
        public bool isFieldMarked { get => isFieldMarked1; set => isFieldMarked1 = value; }


    }
}
