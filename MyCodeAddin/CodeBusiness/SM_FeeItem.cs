using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_FeeItem))]
#if Dev
    [RunLocal]
#endif

	public class SM_FeeItem:ReadOnlyBase<SM_FeeItem>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string FeeItemCode
        {
            get ;
            set ;
        }

		
        public string FeeItemName
        {
            get ;
            set ;
        }

		
        public string IncDetCode
        {
            get ;
            set ;
        }

		
        public bool IsEscrow
        {
            get ;
            set ;
        }

		
        public bool IsAllo
        {
            get ;
            set ;
        }

		
        public string AccType
        {
            get ;
            set ;
        }

		
        public string AccCode
        {
            get ;
            set ;
        }

		
        public string OldFeeItemCode
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static SM_FeeItem Create()
        {
            return EF.DataPortal.Create<SM_FeeItem>();
        }

		public static SM_FeeItem Fetch(System.Linq.Expressions.Expression<Func<SM_FeeItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_FeeItem>(exp,values);
            return EF.DataPortal.Fetch<SM_FeeItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_FeeItems))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_FeeItems:ReadOnlyListBase<SM_FeeItems,SM_FeeItem>
    {
        #region Factory Methods

        public static SM_FeeItems Fetch()
        {
            return EF.DataPortal.Fetch<SM_FeeItems>();
        }

		public static SM_FeeItems Fetch(System.Linq.Expressions.Expression<Func<SM_FeeItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_FeeItem>(exp,values);
            return EF.DataPortal.Fetch<SM_FeeItems>(lambda);
		}

		public static SM_FeeItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_FeeItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_FeeItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_FeeItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_FeeItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_FeeItem>(exp,values)});
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
