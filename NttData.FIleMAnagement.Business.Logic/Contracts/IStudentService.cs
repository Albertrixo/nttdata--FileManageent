using NttData.FileManagement.Business.Logic.Implementations;
using NttData.FileManagement.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NttData.FileManagement.Business.Logic.Contracts
{
    public interface ISTudentService 
    {
        bool Add(Student student);
    }
}
