﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Panta.Indexing.Expressions;

namespace Panta.Indexing.Correctors
{
    /// <summary>
    /// Can correct a term and build an expression base on an existing dictionary
    /// </summary>
    public interface ITermCorrector
    {
        /// <summary>
        /// Correct a term and build an expression of corrected terms
        /// </summary>
        /// <param name="term">Input term</param>
        /// <returns>A list of corrected terms</returns>
        IEnumerable<string> Correct(string term);
    }
}
