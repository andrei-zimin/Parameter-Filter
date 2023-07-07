using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmLibrary
{
    public class FirmFactory
    {
        private List<string> ids = new List<string>();

        public FirmFactory(List<string> ids)
        {
            this.ids.AddRange(ids);
        }

        public Firm Create(string name)
        {
            Firm firm = new Firm(name);
            for (int i = 0; i < ids.Count; i++)
            {
                firm.AddField(ids[i], null);
            }

            return firm;
        }
    }
}
