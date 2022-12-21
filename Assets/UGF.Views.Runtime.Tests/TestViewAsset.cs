using UnityEngine;

namespace UGF.Views.Runtime.Tests
{
    [CreateAssetMenu(menuName = "Tests/TestViewAsset")]
    public class TestViewAsset : ViewDescribedAsset<TestView, ViewDescription>
    {
        protected override ViewDescription OnBuildDescription()
        {
            return new ViewDescription();
        }

        protected override TestView OnBuild(ViewDescription description)
        {
            return new TestView(description);
        }
    }

    public class TestView : ViewDescribed<ViewDescription>
    {
        public TestView(ViewDescription description) : base(description)
        {
        }
    }
}
