using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpBusVendor))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpBusVendor:ReadOnlyBase<FI_ExpBusVendor>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ExpBusCode
        {
            get ;
            set ;
        }

		
        public string VendorCode
        {
            get ;
            set ;
        }

		
        public string GLMark
        {
            get ;
            set ;
        }

		
        public string ItemText
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public decimal ActAmt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_ExpBusVendor Create()
        {
            return EF.DataPortal.Create<FI_ExpBusVendor>();
        }

		public static FI_ExpBusVendor Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusVendor, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusVendor>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusVendor>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpBusVendors))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpBusVendors:ReadOnlyListBase<FI_ExpBusVendors,FI_ExpBusVendor>
    {
        #region Factory Methods

        public static FI_ExpBusVendors Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpBusVendors>();
        }

		public static FI_ExpBusVendors Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusVendor, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusVendor>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusVendors>(lambda);
		}

		public static FI_ExpBusVendors Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpBusVendors>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpBusVendors Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpBusVendor, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpBusVendors>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpBusVendor>(exp,values)});
        }

        #endregion

		[Serializable]
        public class Paging
        {
            public int Page { get; set; }
            public int RowCount { get; set; }
            public int StartIndex
            {
                get 
                {
                    if (Page >= 0 && RowCount > 0)
                    {
                        return Page * RowCount;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        [Serializable]
        public class PagigExpress
        {
            public int Page { get; set; }
            public int RowCount { get; set; }
            public int StartIndex
            {
                get
                {
                    if (Page >= 0 && RowCount > 0)
                    {
                        return Page * RowCount;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            public LambdaExpression Lambda { get; set; }
        }

    }
}
