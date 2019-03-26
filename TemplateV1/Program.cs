using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateV1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            // Populate list with Car objects
            CarToXMLConverter carToXml = new CarToXMLConverter();
            IDataSource<Car> source = new DataSource();
            List<string> carsAsText = carToXml.ConvertDataToText(source);

        }
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
