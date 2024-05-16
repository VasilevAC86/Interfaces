using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IAbc 
    {
        // Модификаторы доступа можно не прописывать, т.к. всё по умолчанию public        
        void Ab();
        bool A { get; set; }
    }
    public interface IWorker
    {
        bool IsWorking { get; set; }
        string Work();
    }
    public class Driver : IWorker
    {
        public bool IsWorking { get; set;}
        public string Work()
        {
            return "Водитель работает";
        }
    }
    public class Managger_Driver : IWorker, IManager
    {
        List<IWorker> workers; // При обращении к workers мы обращаемся к IWorker, как будто бы ссылка
        public bool IsWorking { get; set; }
        public string Work()
        {
            return "Водитель-менеджер работает";
        }
        public string Manager()
        {
            return "Управляет водителями";
        }
    }
    public interface IManager
    {
        string Manager();
    }
    
}
