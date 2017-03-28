using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpGovPayPlans))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpGovPayPlans:ReadOnlyBase<FI_ExpGovPayPlans>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ObjId
        {
            get ;
            set ;
        }

		
        public string ItemCode
        {
            get ;
            set ;
        }

		
        public string Year
        {
            get ;
            set ;
        }

		
        public string GovPlayCode
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

		
        public string PProjCode
        {
            get ;
            set ;
        }

		
        public string PayType
        {
            get ;
            set ;
        }

		
        public string BudSourceCode
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public decimal ActAmt
        {
            get ;
            set ;
        }

		
        public string FundCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_ExpGovPayPlans Create()
        {
            return EF.DataPortal.Create<FI_ExpGovPayPlans>();
        }

		public static FI_ExpGovPayPlans Fetch(System.Linq.Expressions.Expression<Func<FI_ExpGovPayPlans, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpGovPayPlans>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpGovPayPlans>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpGovPayPlanss))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpGovPayPlanss:ReadOnlyListBase<FI_ExpGovPayPlanss,FI_ExpGovPayPlans>
    {
        #region Factory Methods

        public static FI_ExpGovPayPlanss Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpGovPayPlanss>();
        }

		public static FI_ExpGovPayPlanss Fetch(System.Linq.Expressions.Expression<Func<FI_ExpGovPayPlans, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpGovPayPlans>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpGovPayPlanss>(lambda);
		}

		public static FI_ExpGovPayPlanss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpGovPayPlanss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpGovPayPlanss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpGovPayPlans, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpGovPayPlanss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpGovPayPlans>(exp,values)});
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
