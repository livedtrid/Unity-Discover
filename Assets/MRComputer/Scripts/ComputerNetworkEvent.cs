using UnityEngine;
using UnityEngine.Events;

namespace MRComputer.Scripts
{
    public class ComputerNetworkEvent : MonoBehaviour
    {
        public UnityEvent NetworkTriggerEvent;

        public void OnEventActivate()
        {
            NetworkTriggerEvent.Invoke();
        }
    }
}
