using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker worker;
            Console.Write("Enter Pro or Expert: ");
            string key = Console.ReadLine();
            if(!String.IsNullOrWhiteSpace(key))
            {
                if(key == "pro")
                {
                    Console.WriteLine("\nClass ProDocumentWorker");
                    worker = new ProDocumentWorker();
                    worker.OpenDocument();
                    worker.EditDocument();
                    worker.SaveDocument();
                }
                else if(key == "expert")
                {
                    Console.WriteLine("\nClass ExpertDocumentWorker");
                    worker = new ExpertDocumentWorker();
                    worker.OpenDocument();
                    worker.EditDocument();
                    worker.SaveDocument();
                }
            }
            else
            {
                Console.WriteLine("\nClass DocumentWorker");
                worker = new DocumentWorker();
                worker.OpenDocument();
                worker.EditDocument();
                worker.SaveDocument();
            }
        }
    }
}
