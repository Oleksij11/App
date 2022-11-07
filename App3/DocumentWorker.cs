using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    public class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Document is opened\n");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Editing of the document is available in the pro version\n");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Saving the document is available in the pro version\n");
        }
    }
}
