using System;
using System.Collections.Generic;
using System.Web.Http;
using FieldsGenerator.Logic;

namespace FieldsGenerator.Controllers
{
    public class CalcController : ApiController
    {
        private readonly Dictionary<string, Func<string>> map = new Dictionary<string, Func<string>>
            {
                {"Swedish Company Id", SweCompanyCode.Generate},
                {"Swedish Tax Number", SweTaxCode.Generate},
                {"Finnish Company Id", FinCompanyCode.Generate},
                {"Finnish Tax Number", FinTaxCode.Generate},
            }; 

        public string Get(string calculationType)
        {
            return map.ContainsKey(calculationType) ? map[calculationType]() : string.Empty;
        }
         
    }
}