using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace B_Bingo.BBingoModel
{
    //only need one object -> singleton?
    public class FileImport
    {
        //everything is hardcoded for the beginning. will be replaced later
        private const string filePath = @"C:\Users\Chris\Documents\Programmieren\B-Bingo\B-Words.txt";

        public string[] ImportFileData()
        {
            //TODO: add exception handling
            //TODO: rething: method name mentions only importing a file but splits it too. is that ok?
            string buzzWordsTogether = File.ReadAllText(filePath);
            string[] buzzWordsSeparated = buzzWordsTogether.Split("; ");
            return buzzWordsSeparated;
        }
    }
}
