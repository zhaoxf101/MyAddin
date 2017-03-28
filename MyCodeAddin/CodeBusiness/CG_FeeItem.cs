using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CG_FeeItem))]
#if Dev
    [RunLocal]
#endif

	public class CG_FeeItem:ReadOnlyBase<CG_FeeItem>
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

		
        public string FeeItemType
        {
            get ;
            set ;
        }

		
        public int Sort
        {
            get ;
            set ;
        }

		
        public string Memo
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

		
        public string BAccCode
        {
            get ;
            set ;
        }

		
        public bool IsInc
        {
            get ;
            set ;
        }

		
        public string GLMark
        {
            get ;
            set ;
        }

		
        public string IncDetCode
        {
            get ;
            set ;
        }

		
        public string GetProType
        {
            get ;
            set ;
        }

		
        public string SumType
        {
            get ;
            set ;
        }

		
        public string WorkFlowId
        {
            get ;
            set ;
        }

		
        public string CreateUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreateDate
        {
            get ;
            set ;
        }

		
        public string ChangeUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangeDate
        {
            get ;
            set ;
        }

		
        public bool IsOrder
        {
            get ;
            set ;
        }

		
        public bool IsActive
        {
            get ;
            set ;
        }

		
        public bool? IsDel
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static CG_FeeItem Create()
        {
            return EF.DataPortal.Create<CG_FeeItem>();
        }

		public static CG_FeeItem Fetch(System.Linq.Expressions.Expression<Func<CG_FeeItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CG_FeeItem>(exp,values);
            return EF.DataPortal.Fetch<CG_FeeItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CG_FeeItems))]
#if Dev
    [RunLocal]
#endif
	
	public class CG_FeeItems:ReadOnlyListBase<CG_FeeItems,CG_FeeItem>
    {
        #region Factory Methods

        public static CG_FeeItems Fetch()
        {
            return EF.DataPortal.Fetch<CG_FeeItems>();
        }

		public static CG_FeeItems Fetch(System.Linq.Expressions.Expression<Func<CG_FeeItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CG_FeeItem>(exp,values);
            return EF.DataPortal.Fetch<CG_FeeItems>(lambda);
		}

		public static CG_FeeItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CG_FeeItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CG_FeeItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CG_FeeItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CG_FeeItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CG_FeeItem>(exp,values)});
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
