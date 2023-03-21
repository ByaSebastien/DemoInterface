using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    public interface IBaseService<TKey, TValue> where TValue : class
    {
        public TKey Add(TValue v);
        public void Update(TKey id, TValue v);
        public void Delete(TKey id);
        public TValue GetOne(TKey id);
        public List<TValue> GetAll();
    }
}
