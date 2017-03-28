using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_BudIncProj))]
#if Dev
    [RunLocal]
#endif

	public class PM_BudIncProj:ReadOnlyBase<PM_BudIncProj>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AppNo
        {
            get ;
            set ;
        }

		
        public string IncDetCode
        {
            get ;
            set ;
        }

		
        public string Year
        {
            get ;
            set ;
        }

		
        public string SIncItemCode
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

		
        public string FundBudAreaCode
        {
            get ;
            set ;
        }

		
        public decimal HisAmt
        {
            get ;
            set ;
        }

		
        public decimal CurAmt
        {
            get ;
            set ;
        }

		
        public bool IsN
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

		
        public string CheckedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CheckedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_BudIncProj Create()
        {
            return EF.DataPortal.Create<PM_BudIncProj>();
        }

		public static PM_BudIncProj Fetch(System.Linq.Expressions.Expression<Func<PM_BudIncProj, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_BudIncProj>(exp,values);
            return EF.DataPortal.Fetch<PM_BudIncProj>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_BudIncProjs))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_BudIncProjs:ReadOnlyListBase<PM_BudIncProjs,PM_BudIncProj>
    {
        #region Factory Methods

        public static PM_BudIncProjs Fetch()
        {
            return EF.DataPortal.Fetch<PM_BudIncProjs>();
        }

		public static PM_BudIncProjs Fetch(System.Linq.Expressions.Expression<Func<PM_BudIncProj, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_BudIncProj>(exp,values);
            return EF.DataPortal.Fetch<PM_BudIncProjs>(lambda);
		}

		public static PM_BudIncProjs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_BudIncProjs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_BudIncProjs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_BudIncProj, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_BudIncProjs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_BudIncProj>(exp,values)});
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
