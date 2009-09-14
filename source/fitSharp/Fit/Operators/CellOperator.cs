﻿// Copyright © 2009 Syterra Software Inc. All rights reserved.
// The use and distribution terms for this software are covered by the Common Public License 1.0 (http://opensource.org/licenses/cpl.php)
// which can be found in the file license.txt at the root of this distribution. By using this software in any fashion, you are agreeing
// to be bound by the terms of this license. You must not remove this notice, or any other, from this software.

using fitSharp.Fit.Model;
using fitSharp.Fit.Service;
using fitSharp.Machine.Engine;
using fitSharp.Machine.Model;

namespace fitSharp.Fit.Operators {
    public abstract class CellOperator: Operator<Cell, CellProcessor> {
        public string GetMemberName(Tree<Cell> members) {
            return ParseTree<MemberName>(members).ToString();
        }

        public object GetActual(ExecuteParameters parameters) {
            return parameters.GetTypedActual(this).Value;
        }
    }
}