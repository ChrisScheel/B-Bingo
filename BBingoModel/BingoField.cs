using System;
using System.Collections.Generic;
using System.Text;

namespace B_Bingo.BBingoModel
{
    public class BingoField
    {
        //for viewmodel: is only binding code
        //shows only the text in the bingofield
        private string fieldText1;
        // for viewmodel: transformation code (logic)
        // marks the bingofield as blue in the view when the user clicked it. isFieldMarked1 = true
        private bool isFieldMarked1;

        /*hint for me: to get full property:
         * - right click on property
         * - click on quick actions and refactoring
         * - choose ...full property...*/
        public string FieldText { get => fieldText1; set => fieldText1 = value; }
        public bool IsFieldMarked { get => isFieldMarked1; set => isFieldMarked1 = value; }


    }
}
