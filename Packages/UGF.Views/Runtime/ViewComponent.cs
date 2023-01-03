using System;
using UnityEngine;

namespace UGF.Views.Runtime
{
    public class ViewComponent<TComponent> : View where TComponent : Component
    {
        public TComponent Component { get { return m_component ? m_component : throw new ArgumentException("Value not specified."); } }
        public bool HasComponent { get { return m_component != null; } }

        private TComponent m_component;

        public void SetView(TComponent component)
        {
            m_component = component ? component : throw new ArgumentNullException(nameof(component));

            OnSetView();
        }

        public void ClearView()
        {
            OnClearingView();

            m_component = default;
        }

        protected virtual void OnSetView()
        {
        }

        protected virtual void OnClearingView()
        {
        }
    }
}
