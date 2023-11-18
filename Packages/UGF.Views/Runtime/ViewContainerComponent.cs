using System;
using UGF.RuntimeTools.Runtime.Containers;
using UnityEngine;

namespace UGF.Views.Runtime
{
    [AddComponentMenu("Unity Game Framework/Views/View Container", 2000)]
    public class ViewContainerComponent : MonoBehaviour
    {
        public ContainerComponent Instance { get { return m_container ? m_container : throw new ArgumentException("Value not specified."); } }
        public bool HasInstance { get { return m_container != null; } }

        private ContainerComponent m_container;

        public void Set(ContainerComponent container)
        {
            m_container = container ? container : throw new ArgumentNullException(nameof(container));
        }

        public void Clear()
        {
            m_container = default;
        }
    }
}
