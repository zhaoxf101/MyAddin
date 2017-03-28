using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_VoucherSub))]
#if Dev
    [RunLocal]
#endif

	public class PM_VoucherSub:ReadOnlyBase<PM_VoucherSub>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string VouchNo
        {
            get ;
            set ;
        }

		
        public string AccYear
        {
            get ;
            set ;
        }

		
        public string LineNR
        {
            get ;
            set ;
        }

		
        public string ItemText
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public string PostBus
        {
            get ;
            set ;
        }

		
        public string PostMark
        {
            get ;
            set ;
        }

		
        public string FundCode
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string TaskCode
        {
            get ;
            set ;
        }

		
        public string PBudExpEcoCode
        {
            get ;
            set ;
        }

		
        public string PBudExpFunCode
        {
            get ;
            set ;
        }

		
        public string PBudExpItemCode
        {
            get ;
            set ;
        }

		
        public string FundExpTypeCode
        {
            get ;
            set ;
        }

		
        public string ExpItemRow
        {
            get ;
            set ;
        }

		
        public string ExpItemCode
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

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string CostCtr
        {
            get ;
            set ;
        }

		
        public string ContractId
        {
            get ;
            set ;
        }

		
        public string RefLine
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_VoucherSub Create()
        {
            return EF.DataPortal.Create<PM_VoucherSub>();
        }

		public static PM_VoucherSub Fetch(System.Linq.Expressions.Expression<Func<PM_VoucherSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_VoucherSub>(exp,values);
            return EF.DataPortal.Fetch<PM_VoucherSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_VoucherSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_VoucherSubs:ReadOnlyListBase<PM_VoucherSubs,PM_VoucherSub>
    {
        #region Factory Methods

        public static PM_VoucherSubs Fetch()
        {
            return EF.DataPortal.Fetch<PM_VoucherSubs>();
        }

		public static PM_VoucherSubs Fetch(System.Linq.Expressions.Expression<Func<PM_VoucherSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_VoucherSub>(exp,values);
            return EF.DataPortal.Fetch<PM_VoucherSubs>(lambda);
		}

		public static PM_VoucherSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_VoucherSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_VoucherSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_VoucherSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_VoucherSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_VoucherSub>(exp,values)});
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
