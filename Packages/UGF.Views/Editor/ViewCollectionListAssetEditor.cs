using UGF.EditorTools.Editor.Assets;
using UGF.EditorTools.Editor.IMGUI;
using UGF.EditorTools.Editor.IMGUI.Scopes;
using UGF.Views.Runtime;
using UnityEditor;

namespace UGF.Views.Editor
{
    [CustomEditor(typeof(ViewCollectionListAsset), true)]
    internal class ViewCollectionListAssetEditor : UnityEditor.Editor
    {
        private AssetIdReferenceListDrawer m_listViews;
        private ReorderableListSelectionDrawerByPath m_listViewsSelection;
        private ReorderableListDrawer m_listCollections;
        private ReorderableListSelectionDrawerByElement m_listCollectionsSelection;

        private void OnEnable()
        {
            m_listViews = new AssetIdReferenceListDrawer(serializedObject.FindProperty("m_views"));

            m_listViewsSelection = new ReorderableListSelectionDrawerByPath(m_listViews, "m_asset")
            {
                Drawer = { DisplayTitlebar = true }
            };

            m_listCollections = new ReorderableListDrawer(serializedObject.FindProperty("m_collections"));

            m_listCollectionsSelection = new ReorderableListSelectionDrawerByElement(m_listCollections)
            {
                Drawer = { DisplayTitlebar = true }
            };

            m_listViews.Enable();
            m_listViewsSelection.Enable();
            m_listCollections.Enable();
            m_listCollectionsSelection.Enable();
        }

        private void OnDisable()
        {
            m_listViews.Disable();
            m_listViewsSelection.Disable();
            m_listCollections.Disable();
            m_listCollectionsSelection.Disable();
        }

        public override void OnInspectorGUI()
        {
            using (new SerializedObjectUpdateScope(serializedObject))
            {
                EditorIMGUIUtility.DrawScriptProperty(serializedObject);

                m_listViews.DrawGUILayout();
                m_listCollections.DrawGUILayout();

                m_listViewsSelection.DrawGUILayout();
                m_listCollectionsSelection.DrawGUILayout();
            }
        }
    }
}
