using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seguros.Zurich.Site.Infraestrutura.Services
{
    public class ValidationException : Exception
    {
        public ValidationException(string message, IDictionary<string, IEnumerable<string>> errors) : this(message, errors, null)
        {

        }

        public ValidationException(string message, IDictionary<string, IEnumerable<string>> erros, Exception innerException) : base(message, innerException)
        {
            Errors = erros;
        }

        public IDictionary<string, IEnumerable<string>> Errors { get; }
    }
}
