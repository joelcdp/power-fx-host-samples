// Microsoft Power Fx Console Formula REPL
// 
// Console based Read-Eval-Print-Loop that supports variables and formula recalc
//
// Licensed under the MIT license

using Microsoft.PowerFx;
using Microsoft.PowerFx.Types;

namespace WEM.AssignmentsPerShift
{
    public class AssignmentsPerShiftFunction : ReflectionFunction
        {
            public AssignmentsPerShiftFunction() : base("AssignmentsPerShift", new AssignmentPerShiftTableType()) { }

            public TableValue Execute()
            {
                return new AssignmentPerShiftTableType().FromJson();
            }
        
    }
}
