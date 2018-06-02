namespace OOPlaba2
{
    public struct RobotMachine
    {
        public string NameMachine { get; set; }
        public int CountMachine { get; set; }

        public RobotMachine(string nameMachine, int count)
        {
            NameMachine = nameMachine;
            CountMachine = count;
        }
    }
}
