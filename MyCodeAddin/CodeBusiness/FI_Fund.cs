using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_Fund))]
#if Dev
    [RunLocal]
#endif

	public class FI_Fund:ReadOnlyBase<FI_Fund>
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

		
        public string FundAccTypeCode
        {
            get ;
            set ;
        }

		
        public string FundTypeCode
        {
            get ;
            set ;
        }

		
        public string FundExpTypeCode
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

		
        public string CtrlAccCode
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

		
        public string FAccCode
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

		
        public bool IsPublic
        {
            get ;
            set ;
        }

		
        public bool IsLock
        {
            get ;
            set ;
        }

		
        public bool IsLedCarry
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

		
        public bool IsCtrlAcc
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public bool Active
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

		
        public bool IsCarryOver
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

		
        public bool IsRD
        {
            get ;
            set ;
        }

		
        public bool IsEscrow
        {
            get ;
            set ;
        }

		
        public bool IsInCtrl
        {
            get ;
            set ;
        }

		
        public bool IsChkIn
        {
            get ;
            set ;
        }

		
        public bool IsInterIn
        {
            get ;
            set ;
        }

		
        public string LStaff
        {
            get ;
            set ;
        }

		
        public string LPositionCode
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

		public static FI_Fund Create()
        {
            return EF.DataPortal.Create<FI_Fund>();
        }

		public static FI_Fund Fetch(System.Linq.Expressions.Expression<Func<FI_Fund, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_Fund>(exp,values);
            return EF.DataPortal.Fetch<FI_Fund>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_Funds))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_Funds:ReadOnlyListBase<FI_Funds,FI_Fund>
    {
        #region Factory Methods

        public static FI_Funds Fetch()
        {
            return EF.DataPortal.Fetch<FI_Funds>();
        }

		public static FI_Funds Fetch(System.Linq.Expressions.Expression<Func<FI_Fund, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_Fund>(exp,values);
            return EF.DataPortal.Fetch<FI_Funds>(lambda);
		}

		public static FI_Funds Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_Funds>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_Funds Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_Fund, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_Funds>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_Fund>(exp,values)});
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
