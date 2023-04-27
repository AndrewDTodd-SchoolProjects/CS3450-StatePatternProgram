namespace StatePattern
{
    internal class MediumSpeedState : IFanState
    {
        public void HandlePullChain(CeilingFan fan)
        {
            Console.WriteLine("Switching fan to High Speed");
            fan.ChangeState(new HighSpeedState());
        }
    }
}