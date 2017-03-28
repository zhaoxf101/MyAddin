using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_Fund_old))]
#if Dev
    [RunLocal]
#endif

	public class FI_Fund_old:ReadOnlyBase<FI_Fund_old>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string FundCode
        {
            get ;
            set ;
        }

		
        public string FundName
        {
            get ;
            set ;
        }

		
        public bool IsGroup
        {
            get ;
            set ;
        }

		
        public string FundTypeCode
        {
            get ;
            set ;
        }

		
        public string FundBudAreaCode
        {
            get ;
            set ;
        }

		
        public string ExpFundTypeCode
        {
            get ;
            set ;
        }

		
        public string FundIncTypeCode
        {
            get ;
            set ;
        }

		
        public string FundUTypeCode
        {
            get ;
            set ;
        }

		
        public string CAccCode
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

		
        public bool IsLock
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

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public string PConCode
        {
            get ;
            set ;
        }

		
        public string PProjConCode
        {
            get ;
            set ;
        }

		
        public string FundExpTypeCode
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public bool IsCarryOver
        {
            get ;
            set ;
        }

		
        public bool CanDeficit
        {
            get ;
            set ;
        }

		
        public bool IsDeficit
        {
            get ;
            set ;
        }

		
        public bool CanLoan
        {
            get ;
            set ;
        }

		
        public bool IsPirFund
        {
            get ;
            set ;
        }

		
        public string Leader
        {
            get ;
            set ;
        }

		
        public string ProjCode
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

		public static FI_Fund_old Create()
        {
            return EF.DataPortal.Create<FI_Fund_old>();
        }

		public static FI_Fund_old Fetch(System.Linq.Expressions.Expression<Func<FI_Fund_old, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_Fund_old>(exp,values);
            return EF.DataPortal.Fetch<FI_Fund_old>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_Fund_olds))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_Fund_olds:ReadOnlyListBase<FI_Fund_olds,FI_Fund_old>
    {
        #region Factory Methods

        public static FI_Fund_olds Fetch()
        {
            return EF.DataPortal.Fetch<FI_Fund_olds>();
        }

		public static FI_Fund_olds Fetch(System.Linq.Expressions.Expression<Func<FI_Fund_old, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_Fund_old>(exp,values);
            return EF.DataPortal.Fetch<FI_Fund_olds>(lambda);
		}

		public static FI_Fund_olds Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_Fund_olds>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_Fund_olds Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_Fund_old, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_Fund_olds>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_Fund_old>(exp,values)});
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
