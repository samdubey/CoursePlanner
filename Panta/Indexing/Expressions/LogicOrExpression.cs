﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Panta.Indexing.Expressions
{
    public class LogicOrExpression : LogicExpression
    {
        public LogicOrExpression(IExpression left, IExpression right) : base(left, right) { }

        #region IExpression Implementation
        public override HashSet<uint> Evaluate(IIdProvider provider)
        {
            HashSet<uint> leftSet = Left.Evaluate(provider);
            HashSet<uint> rightSet = Right.Evaluate(provider);
            leftSet.UnionWith(rightSet);

            return leftSet;
        }
        #endregion

        public static IExpression Join(IExpression left, IExpression right)
        {
            if (left == null) return right;
            if (right == null) return left;
            return new LogicOrExpression(left, right);
        }

        public override string ToString()
        {
            return String.Format("({0} || {1})", Left, Right);
        }
    }
}
