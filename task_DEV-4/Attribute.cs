namespace task_DEV_4
{
    public struct Attribute
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return $"[{Name}: {Value}]";
        }
    }
}