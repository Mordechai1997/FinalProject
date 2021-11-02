using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
        abstract class GenericStore
        {
           protected bool isOpen;
           protected int totalProducts = 0;
           protected float totalSumPurchase = 0;
            public virtual void openStore() { }
            public virtual void closeStore() { }
            public virtual int getTotalProductsCount() { return totalProducts; }
            public virtual float getTotalSumOfPurchase() { return totalSumPurchase; }
        }

}
