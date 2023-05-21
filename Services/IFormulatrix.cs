using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IFormulatrix
    {
        void Register(string itemName, string itemContent, int itemType);
        string Retrieve(string itemName);
        int GetType(string itemName);
        void Deregister(string itemName);
        void Initialize();
    }
}
