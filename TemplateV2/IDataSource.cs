using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateV2
{
    public interface IDataSource<T>
    {
        List<T> Load();
        void Save(List<string> dataAsText);

    }
}
