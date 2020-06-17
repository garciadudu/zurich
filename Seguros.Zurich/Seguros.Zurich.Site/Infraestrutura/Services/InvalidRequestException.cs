﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seguros.Zurich.Site.Infraestrutura.Services
{
    public class InvalidRequestException : Exception
    {
        public InvalidRequestException(string message) : base(message)
        {

        }

        public InvalidRequestException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
