﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserValidation
{
    public class UserException:Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRSTNAME, INVALID_LASTNAME, INVALID_EMAIL, INVALID_MOBILENUMBER, INVALID_PASSWORD
        }
        public ExceptionType exceptionType;
        public UserException(ExceptionType type, string message) : base(message)
        {
            this.exceptionType = type;
        }
    }
}
