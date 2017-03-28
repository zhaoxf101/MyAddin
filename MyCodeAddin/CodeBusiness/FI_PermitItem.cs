using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PermitItem))]
#if Dev
    [RunLocal]
#endif

	public class FI_PermitItem:ReadOnlyBase<FI_PermitItem>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string PermitItemCode
        {
            get ;
            set ;
        }

		
        public string PermitItemName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_PermitItem Create()
        {
            return EF.DataPortal.Create<FI_PermitItem>();
        }

		public static FI_PermitItem Fetch(System.Linq.Expressions.Expression<Func<FI_PermitItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PermitItem>(exp,values);
            return EF.DataPortal.Fetch<FI_PermitItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PermitItems))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PermitItems:ReadOnlyListBase<FI_PermitItems,FI_PermitItem>
    {
        #region Factory Methods

        public static FI_PermitItems Fetch()
        {
            return EF.DataPortal.Fetch<FI_PermitItems>();
        }

		public static FI_PermitItems Fetch(System.Linq.Expressions.Expression<Func<FI_PermitItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PermitItem>(exp,values);
            return EF.DataPortal.Fetch<FI_PermitItems>(lambda);
		}

		public static FI_PermitItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PermitItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PermitItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PermitItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PermitItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PermitItem>(exp,values)});
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
