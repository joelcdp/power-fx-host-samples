// Microsoft Power Fx Console Formula REPL
// 
// Console based Read-Eval-Print-Loop that supports variables and formula recalc
//
// Licensed under the MIT license

using Microsoft.PowerFx;
using Microsoft.PowerFx.Types;

namespace WEM.Assignments
{
    public class AssignmentsFunction : ReflectionFunction
        {
            public AssignmentsFunction() : base("Assignments", new AssignmentTableType()) { }

            public TableValue Execute()
            {
                return new AssignmentTableType().ToTableValue();
            }
        }
}
