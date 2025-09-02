// Copyright (c) Meta Platforms, Inc. and affiliates.

using UnityEngine;
using UnityEngine.Serialization;

namespace MRComputer.Scripts
{
    public class HandedObjectSwapper : MonoBehaviour
    {
        [SerializeField] private GameObject m_rightHandObject;
        [SerializeField] private GameObject m_leftHandObject;
        [FormerlySerializedAs("m_bikeVisibleObject")] [SerializeField] private ComputerVisibleObject m_computerVisibleObject;

        private bool m_currentHandednessIsRight = true;

        public void SwapObjects()
        {
            if (m_rightHandObject.activeSelf)
            {
                m_rightHandObject.SetActive(false);
                m_leftHandObject.SetActive(true);
            }
            else
            {
                m_rightHandObject.SetActive(true);
                m_leftHandObject.SetActive(false);
            }
        }

        public void SetRight()
        {
            if (!m_currentHandednessIsRight)
            {
                m_currentHandednessIsRight = true;
                m_computerVisibleObject.Trigger();
            }
        }

        public void SetLeft()
        {
            if (m_currentHandednessIsRight)
            {
                m_currentHandednessIsRight = false;
                m_computerVisibleObject.Trigger();
            }
        }
    }
}