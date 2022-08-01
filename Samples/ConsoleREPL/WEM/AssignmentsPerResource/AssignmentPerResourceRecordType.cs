// Microsoft Power Fx Console Formula REPL
// 
// Console based Read-Eval-Print-Loop that supports variables and formula recalc
//
// Licensed under the MIT license

using System.Collections.Generic;
using Microsoft.PowerFx.Types;
using WEM.Assignments;

namespace WEM.AssignmentsPerResource
{
    internal class AssignmentPerResourceRecordType : RecordType
    {
        private List<NamedFormulaType> fields = new List<NamedFormulaType>()
        {
            new NamedFormulaType("ResourceName", String, "Resource name"),
            new NamedFormulaType("ResourceMaxNumberOfAssignments", Number, "Max number of assignments a resource can have"),
        };

        private RecordType recordType = Empty();

        public AssignmentPerResourceRecordType()
        {
            fields.ForEach(f => recordType = recordType.Add(f));
            recordType = recordType.Add(new NamedFormulaType("List", new AssignmentTableType(), "List of assignments for the given resource"));
        }
        public override bool Equals(object other)
        {
            var otherObject = other as AssignmentPerResourceRecordType;
            if (otherObject == null) return false;
            return recordType.Equals(otherObject.recordType);
        }

        public override int GetHashCode()
        {
            return recordType.GetHashCode();
        }

        public override IEnumerable<string> FieldNames => recordType.FieldNames;

        public override bool TryGetFieldType(string name, out FormulaType type)
        {
            return recordType.TryGetFieldType(name, out type);
        }
    }
}
