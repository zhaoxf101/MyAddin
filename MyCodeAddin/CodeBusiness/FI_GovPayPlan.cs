using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_GovPayPlan))]
#if Dev
    [RunLocal]
#endif

	public class FI_GovPayPlan:ReadOnlyBase<FI_GovPayPlan>
    {
        #region Business Methods

		
        public string Client
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

		
        public string Period
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

		
        public string FundCode
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

		
        public decimal PlanAmt
        {
            get ;
            set ;
        }

		
        public decimal UseAmt
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt
        {
            get ;
            set ;
        }

		
        public decimal OrderAmt
        {
            get ;
            set ;
        }

		
        public string CreateTableDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_GovPayPlan Create()
        {
            return EF.DataPortal.Create<FI_GovPayPlan>();
        }

		public static FI_GovPayPlan Fetch(System.Linq.Expressions.Expression<Func<FI_GovPayPlan, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_GovPayPlan>(exp,values);
            return EF.DataPortal.Fetch<FI_GovPayPlan>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_GovPayPlans))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_GovPayPlans:ReadOnlyListBase<FI_GovPayPlans,FI_GovPayPlan>
    {
        #region Factory Methods

        public static FI_GovPayPlans Fetch()
        {
            return EF.DataPortal.Fetch<FI_GovPayPlans>();
        }

		public static FI_GovPayPlans Fetch(System.Linq.Expressions.Expression<Func<FI_GovPayPlan, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_GovPayPlan>(exp,values);
            return EF.DataPortal.Fetch<FI_GovPayPlans>(lambda);
		}

		public static FI_GovPayPlans Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_GovPayPlans>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_GovPayPlans Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_GovPayPlan, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_GovPayPlans>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_GovPayPlan>(exp,values)});
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
