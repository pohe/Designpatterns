using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateV1
{
    public abstract class DataToTextConverter<T>
    {
        // General algorithm for data-to-string conversion
        public List<string> ConvertDataToText(IDataSource<T> source)
        {
            // Read data from the data source
            List<T> data = source.Load();

            // This list will contain the converted data
            List<string> dataAsText = new List<string>();

            // For each data item: convert the item to a string,
            // and add that string to the dataAsText List
            foreach (T item in data)
            {
                string itemAsText = ConvertItem(item);
                dataAsText.Add(itemAsText);
            }
            return dataAsText;
        }

        // This method needs to be implemented in subclasses.
        public abstract string ConvertItem(T item);
    }

    
}
