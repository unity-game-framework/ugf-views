using System;
using System.Collections.Generic;
using UGF.Builder.Runtime;
using UGF.EditorTools.Runtime.Ids;
using UnityEngine;

namespace UGF.Views.Runtime
{
    public abstract class ViewCollectionAsset : ScriptableObject
    {
        public void GetViews(IDictionary<GlobalId, IBuilder<IView>> views)
        {
            if (views == null) throw new ArgumentNullException(nameof(views));

            OnGetViews(views);
        }

        protected abstract void OnGetViews(IDictionary<GlobalId, IBuilder<IView>> views);
    }
}
