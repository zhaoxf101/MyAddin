using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FE_Fee))]
#if Dev
    [RunLocal]
#endif

	public class FE_Fee:ReadOnlyBase<FE_Fee>
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

		
        public int? FeeItemOrder
        {
            get ;
            set ;
        }

		
        public string Remark
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

		
        public string GLMark
        {
            get ;
            set ;
        }

		
        public bool IsTimeCheck
        {
            get ;
            set ;
        }

		
        public bool IsFeeStd
        {
            get ;
            set ;
        }

		
        public bool IsOuter
        {
            get ;
            set ;
        }

		
        public string UserGroup
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public string FeeItemType
        {
            get ;
            set ;
        }

		
        public string TCode
        {
            get ;
            set ;
        }

		
        public string SumType
        {
            get ;
            set ;
        }

		
        public bool IsOpenItem
        {
            get ;
            set ;
        }

		
        public string IncDetCode
        {
            get ;
            set ;
        }

		
        public bool IsInc
        {
            get ;
            set ;
        }

		
        public string ProfitCtrType
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FE_Fee Create()
        {
            return EF.DataPortal.Create<FE_Fee>();
        }

		public static FE_Fee Fetch(System.Linq.Expressions.Expression<Func<FE_Fee, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FE_Fee>(exp,values);
            return EF.DataPortal.Fetch<FE_Fee>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FE_Fees))]
#if Dev
    [RunLocal]
#endif
	
	public class FE_Fees:ReadOnlyListBase<FE_Fees,FE_Fee>
    {
        #region Factory Methods

        public static FE_Fees Fetch()
        {
            return EF.DataPortal.Fetch<FE_Fees>();
        }

		public static FE_Fees Fetch(System.Linq.Expressions.Expression<Func<FE_Fee, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FE_Fee>(exp,values);
            return EF.DataPortal.Fetch<FE_Fees>(lambda);
		}

		public static FE_Fees Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FE_Fees>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FE_Fees Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FE_Fee, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FE_Fees>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FE_Fee>(exp,values)});
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
