// Microsoft Power Fx Console Formula REPL
// 
// Console based Read-Eval-Print-Loop that supports variables and formula recalc
//
// Licensed under the MIT license

using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.PowerFx.Types;
using PowerFxHostSamples;

namespace WEM.Assignments
{
    internal class AssignmentTableType : TableType
    {
        private RecordType recordType = new AssignmentRecordType();

        public override bool Equals(object other)
        {
            return other is AssignmentTableType && recordType.Equals(((AssignmentTableType)other).recordType);
        }

        public override int GetHashCode()
        {
            return recordType.GetHashCode();
        }

        public override bool TryGetFieldType(string name, out FormulaType type)
        {
            return recordType.TryGetFieldType(name, out type);
        }

        internal TableValue ToTableValue()
        {
            var recordType = new AssignmentRecordType();
            var records = new List<RecordValue>();

            foreach (var record in recordType.values)
            {
                var value = FormulaValue.NewRecordFromFields(recordType, record.ToArray());
                records.Add(value);
            }
            return FormulaValue.NewTable(recordType, records);
        }
    }
}
