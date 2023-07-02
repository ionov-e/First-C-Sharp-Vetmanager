using static FirstCSharp.VetmanagerApiGateway.PathUri.Filter;

namespace FirstCSharp.VetmanagerApiGateway.PathUri
{
    public static class OperationEnumExtensionMethod
    {
        public static string AsString(this OperationsWithSingleValue operation)
        {
            return operation switch
            {
                OperationsWithSingleValue.Equals => "=",
                OperationsWithSingleValue.NotEquals => "!=",
                OperationsWithSingleValue.LessThan => "<",
                OperationsWithSingleValue.GreaterThan => ">",
                OperationsWithSingleValue.EqualsOrLess => "<=",
                OperationsWithSingleValue.EqualsOrGreater => ">=",
                OperationsWithSingleValue.Like => "like",
                _ => throw new NotImplementedException(),
            };
        }

        public static string AsString(this OperationsWithArrayValue operation)
        {
            return operation switch
            {
                OperationsWithArrayValue.In => "in",
                OperationsWithArrayValue.NotIn => "not in",
                _ => throw new NotImplementedException(),
            };
        }
    }
}
