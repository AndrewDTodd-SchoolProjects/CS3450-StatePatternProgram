namespace StatePattern
{
    internal class OffState : IFanState
    {
        public void HandlePullChain(CeilingFan fan)
        {
            Console.WriteLine("Switching fan to Low Speed");
            fan.ChangeState(new LowSpeedState());
        }
    }
}