// Microsoft Power Fx Console Formula REPL
// 
// Console based Read-Eval-Print-Loop that supports variables and formula recalc
//
// Licensed under the MIT license

using Microsoft.PowerFx.Types;

namespace WEM.Assignments
{
    internal class AssignmentRecordValue
    {
        internal RecordValue RecordValue;
        public AssignmentRecordValue(RecordValue value)
        {
            RecordValue = value;
        }

        public FormulaValue ResourceName => RecordValue.GetField("ResourceName");
        public FormulaValue ResourceMaxNumberOfAssignments => RecordValue.GetField("ResourceMaxNumberOfAssignments");
    }
}
