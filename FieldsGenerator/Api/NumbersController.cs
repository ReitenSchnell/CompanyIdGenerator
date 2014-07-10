using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FieldsGenerator.Logic;

namespace FieldsGenerator.Api
{
    public class NumbersController : ApiController
    {
        private readonly Dictionary<string, Func<string>> map = new Dictionary<string, Func<string>>
            {
                {"Swedish Company Id", SweCompanyCode.Generate},
                {"Swedish Tax Number", SweTaxCode.Generate},
                {"Swedish Personal Number", SwePersonalCode.Generate},
                {"Finnish Company Id", FinCompanyCode.Generate},
                {"Finnish Tax Number", FinTaxCode.Generate},
                {"Finnish Personal Number", FinPersonalCode.Generate},
            };

        public HttpResponseMessage Get(string id)
        {
            return new HttpResponseMessage
                {
                    Content = new StringContent(map.ContainsKey(id) ? map[id]() : string.Empty)
                };
        }
    }
}
