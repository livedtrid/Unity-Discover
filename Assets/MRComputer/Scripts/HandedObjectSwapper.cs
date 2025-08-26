// Copyright (c) Meta Platforms, Inc. and affiliates.

using UnityEngine;

namespace MRComputer.Scripts
{
    public class HandedObjectSwapper : MonoBehaviour
    {
        [SerializeField] private GameObject m_rightHandObject;
        [SerializeField] private GameObject m_leftHandObject;
        [SerializeField] private MRBike.BikeVisibleObject m_bikeVisibleObject;

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
                m_bikeVisibleObject.Trigger();
            }
        }

        public void SetLeft()
        {
            if (m_currentHandednessIsRight)
            {
                m_currentHandednessIsRight = false;
                m_bikeVisibleObject.Trigger();
            }
        }
    }
}