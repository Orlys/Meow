// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz.Dynamic
{
    using Infrastructure;
    using System.Dynamic;
    using System.Linq.Expressions;

    public abstract class RuntimeAttributes : IDynamicMetaObjectProvider
    {
        #region Protected Constructors

        protected RuntimeAttributes(Attributes attributes)
        {
            this._component = new DynamicComponent(attributes);
        }

        #endregion Protected Constructors

        private class DelegatingMetaObject : DynamicMetaObject
        {
            #region Internal Constructors

            internal DelegatingMetaObject(IDynamicMetaObjectProvider innerProvider, Expression expr, BindingRestrictions restrictions)
                : base(expr, restrictions)
            {
                this.innerProvider = innerProvider;
            }

            internal DelegatingMetaObject(IDynamicMetaObjectProvider innerProvider, Expression expr, BindingRestrictions restrictions, object value)
                : base(expr, restrictions, value)
            {
                this.innerProvider = innerProvider;
            }

            #endregion Internal Constructors

            #region Private Fields

            private readonly IDynamicMetaObjectProvider innerProvider;

            #endregion Private Fields

            #region Public Methods

            public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
                => innerProvider.GetMetaObject(Expression.Constant(innerProvider)).BindGetMember(binder);

            public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
                => innerProvider.GetMetaObject(Expression.Constant(innerProvider)).BindSetMember(binder, value);

            #endregion Public Methods
        }

        #region Private Classes

        private class DynamicComponent : DynamicObject
        {
            #region Public Constructors

            public DynamicComponent(Attributes attributes)
            {
                this._attributes = attributes;
            }

            #endregion Public Constructors

            #region Private Fields

            private readonly Attributes _attributes;

            #endregion Private Fields

            #region Public Methods

            public override bool TryGetMember(GetMemberBinder binder, out object result)
            {
                result = this._attributes[binder.Name];
                return true;
            }

            public override bool TrySetMember(SetMemberBinder binder, object value)
            {
                this._attributes[binder.Name] = value?.ToString();
                return true;
            }

            #endregion Public Methods
        }

        #endregion Private Classes

        #region Private Fields

        private readonly IDynamicMetaObjectProvider _component;

        #endregion Private Fields

        #region Public Methods

        public DynamicMetaObject GetMetaObject(Expression parameter)
            => new DelegatingMetaObject(_component, parameter, BindingRestrictions.GetTypeRestriction(parameter, this.GetType()), this);

        #endregion Public Methods
    }
}