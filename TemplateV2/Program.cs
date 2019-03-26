using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateV1;

namespace TemplateV2
{
    class Program
    {
        private static string CarToXML(Car item)
        {
            // Code for converting a Car object to XML
            return "";
        }
        static void Main(string[] args)
        {
           
            List<Car> cars = new List<Car>();
            // Populate list with Car objects
            IDataSource<Car> source = new DataSource();
            DataToTextConverter<Car> carConv = new DataToTextConverter<Car>();
            List<string> carsAsText = carConv.ConvertDataToText(source, CarToXML);

        }
        public class DataSource : IDataSource<Car>
        {
            public List<Car> Load()
            {
                throw new NotImplementedException();
            }

            public void Save(List<string> dataAsText)
            {
                throw new NotImplementedException();
            }
        }
    }
}
