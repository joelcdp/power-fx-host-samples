// Microsoft Power Fx Console Formula REPL
// 
// Console based Read-Eval-Print-Loop that supports variables and formula recalc
//
// Licensed under the MIT license

using System.Collections.Generic;
using Microsoft.PowerFx.Types;

namespace WEM.Assignments
{
    internal class AssignmentRecordType : RecordType
    {
        private List<NamedFormulaType> fields = new List<NamedFormulaType>()
        {
            new NamedFormulaType("ResourceName", String, "Resource name"),
            new NamedFormulaType("ResourceMaxNumberOfAssignments", Number, "Max number of assignments a resource can have"),
            new NamedFormulaType("RequirementId", Number, "Requirement Id"),
            new NamedFormulaType("RequiredResources", Number, "Number of resources required"),
            new NamedFormulaType("RequirementStart", DateTime, "Timestamp when the requirement starts"),
            new NamedFormulaType("RequirementEnd", DateTime, "Timestamp when the requirement ends"),
            new NamedFormulaType("ShiftId", String, "Shift Id"),
            new NamedFormulaType("ShiftName", String, "Shift Name"),
            new NamedFormulaType("ShiftStart", DateTime, "Timestamp when the shift starts"),
            new NamedFormulaType("ShiftEnd", DateTime, "Timestamp when the shift ends"),
            new NamedFormulaType("Working", Boolean, "Status indicating if resource is assigned or not to the requirement time window."),
            new NamedFormulaType("DurationInMin", Number, "Assignment duration in minutes"),
        };

        internal List<List<NamedValue>> values = new List<List<NamedValue>>()
        {
            new List<NamedValue>()
            {
                new NamedValue("ResourceName", FormulaValue.New("Resource 01")),
                new NamedValue("ResourceMaxNumberOfAssignments", FormulaValue.New(1)),
                new NamedValue("RequirementId", FormulaValue.New(1)),
                new NamedValue("RequiredResources", FormulaValue.New(10)),
                new NamedValue("RequirementStart", FormulaValue.New(System.DateTime.Now)),
                new NamedValue("RequirementEnd", FormulaValue.New(System.DateTime.Now.AddHours(1))),
                new NamedValue("ShiftId", FormulaValue.New("Shift 01")),
                new NamedValue("ShiftName", FormulaValue.New("Morning")),
                new NamedValue("ShiftStart", FormulaValue.New(System.DateTime.Now)),
                new NamedValue("ShiftEnd", FormulaValue.New(System.DateTime.Now.AddHours(8))),
                new NamedValue("Working", FormulaValue.New(false)),
                new NamedValue("DurationInMin", FormulaValue.New(60)),
            },
            new List<NamedValue>()
            {
                new NamedValue("ResourceName", FormulaValue.New("Resource 01")),
                new NamedValue("ResourceMaxNumberOfAssignments", FormulaValue.New(1)),
                new NamedValue("RequirementId", FormulaValue.New(1)),
                new NamedValue("RequiredResources", FormulaValue.New(10)),
                new NamedValue("RequirementStart", FormulaValue.New(System.DateTime.Now.AddHours(1))),
                new NamedValue("RequirementEnd", FormulaValue.New(System.DateTime.Now.AddHours(2))),
                new NamedValue("ShiftId", FormulaValue.New("Shift 01")),
                new NamedValue("ShiftName", FormulaValue.New("Morning")),
                new NamedValue("ShiftStart", FormulaValue.New(System.DateTime.Now)),
                new NamedValue("ShiftEnd", FormulaValue.New(System.DateTime.Now.AddHours(8))),
                new NamedValue("Working", FormulaValue.New(false)),
                new NamedValue("DurationInMin", FormulaValue.New(60)),
            },
            new List<NamedValue>()
            {
                new NamedValue("ResourceName", FormulaValue.New("Resource 02")),
                new NamedValue("ResourceMaxNumberOfAssignments", FormulaValue.New(1)),
                new NamedValue("RequirementId", FormulaValue.New(1)),
                new NamedValue("RequiredResources", FormulaValue.New(10)),
                new NamedValue("RequirementStart", FormulaValue.New(System.DateTime.Now)),
                new NamedValue("RequirementEnd", FormulaValue.New(System.DateTime.Now.AddHours(1))),
                new NamedValue("ShiftId", FormulaValue.New("Shift 01")),
                new NamedValue("ShiftName", FormulaValue.New("Morning")),
                new NamedValue("ShiftStart", FormulaValue.New(System.DateTime.Now)),
                new NamedValue("ShiftEnd", FormulaValue.New(System.DateTime.Now.AddHours(8))),
                new NamedValue("Working", FormulaValue.New(false)),
                new NamedValue("DurationInMin", FormulaValue.New(60)),
            },
            new List<NamedValue>()
            {
                new NamedValue("ResourceName", FormulaValue.New("Resource 02")),
                new NamedValue("ResourceMaxNumberOfAssignments", FormulaValue.New(1)),
                new NamedValue("RequirementId", FormulaValue.New(1)),
                new NamedValue("RequiredResources", FormulaValue.New(10)),
                new NamedValue("RequirementStart", FormulaValue.New(System.DateTime.Now.AddHours(1))),
                new NamedValue("RequirementEnd", FormulaValue.New(System.DateTime.Now.AddHours(2))),
                new NamedValue("ShiftId", FormulaValue.New("Shift 01")),
                new NamedValue("ShiftName", FormulaValue.New("Morning")),
                new NamedValue("ShiftStart", FormulaValue.New(System.DateTime.Now)),
                new NamedValue("ShiftEnd", FormulaValue.New(System.DateTime.Now.AddHours(8))),
                new NamedValue("Working", FormulaValue.New(false)),
                new NamedValue("DurationInMin", FormulaValue.New(60)),
            },
        };

        private RecordType record = Empty();

        public AssignmentRecordType()
        {
            fields.ForEach(f => record = record.Add(f));
        }

        public override IEnumerable<string> FieldNames => record.FieldNames;

        public override bool Equals(object other)
        {
            var otherObject = other as AssignmentRecordType;
            if (otherObject == null) return false;
            return record.Equals(otherObject.record);
        }

        public override int GetHashCode()
        {
            return record.GetHashCode();
        }

        public override bool TryGetFieldType(string name, out FormulaType type)
        {
            return record.TryGetFieldType(name, out type);
        }
    }
}
