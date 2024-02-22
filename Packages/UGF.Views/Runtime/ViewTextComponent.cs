using UnityEngine;

namespace UGF.Views.Runtime
{
    [AddComponentMenu("Unity Game Framework/Views/View Text", 2000)]
    public class ViewTextComponent : ViewValueComponent<string>
    {
        protected override bool OnValueValidate(string value)
        {
            return !string.IsNullOrEmpty(value);
        }
    }
}
