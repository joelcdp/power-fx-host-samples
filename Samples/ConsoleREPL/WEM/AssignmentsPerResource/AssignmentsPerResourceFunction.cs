// Microsoft Power Fx Console Formula REPL
// 
// Console based Read-Eval-Print-Loop that supports variables and formula recalc
//
// Licensed under the MIT license

using Microsoft.PowerFx;
using Microsoft.PowerFx.Types;

namespace WEM.AssignmentsPerResource
{
    public class AssignmentsPerResourceFunction : ReflectionFunction
    {
        public AssignmentsPerResourceFunction() : base("AssignmentsPerResource", new AssignmentPerResourceRecordType()) { }

        public TableValue Execute()
        {
            return new AssignmentPerResourceTableType().FromJson();
        }

    }
}
