using System.Collections.Generic;
using UGF.Builder.Runtime;
using UGF.EditorTools.Runtime.Assets;
using UGF.EditorTools.Runtime.Ids;
using UnityEngine;

namespace UGF.Views.Runtime
{
    [CreateAssetMenu(menuName = "Unity Game Framework/Views/View Collection List", order = 2000)]
    public class ViewCollectionListAsset : ViewCollectionAsset
    {
        [SerializeField] private List<AssetIdReference<ViewAsset>> m_views = new List<AssetIdReference<ViewAsset>>();
        [SerializeField] private List<ViewCollectionAsset> m_collections = new List<ViewCollectionAsset>();

        public List<AssetIdReference<ViewAsset>> Views { get { return m_views; } }
        public List<ViewCollectionAsset> Collections { get { return m_collections; } }

        protected override void OnGetViews(IDictionary<GlobalId, IBuilder<IView>> views)
        {
            for (int i = 0; i < m_views.Count; i++)
            {
                AssetIdReference<ViewAsset> reference = m_views[i];

                views.Add(reference.Guid, reference.Asset);
            }

            for (int i = 0; i < m_collections.Count; i++)
            {
                ViewCollectionAsset collection = m_collections[i];

                collection.GetViews(views);
            }
        }
    }
}
