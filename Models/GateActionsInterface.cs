using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BETRAGATEWAY.Models
{
    interface GateActions
    {
        void Open();
        void Close();
        void AddCards();
        void RemoveCard();
        void TriggerAlarm();
        
    }
}
