using FirmLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class FirmManager
    {
        private List<Firm> firms = new List<Firm>();
        private FirmView firmView = new FirmView();

        public List<Firm> Firms
        {
            get
            {
                return firms;
            }
        }

        public FirmView FirmView
        {
            get
            {
                return firmView;
            }
        }

        public FirmManager()
        {
        }

        public FirmManager(List<Firm> firms)
        {
            this.firms = firms;
        }

        public void CreateFirms()
        {
            List<string> customFields = new List<string>();
            customFields.Add("field1");
            customFields.Add("field2");
            customFields.Add("field3");
            customFields.Add("field4");
            customFields.Add("field5");

            FirmFactory factory = new FirmFactory(customFields);

            Firm firm1 = factory.Create("Найк");
            firm1.Country = "Россия";
            firm1.Dateln = new DateTime(2018, 10, 1);
            firm1.Email = "nike@mail.ru";
            firm1.PostInx = "34567";
            firm1.Region = "Московский";
            firm1.Street = "Ленина";
            firm1.Town = "Москва";
            firm1.Web = "www.nike.ru";
            firm1.SetField("field1", 2010);
            firm1.SetField("field2", "Новая");
            firm1.SetField("field3", "Далеко");
            firm1.SetField("field4", "В городе");
            firm1.SetField("field5", "Удаленная работа");

            Firm firm2 = factory.Create("Риббок");
            firm2.Country = "Россия";
            firm2.Dateln = new DateTime(2018, 11, 11);
            firm2.Email = "nike@mail.ru";
            firm2.PostInx = "231278";
            firm2.Region = "Новгородский";
            firm2.Street = "Мира";
            firm2.Town = "Новгород";
            firm2.Web = "www.rib.ru";
            firm2.SetField("field1", 2015);
            firm2.SetField("field2", "Проверенная");
            firm2.SetField("field3", "Близко");
            firm2.SetField("field4", "В деревне");
            firm2.SetField("field5", "Очная работа");

            ContType contType1 = new ContType("А");

            Contact contact1 = new Contact(new DateTime(2019, 1, 11), "Инфо", contType1);
            Contact contact2 = new Contact(new DateTime(2019, 4, 3), "Инфо1", contType1);

            firm1.AddContact(contact1);
            firm2.AddContact(contact2);

            firms.Add(firm1);
            firms.Add(firm2);
        }
    }
}
