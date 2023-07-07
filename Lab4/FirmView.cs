using Lab4.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class FirmView
    {
        private List<Field> fields = new List<Field>();

        public List<Field> Fields
        {
            get
            {
                return fields;
            }
        }

        public FirmView()
        {
            fields.Add(new NameField());
            fields.Add(new TownField());
            fields.Add(new DateInField());
            fields.Add(new RegionField());
            fields.Add(new CountContactField());
            fields.Add(new CountryField());
            fields.Add(new DateBegField());
            fields.Add(new PostIndexField());
            fields.Add(new WebField());
            fields.Add(new CustomField1());
            fields.Add(new CustomField2());
            fields.Add(new CustomField3());
            fields.Add(new CustomField4());
            fields.Add(new CustomField5());
        }
    }
}
