using UGF.EditorTools.Runtime.Ids;
using UnityEngine;

namespace UGF.Views.Runtime
{
    [AddComponentMenu("Unity Game Framework/Views/View Id", 2000)]
    public class ViewIdComponent : ViewValueComponent<GlobalId>
    {
        protected override bool OnValueValidate(GlobalId value)
        {
            return value.IsValid();
        }
    }
}
