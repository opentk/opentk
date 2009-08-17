using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Graphics.Text
{
    class PoolableTextExtents : TextExtents, IPoolable<PoolableTextExtents>
    {
        ObjectPool<PoolableTextExtents> owner;

        #region Constructors

        public PoolableTextExtents()
        {
        }

        #endregion

        #region IPoolable<PoolableTextExtents> Members

        ObjectPool<PoolableTextExtents> IPoolable<PoolableTextExtents>.Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        #endregion

        #region IPoolable Members

        void IPoolable.OnAcquire()
        {
            Clear();
        }

        void IPoolable.OnRelease()
        {
        }

        #endregion
    }
}
