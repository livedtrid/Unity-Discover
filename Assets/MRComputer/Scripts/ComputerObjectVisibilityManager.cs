// Copyright (c) Meta Platforms, Inc. and affiliates.

using System.Collections.Generic;
using UnityEngine;

namespace MRComputer.Scripts
{
    public class ComputerObjectVisibilityManager : MonoBehaviour
    {
        private Dictionary<int, ComputerVisibleObject> m_computerParts = new();

        public void RegisterVisibleObject(ComputerVisibleObject visibleObject, int partNum)
        {
            try
            {
                m_computerParts.Add(partNum, visibleObject);
            }
            catch
            {
                Debug.Log($"[Bike] -- REGISTRATION FAILED -- {visibleObject.name} | part: {partNum}");
            }
        }


        public void HideNetworkObject(int partNum)
        {
            if (m_computerParts.TryGetValue(partNum, out var computerPart))
            {
                computerPart.Hide();
            }
        }

        public void ShowNetworkObject(int partNum)
        {
            if (m_computerParts.TryGetValue(partNum, out var computerPart))
            {
                computerPart.Show();
            }
        }

        public void RotatorGrabNetworkObject(int partNum)
        {
            if (m_computerParts.TryGetValue(partNum, out var computerPart))
            {
                computerPart.RotatorGrab();
            }
        }

        public void RotatorReleaseNetworkObject(int partNum)
        {
            if (m_computerParts.TryGetValue(partNum, out var computerPart))
            {
                computerPart.RotatorRelease();
            }
        }

        public void SendNetworkTrigger(int partNum)
        {
            if (m_computerParts.TryGetValue(partNum, out var computerPart))
            {
                computerPart.Trigger();
            }
        }

        public void AffordanceActivate(int partNum)
        {
            if (m_computerParts.TryGetValue(partNum, out var computerPart))
            {
                computerPart.AffordanceActivate();
            }
        }

        public void AffordanceDeactivate(int partNum)
        {
            if (m_computerParts.TryGetValue(partNum, out var computerPart))
            {
                computerPart.AffordanceDeactivate();
            }
        }
    }
}