using System;
using UGF.EditorTools.Runtime.Ids;
using UnityEngine;

namespace UGF.Views.Runtime
{
    [AddComponentMenu("Unity Game Framework/Views/View Id", 2000)]
    public class ViewIdComponent : MonoBehaviour
    {
        public GlobalId Id { get { return m_id ?? throw new ArgumentException("Value not specified."); } }
        public bool HasId { get { return m_id.HasValue; } }

        private GlobalId? m_id;

        public void Set(GlobalId id)
        {
            if (!id.IsValid()) throw new ArgumentException("Value should be valid.", nameof(id));

            m_id = id;
        }

        public void Clear()
        {
            m_id = null;
        }
    }
}
