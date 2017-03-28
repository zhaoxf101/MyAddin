using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_GovPayPlanAdjSub))]
#if Dev
    [RunLocal]
#endif

	public class FI_GovPayPlanAdjSub:ReadOnlyBase<FI_GovPayPlanAdjSub>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string BillNo
        {
            get ;
            set ;
        }

		
        public string GovPlayCode
        {
            get ;
            set ;
        }

		
        public string Year
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public string ItemText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_GovPayPlanAdjSub Create()
        {
            return EF.DataPortal.Create<FI_GovPayPlanAdjSub>();
        }

		public static FI_GovPayPlanAdjSub Fetch(System.Linq.Expressions.Expression<Func<FI_GovPayPlanAdjSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_GovPayPlanAdjSub>(exp,values);
            return EF.DataPortal.Fetch<FI_GovPayPlanAdjSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_GovPayPlanAdjSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_GovPayPlanAdjSubs:ReadOnlyListBase<FI_GovPayPlanAdjSubs,FI_GovPayPlanAdjSub>
    {
        #region Factory Methods

        public static FI_GovPayPlanAdjSubs Fetch()
        {
            return EF.DataPortal.Fetch<FI_GovPayPlanAdjSubs>();
        }

		public static FI_GovPayPlanAdjSubs Fetch(System.Linq.Expressions.Expression<Func<FI_GovPayPlanAdjSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_GovPayPlanAdjSub>(exp,values);
            return EF.DataPortal.Fetch<FI_GovPayPlanAdjSubs>(lambda);
		}

		public static FI_GovPayPlanAdjSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_GovPayPlanAdjSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_GovPayPlanAdjSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_GovPayPlanAdjSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_GovPayPlanAdjSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_GovPayPlanAdjSub>(exp,values)});
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
