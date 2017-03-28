using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_SetBill))]
#if Dev
    [RunLocal]
#endif

	public class EF_SetBill:ReadOnlyBase<EF_SetBill>
    {
        #region Business Methods

		
        public string SetClass
        {
            get ;
            set ;
        }

		
        public string SetUnit
        {
            get ;
            set ;
        }

		
        public string SetCode
        {
            get ;
            set ;
        }

		
        public int LineId
        {
            get ;
            set ;
        }

		
        public string SubVal
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

		public static EF_SetBill Create()
        {
            return EF.DataPortal.Create<EF_SetBill>();
        }

		public static EF_SetBill Fetch(System.Linq.Expressions.Expression<Func<EF_SetBill, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_SetBill>(exp,values);
            return EF.DataPortal.Fetch<EF_SetBill>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_SetBills))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_SetBills:ReadOnlyListBase<EF_SetBills,EF_SetBill>
    {
        #region Factory Methods

        public static EF_SetBills Fetch()
        {
            return EF.DataPortal.Fetch<EF_SetBills>();
        }

		public static EF_SetBills Fetch(System.Linq.Expressions.Expression<Func<EF_SetBill, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_SetBill>(exp,values);
            return EF.DataPortal.Fetch<EF_SetBills>(lambda);
		}

		public static EF_SetBills Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_SetBills>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_SetBills Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_SetBill, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_SetBills>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_SetBill>(exp,values)});
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
