// Microsoft Power Fx Console Formula REPL
// 
// Console based Read-Eval-Print-Loop that supports variables and formula recalc
//
// Licensed under the MIT license

using System.Collections.Generic;
using System.Linq;
using Microsoft.PowerFx.Types;
using WEM.Assignments;

namespace WEM.AssignmentsPerResource
{
    internal class AssignmentPerResourceTableType : TableType
    {
        private AssignmentPerResourceRecordType recordType = new AssignmentPerResourceRecordType();

        public override bool Equals(object other)
        {
            return other is AssignmentPerResourceTableType && recordType.Equals(((AssignmentPerResourceTableType)other).recordType);
        }

        public override int GetHashCode()
        {
            return recordType.GetHashCode();
        }

        public override bool TryGetFieldType(string name, out FormulaType type)
        {
            return recordType.TryGetFieldType(name, out type);
        }

        internal TableValue FromJson()
        {
            return (TableValue)FormulaValue.FromJson(@"
               [
    {
        ""ResourceName"": ""Agent 01"",
		""ResourceMaxNumberOfAssignments"" : 10,
		""List"" :
		[
            {
                ""RequirementId"": 1,
                ""RequiredResources"": 8,
				""RequirementStart"": ""9/1/2022 08:00:00"",
				""RequirementEnd"": ""9/1/2022 09:00:00"",
				""ShiftId"" : 1,
				""ShiftName"": ""Morning"",
				""ShiftStart"": ""9/1/2022 08:00:00"",
				""ShiftEnd"": ""9/1/2022 17:00:00"",
				""Working"" : false,
				""DurationInMin"" : 60

            },
			{
                ""RequirementId"": 2,
				""RequiredResources"": 10,
				""RequirementStart"": ""9/1/2022 09:00:00"",
				""RequirementEnd"": ""9/1/2022 10:00:00"",
				""ShiftId"" : 1,
				""ShiftName"": ""Morning"",
				""ShiftStart"": ""9/1/2022 08:00:00"",
				""ShiftEnd"": ""9/1/2022 17:00:00"",
				""Working"" : false,
				""DurationInMin"" : 60
            }
		]
	},
	{
        ""ResourceName"": ""Agent 02"",
		""ResourceMaxNumberOfAssignments"" : 10,
		""List"" :
		[
            {
                ""RequirementId"": 1,
                ""RequiredResources"": 8,
				""RequirementStart"": ""9/1/2022 08:00:00"",
				""RequirementEnd"": ""9/1/2022 09:00:00"",
				""ShiftId"" : 1,
				""ShiftName"": ""Morning"",
				""ShiftStart"": ""9/1/2022 08:00:00"",
				""ShiftEnd"": ""9/1/2022 17:00:00"",
				""Working"" : false,
				""DurationInMin"" : 60
            },
			{
                ""RequirementId"": 2,
				""RequiredResources"": 10,
				""RequirementStart"": ""9/1/2022 09:00:00"",
				""RequirementEnd"": ""9/1/2022 10:00:00"",
				""ShiftId"" : 1,
				""ShiftName"": ""Morning"",
				""ShiftStart"": ""9/1/2022 08:00:00"",
				""ShiftEnd"": ""9/1/2022 17:00:00"",
				""Working"" : false,
				""DurationInMin"" : 60
            }
		]
	}
	]
");
        }
    }
}
