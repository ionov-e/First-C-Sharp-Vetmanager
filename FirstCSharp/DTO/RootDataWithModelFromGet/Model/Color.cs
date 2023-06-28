namespace FirstCSharp.DTO.RootDataWithModel.Model
{
    public class Color : AbstractModel
    {
        public required string combo_manual_id { get; set; }
        public required string title { get; set; }
        public required string value { get; set; }
        public required string dop_param1 { get; set; }
        public required string dop_param2 { get; set; }
        public required string dop_param3 { get; set; }
        public required string is_active { get; set; }
    }
}
