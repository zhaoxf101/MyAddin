using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_IncProjLedger))]
#if Dev
    [RunLocal]
#endif

	public class PM_IncProjLedger:ReadOnlyBase<PM_IncProjLedger>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string Year
        {
            get ;
            set ;
        }

		
        public string IncProjCode
        {
            get ;
            set ;
        }

		
        public string SBudIncTypeCode
        {
            get ;
            set ;
        }

		
        public string ExpFundTypeCode
        {
            get ;
            set ;
        }

		
        public string PBudIncTypeCode
        {
            get ;
            set ;
        }

		
        public string DAccCode
        {
            get ;
            set ;
        }

		
        public string CAccCode
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public decimal BudAmt
        {
            get ;
            set ;
        }

		
        public decimal AdjAmt
        {
            get ;
            set ;
        }

		
        public decimal IncAmt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_IncProjLedger Create()
        {
            return EF.DataPortal.Create<PM_IncProjLedger>();
        }

		public static PM_IncProjLedger Fetch(System.Linq.Expressions.Expression<Func<PM_IncProjLedger, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_IncProjLedger>(exp,values);
            return EF.DataPortal.Fetch<PM_IncProjLedger>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_IncProjLedgers))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_IncProjLedgers:ReadOnlyListBase<PM_IncProjLedgers,PM_IncProjLedger>
    {
        #region Factory Methods

        public static PM_IncProjLedgers Fetch()
        {
            return EF.DataPortal.Fetch<PM_IncProjLedgers>();
        }

		public static PM_IncProjLedgers Fetch(System.Linq.Expressions.Expression<Func<PM_IncProjLedger, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_IncProjLedger>(exp,values);
            return EF.DataPortal.Fetch<PM_IncProjLedgers>(lambda);
		}

		public static PM_IncProjLedgers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_IncProjLedgers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_IncProjLedgers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_IncProjLedger, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_IncProjLedgers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_IncProjLedger>(exp,values)});
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
