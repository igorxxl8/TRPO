using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_1.Business.Services
{
    public class ServiceBase<T>
    {
        protected readonly T _repository;

        public ServiceBase(T repository)
        {
            _repository = repository;
        }
    }
}
