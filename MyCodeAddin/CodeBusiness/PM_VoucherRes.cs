using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_VoucherRes))]
#if Dev
    [RunLocal]
#endif

	public class PM_VoucherRes:ReadOnlyBase<PM_VoucherRes>
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

		
        public decimal Qty
        {
            get ;
            set ;
        }

		
        public decimal Amt
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

		
        public string ResouItemCode
        {
            get ;
            set ;
        }

		
        public string CostCtr
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_VoucherRes Create()
        {
            return EF.DataPortal.Create<PM_VoucherRes>();
        }

		public static PM_VoucherRes Fetch(System.Linq.Expressions.Expression<Func<PM_VoucherRes, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_VoucherRes>(exp,values);
            return EF.DataPortal.Fetch<PM_VoucherRes>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_VoucherRess))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_VoucherRess:ReadOnlyListBase<PM_VoucherRess,PM_VoucherRes>
    {
        #region Factory Methods

        public static PM_VoucherRess Fetch()
        {
            return EF.DataPortal.Fetch<PM_VoucherRess>();
        }

		public static PM_VoucherRess Fetch(System.Linq.Expressions.Expression<Func<PM_VoucherRes, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_VoucherRes>(exp,values);
            return EF.DataPortal.Fetch<PM_VoucherRess>(lambda);
		}

		public static PM_VoucherRess Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_VoucherRess>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_VoucherRess Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_VoucherRes, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_VoucherRess>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_VoucherRes>(exp,values)});
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
