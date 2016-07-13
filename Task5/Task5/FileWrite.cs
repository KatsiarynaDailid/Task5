using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task5
{
    public class FileWrite
    {
        public void WriteResultsInAFile (CheckTime ct) {

            File.WriteAllText(Data.FilePath, string.Empty);
            WorkWithFile workWithFile = new WorkWithFile();
            foreach (var result in ct.Results)
            {             
                workWithFile.WriteInAFile(result);

            }           

        }
    }
}
