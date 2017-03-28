using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_StdBill))]
#if Dev
    [RunLocal]
#endif

	public class EF_StdBill:ReadOnlyBase<EF_StdBill>
    {
        #region Business Methods

		
        public string SetStd
        {
            get ;
            set ;
        }

		
        public string SetUnit
        {
            get ;
            set ;
        }

		
        public string SetVal
        {
            get ;
            set ;
        }

		
        public string ParentId
        {
            get ;
            set ;
        }

		
        public bool IsLeaf
        {
            get ;
            set ;
        }

		
        public int SeqNR
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_StdBill Create()
        {
            return EF.DataPortal.Create<EF_StdBill>();
        }

		public static EF_StdBill Fetch(System.Linq.Expressions.Expression<Func<EF_StdBill, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_StdBill>(exp,values);
            return EF.DataPortal.Fetch<EF_StdBill>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_StdBills))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_StdBills:ReadOnlyListBase<EF_StdBills,EF_StdBill>
    {
        #region Factory Methods

        public static EF_StdBills Fetch()
        {
            return EF.DataPortal.Fetch<EF_StdBills>();
        }

		public static EF_StdBills Fetch(System.Linq.Expressions.Expression<Func<EF_StdBill, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_StdBill>(exp,values);
            return EF.DataPortal.Fetch<EF_StdBills>(lambda);
		}

		public static EF_StdBills Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_StdBills>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_StdBills Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_StdBill, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_StdBills>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_StdBill>(exp,values)});
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
