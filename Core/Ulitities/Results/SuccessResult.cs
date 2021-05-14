﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Ulitities.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult() : base(true)
        {
        }

        public SuccessResult(string message) : base(message, true)
        {
        }
    }
}
