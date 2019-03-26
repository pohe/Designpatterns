using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateV2
{
    public class DataToTextConverter<T>
    {
        // General algorithm for data-to-string conversion
        public List<string> ConvertDataToText(IDataSource<T> source, Func<T, string> converter)
        {
            List<T> data = source.Load();
            List<string> dataAsText = new List<string>();

            foreach (T item in data)
            {
                string itemAsText = converter(item);
                dataAsText.Add(itemAsText);
            }

            return dataAsText;
        }



    }
}
