namespace StatePattern
{
    internal class HighSpeedState : IFanState
    {
        public void HandlePullChain(CeilingFan fan)
        {
            Console.WriteLine("Switching fan OFF");
            fan.ChangeState(new OffState());
        }
    }
}