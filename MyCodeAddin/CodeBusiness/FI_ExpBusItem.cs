using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpBusItem))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpBusItem:ReadOnlyBase<FI_ExpBusItem>
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

		
        public string ExpItemId
        {
            get ;
            set ;
        }

		
        public string ExpBusType
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string TaskCode
        {
            get ;
            set ;
        }

		
        public string ExpItemCode
        {
            get ;
            set ;
        }

		
        public string PBudExpEcoCode
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt
        {
            get ;
            set ;
        }

		
        public decimal ActAmt
        {
            get ;
            set ;
        }

		
        public decimal OrdAmt
        {
            get ;
            set ;
        }

		
        public System.Data.Linq.Binary TimeStamp
        {
            get ;
            set ;
        }

		
        public string CreatedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public string ChangedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_ExpBusItem Create()
        {
            return EF.DataPortal.Create<FI_ExpBusItem>();
        }

		public static FI_ExpBusItem Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusItem>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpBusItems))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpBusItems:ReadOnlyListBase<FI_ExpBusItems,FI_ExpBusItem>
    {
        #region Factory Methods

        public static FI_ExpBusItems Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpBusItems>();
        }

		public static FI_ExpBusItems Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusItem>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusItems>(lambda);
		}

		public static FI_ExpBusItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpBusItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpBusItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpBusItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpBusItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpBusItem>(exp,values)});
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
