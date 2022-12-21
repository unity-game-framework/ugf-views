using System;
using UGF.Description.Runtime;

namespace UGF.Views.Runtime
{
    public abstract class ViewDescribed<TDescription> : View, IDescribed<TDescription> where TDescription : class, IViewDescription
    {
        public TDescription Description { get; }

        protected ViewDescribed(TDescription description)
        {
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }

        public T GetDescription<T>() where T : class, IDescription
        {
            return (T)GetDescription();
        }

        public IDescription GetDescription()
        {
            return Description;
        }
    }
}
