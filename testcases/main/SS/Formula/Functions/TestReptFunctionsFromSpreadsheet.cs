﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;using NUnit.Framework.Legacy;

namespace TestCases.SS.Formula.Functions
{
    [TestFixture]
    public class TestReptFunctionsFromSpreadsheet:BaseTestFunctionsFromSpreadsheet
    {
        protected override string Filename
        {
            get { return "ReptFunctionTestCaseData.xls"; }
        }
    }
}
