﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class CeilingFan
    {
        private IFanState _currentState;

        public CeilingFan(IFanState initialState) => _currentState = initialState;

        public void PullChain()
        {
            _currentState.HandlePullChain(this);
        }

        public void ChangeState(IFanState newState) => _currentState = newState;
    }
}
