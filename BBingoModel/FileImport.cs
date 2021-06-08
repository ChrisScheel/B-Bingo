using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace B_Bingo.BBingoModel
{
    class FileImport
    {
        //everything is hardcoded for the beginning. will be replaced later
        private string buzzWordsTogether = string.Empty;
        private string[] buzzWordsSeparated = new string[16];

        public string[] ImportFileData()
        {
            //TODO: add exception handling
            //TODO: rething: method name mentions only importing a file but splits it too. is that ok?
            buzzWordsTogether = File.ReadAllText(@"C:\Users\Chris\Documents\Programmieren\B-Bingo\B-Words.txt");
            buzzWordsSeparated = buzzWordsTogether.Split(", ");
            return buzzWordsSeparated;
        }
    }
}
