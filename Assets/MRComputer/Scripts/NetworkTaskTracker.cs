using Fusion;
using UnityEngine;

namespace MRComputer.Scripts
{
    public class NetworkTaskTracker : MonoBehaviour
    {
        [SerializeField] private CourseTracker m_courseTracker;
        [SerializeField] private bool m_debug = false;

        public void TaskComplete(int taskNum)
        {
            OnTaskCompletedRPC(taskNum);
            if (m_debug)
                Debug.Log("[bike] -- task RPC sent :: Task number " + taskNum.ToString());
        }

        [Rpc(RpcSources.All, RpcTargets.All)]
        private void OnTaskCompletedRPC(int taskNum)
        {
            if (m_debug)
            {
                Debug.Log("[bike] RPC received:: Task number " + taskNum.ToString());
            }

            if (!m_courseTracker)
            {
                Debug.Log($"[NetworkTaskTracker]: No {nameof(CourseTracker)} set on {name}");
            }

            if (m_courseTracker)
            {
                m_courseTracker.CompleteTask(taskNum);
            }
        }
    }
}
