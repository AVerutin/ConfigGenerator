namespace ConfigGenerator.Data
{
    public class SignalView
    {
        public string Uid { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string DataBlockName { get; set; }
        public string Byte { get; set; }

        public SignalView()
        {
            Uid = default;
            Name = default;
            Type = default;
            DataBlockName = default;
            Byte = default;
        }
    }
}