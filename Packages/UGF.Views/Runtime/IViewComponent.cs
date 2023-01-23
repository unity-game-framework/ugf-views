using UnityEngine;

namespace UGF.Views.Runtime
{
    public interface IViewComponent : IView
    {
        Component Component { get; }
        bool HasComponent { get; }

        void SetView(Component component);
        void ClearView();
    }
}
