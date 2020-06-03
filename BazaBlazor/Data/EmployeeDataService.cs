using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace BazaBlazor.Data
{
    public class EmployeeDataService
    {
        List<EmployeeInfo> EmployeeList = new List<EmployeeInfo>()
        {
           
        };

        public async Task<IEnumerable<EmployeeInfo>> EmployList()
        {
            return await Task.FromResult(EmployeeList);
        }
    }
}
