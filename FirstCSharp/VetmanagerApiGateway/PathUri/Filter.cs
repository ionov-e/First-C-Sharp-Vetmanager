namespace FirstCSharp.VetmanagerApiGateway.PathUri
{
    public class Filter
    {
        private readonly string _property;
        private readonly string _value;
        private readonly string? _operation;

        public Filter(string property, string value)
        {
            _property = property;
            _value = value;
        }

        public Filter(string property, string value, OperationsWithSingleValue operation)
        {
            _property = property;
            _value = value;
            _operation = operation.AsString();
        }

        public Filter(string property, string[] values, OperationsWithArrayValue operation)
        {
            _property = property;
            _value = ValuesToString(values);
            _operation = operation.AsString();
        }

        public override string ToString()
        {
            return "{'property':'" + _property + "', 'value':'" + _value + "'" + GetOperatorAsString() + "}";
        }

        private string ValuesToString(string[] values)
        {
            string valuesAsString = "";
            foreach(string value in values)
            {
                valuesAsString += $"'{value}'";

            if (!value.Equals(values.Last()))
                {
                    valuesAsString += ',';
                }
            }
            return $"[{valuesAsString}]";
        }

        private string GetOperatorAsString()
        {
            return _operation == null
                ? ""
                : ", 'operator':'" + _operation + "'";
        }

        public enum OperationsWithSingleValue
        {
            Equals,
            NotEquals,
            GreaterThan,
            LessThan,
            EqualsOrGreater,
            EqualsOrLess,
            Like
        }

        public enum OperationsWithArrayValue
        {
            In,
            NotIn
        }
    }
}
