using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CO_VoucherSub))]
#if Dev
    [RunLocal]
#endif

	public class CO_VoucherSub:ReadOnlyBase<CO_VoucherSub>
    {
        #region Business Methods

		
        public string CostArea
        {
            get ;
            set ;
        }

		
        public string AccYear
        {
            get ;
            set ;
        }

		
        public string VouchNo
        {
            get ;
            set ;
        }

		
        public string LineNR
        {
            get ;
            set ;
        }

		
        public string AccPid
        {
            get ;
            set ;
        }

		
        public string ItemText
        {
            get ;
            set ;
        }

		
        public bool DeCrX
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public string CostElem
        {
            get ;
            set ;
        }

		
        public bool PCAElemX
        {
            get ;
            set ;
        }

		
        public string CostCtr
        {
            get ;
            set ;
        }

		
        public string ExpItemCode
        {
            get ;
            set ;
        }

		
        public string ProfitCtr
        {
            get ;
            set ;
        }

		
        public string IncDetCode
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

		public static CO_VoucherSub Create()
        {
            return EF.DataPortal.Create<CO_VoucherSub>();
        }

		public static CO_VoucherSub Fetch(System.Linq.Expressions.Expression<Func<CO_VoucherSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CO_VoucherSub>(exp,values);
            return EF.DataPortal.Fetch<CO_VoucherSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CO_VoucherSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class CO_VoucherSubs:ReadOnlyListBase<CO_VoucherSubs,CO_VoucherSub>
    {
        #region Factory Methods

        public static CO_VoucherSubs Fetch()
        {
            return EF.DataPortal.Fetch<CO_VoucherSubs>();
        }

		public static CO_VoucherSubs Fetch(System.Linq.Expressions.Expression<Func<CO_VoucherSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CO_VoucherSub>(exp,values);
            return EF.DataPortal.Fetch<CO_VoucherSubs>(lambda);
		}

		public static CO_VoucherSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CO_VoucherSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CO_VoucherSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CO_VoucherSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CO_VoucherSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CO_VoucherSub>(exp,values)});
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
