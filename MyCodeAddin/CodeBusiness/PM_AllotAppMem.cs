using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_AllotAppMem))]
#if Dev
    [RunLocal]
#endif

	public class PM_AllotAppMem:ReadOnlyBase<PM_AllotAppMem>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string TaskCode
        {
            get ;
            set ;
        }

		
        public string AllotAppNo
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string FundCode
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string CostCtr
        {
            get ;
            set ;
        }

		
        public string ProfitCtr
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public decimal FDAmt
        {
            get ;
            set ;
        }

		
        public decimal AppAmt
        {
            get ;
            set ;
        }

		
        public decimal AlloAmt
        {
            get ;
            set ;
        }

		
        public decimal TaxAmt
        {
            get ;
            set ;
        }

		
        public decimal FeeAmt
        {
            get ;
            set ;
        }

		
        public bool IsEscrow
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public string Memo
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

		public static PM_AllotAppMem Create()
        {
            return EF.DataPortal.Create<PM_AllotAppMem>();
        }

		public static PM_AllotAppMem Fetch(System.Linq.Expressions.Expression<Func<PM_AllotAppMem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotAppMem>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotAppMem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_AllotAppMems))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_AllotAppMems:ReadOnlyListBase<PM_AllotAppMems,PM_AllotAppMem>
    {
        #region Factory Methods

        public static PM_AllotAppMems Fetch()
        {
            return EF.DataPortal.Fetch<PM_AllotAppMems>();
        }

		public static PM_AllotAppMems Fetch(System.Linq.Expressions.Expression<Func<PM_AllotAppMem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotAppMem>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotAppMems>(lambda);
		}

		public static PM_AllotAppMems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_AllotAppMems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_AllotAppMems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_AllotAppMem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_AllotAppMems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_AllotAppMem>(exp,values)});
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
