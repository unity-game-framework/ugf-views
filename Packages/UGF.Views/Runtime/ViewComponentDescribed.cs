using System;
using UnityEngine;

namespace UGF.Views.Runtime
{
    public class ViewComponentDescribed<TDescription, TComponent> : ViewDescribed<TDescription>, IViewComponent
        where TDescription : class, IViewDescription
        where TComponent : Component
    {
        public TComponent Component { get { return m_component ? m_component : throw new ArgumentException("Value not specified."); } }
        public bool HasComponent { get { return m_component != null; } }

        Component IViewComponent.Component { get { return Component; } }

        private TComponent m_component;

        public ViewComponentDescribed(TDescription description) : base(description)
        {
        }

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

        void IViewComponent.SetView(Component component)
        {
            SetView((TComponent)component);
        }
    }
}
