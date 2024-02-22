using System;
using UnityEngine;

namespace UGF.Views.Runtime
{
    public abstract class ViewValueComponent<TValue> : MonoBehaviour
    {
        public TValue Value { get { return HasValue ? m_value : throw new ArgumentException("Value not specified."); } }
        public bool HasValue { get; private set; }

        private TValue m_value;

        public void Set(TValue value)
        {
            if (!OnValueValidate(value)) throw new ArgumentException("Value should be valid.", nameof(value));

            m_value = value;

            HasValue = true;
        }

        public void Clear()
        {
            m_value = default;

            HasValue = false;
        }

        protected virtual bool OnValueValidate(TValue value)
        {
            return true;
        }
    }
}
