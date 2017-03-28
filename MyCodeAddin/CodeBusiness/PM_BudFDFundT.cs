using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_BudFDFundT))]
#if Dev
    [RunLocal]
#endif

	public class PM_BudFDFundT:ReadOnlyBase<PM_BudFDFundT>
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

		
        public string FundCode
        {
            get ;
            set ;
        }

		
        public string AppNo
        {
            get ;
            set ;
        }

		
        public string Year
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string FundBudAreaCode
        {
            get ;
            set ;
        }

		
        public string FundFinAreaCode
        {
            get ;
            set ;
        }

		
        public string PBudExpFunCode
        {
            get ;
            set ;
        }

		
        public bool IsPBud
        {
            get ;
            set ;
        }

		
        public bool IsAdd
        {
            get ;
            set ;
        }

		
        public bool CanChg
        {
            get ;
            set ;
        }

		
        public string AccCode
        {
            get ;
            set ;
        }

		
        public int ExpSort
        {
            get ;
            set ;
        }

		
        public bool IsExpSort
        {
            get ;
            set ;
        }

		
        public bool IsBudItem
        {
            get ;
            set ;
        }

		
        public bool IsFinItem
        {
            get ;
            set ;
        }

		
        public bool IsCarryOver
        {
            get ;
            set ;
        }

		
        public bool IsCarryOverIn
        {
            get ;
            set ;
        }

		
        public bool IsCarryRedu
        {
            get ;
            set ;
        }

		
        public bool IsInCtrl
        {
            get ;
            set ;
        }

		
        public decimal MaxDeficit
        {
            get ;
            set ;
        }

		
        public bool IsFreeze
        {
            get ;
            set ;
        }

		
        public bool IsSpecial
        {
            get ;
            set ;
        }

		
        public decimal BudAmt
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

		public static PM_BudFDFundT Create()
        {
            return EF.DataPortal.Create<PM_BudFDFundT>();
        }

		public static PM_BudFDFundT Fetch(System.Linq.Expressions.Expression<Func<PM_BudFDFundT, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_BudFDFundT>(exp,values);
            return EF.DataPortal.Fetch<PM_BudFDFundT>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_BudFDFundTs))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_BudFDFundTs:ReadOnlyListBase<PM_BudFDFundTs,PM_BudFDFundT>
    {
        #region Factory Methods

        public static PM_BudFDFundTs Fetch()
        {
            return EF.DataPortal.Fetch<PM_BudFDFundTs>();
        }

		public static PM_BudFDFundTs Fetch(System.Linq.Expressions.Expression<Func<PM_BudFDFundT, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_BudFDFundT>(exp,values);
            return EF.DataPortal.Fetch<PM_BudFDFundTs>(lambda);
		}

		public static PM_BudFDFundTs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_BudFDFundTs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_BudFDFundTs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_BudFDFundT, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_BudFDFundTs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_BudFDFundT>(exp,values)});
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
