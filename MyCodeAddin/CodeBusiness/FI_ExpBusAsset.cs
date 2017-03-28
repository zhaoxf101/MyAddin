using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpBusAsset))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpBusAsset:ReadOnlyBase<FI_ExpBusAsset>
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

		
        public string InBillNo
        {
            get ;
            set ;
        }

		
        public string AccCls
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_ExpBusAsset Create()
        {
            return EF.DataPortal.Create<FI_ExpBusAsset>();
        }

		public static FI_ExpBusAsset Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusAsset, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusAsset>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusAsset>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpBusAssets))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpBusAssets:ReadOnlyListBase<FI_ExpBusAssets,FI_ExpBusAsset>
    {
        #region Factory Methods

        public static FI_ExpBusAssets Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpBusAssets>();
        }

		public static FI_ExpBusAssets Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusAsset, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusAsset>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusAssets>(lambda);
		}

		public static FI_ExpBusAssets Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpBusAssets>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpBusAssets Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpBusAsset, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpBusAssets>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpBusAsset>(exp,values)});
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
