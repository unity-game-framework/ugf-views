using UnityEngine;

namespace UGF.Views.Runtime
{
    [AddComponentMenu("Unity Game Framework/Views/View Object", 2000)]
    public class ViewObjectComponent : ViewValueComponent<Object>
    {
        protected override bool OnValueValidate(Object value)
        {
            return value != null;
        }
    }
}
