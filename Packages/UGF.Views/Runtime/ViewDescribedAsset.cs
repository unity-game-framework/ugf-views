using System;
using UGF.Builder.Runtime;
using UGF.Description.Runtime;

namespace UGF.Views.Runtime
{
    public abstract class ViewDescribedAsset<TView, TDescription> : ViewAsset, IDescribedBuilder, IDescriptionBuilder
        where TView : class, IView, IDescribed
        where TDescription : class, IViewDescription
    {
        protected override IView OnBuild()
        {
            TDescription description = OnBuildDescription();

            if (description == null) throw new ArgumentNullException(nameof(description));

            return OnBuild(description);
        }

        protected abstract TDescription OnBuildDescription();
        protected abstract TView OnBuild(TDescription description);

        T IBuilder<IDescribed>.Build<T>()
        {
            return (T)Build();
        }

        IDescribed IBuilder<IDescribed>.Build()
        {
            return (IDescribed)Build();
        }

        T IBuilder<IDescription>.Build<T>()
        {
            return (T)(object)OnBuildDescription();
        }

        IDescription IBuilder<IDescription>.Build()
        {
            return OnBuildDescription();
        }
    }
}
