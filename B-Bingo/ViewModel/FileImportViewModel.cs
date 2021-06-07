using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace B_Bingo.ViewModel
{
    class FileImportViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string bingoWordsList; //use again full property
    }
}
