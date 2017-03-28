using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CG_Check))]
#if Dev
    [RunLocal]
#endif

	public class CG_Check:ReadOnlyBase<CG_Check>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string DebitDate
        {
            get ;
            set ;
        }

		
        public string StartDate
        {
            get ;
            set ;
        }

		
        public string EndDate
        {
            get ;
            set ;
        }

		
        public decimal TransactionFee
        {
            get ;
            set ;
        }

		
        public int TransactionCount
        {
            get ;
            set ;
        }

		
        public bool IsCheck
        {
            get ;
            set ;
        }

		
        public string BillNo
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static CG_Check Create()
        {
            return EF.DataPortal.Create<CG_Check>();
        }

		public static CG_Check Fetch(System.Linq.Expressions.Expression<Func<CG_Check, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CG_Check>(exp,values);
            return EF.DataPortal.Fetch<CG_Check>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CG_Checks))]
#if Dev
    [RunLocal]
#endif
	
	public class CG_Checks:ReadOnlyListBase<CG_Checks,CG_Check>
    {
        #region Factory Methods

        public static CG_Checks Fetch()
        {
            return EF.DataPortal.Fetch<CG_Checks>();
        }

		public static CG_Checks Fetch(System.Linq.Expressions.Expression<Func<CG_Check, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CG_Check>(exp,values);
            return EF.DataPortal.Fetch<CG_Checks>(lambda);
		}

		public static CG_Checks Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CG_Checks>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CG_Checks Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CG_Check, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CG_Checks>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CG_Check>(exp,values)});
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
