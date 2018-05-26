namespace OOPlaba2
{
    public struct RobotMachine
    {
        public string NameMachine { get; private set; }
        public int CountMachine { get; private set; }

        public RobotMachine(string nameMachine, int count)
        {
            NameMachine = nameMachine;
            CountMachine = count;
        }
    }
}
