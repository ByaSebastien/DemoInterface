using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    public class BaseService<TKey, TValue> : IBaseService<TKey, TValue> where TValue : class
    {
        public TKey Add(TValue v)
        {
            throw new NotImplementedException();
        }

        public void Delete(TKey id)
        {
            throw new NotImplementedException();
        }

        public List<TValue> GetAll()
        {
            throw new NotImplementedException();
        }

        public TValue GetOne(TKey id)
        {
            throw new NotImplementedException();
        }

        public void Update(TKey id, TValue v)
        {
            throw new NotImplementedException();
        }
    }
}
