using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_GovPayPlanImport))]
#if Dev
    [RunLocal]
#endif

	public class FI_GovPayPlanImport:ReadOnlyBase<FI_GovPayPlanImport>
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

		
        public string ItemText
        {
            get ;
            set ;
        }

		
        public string CreateTableDate
        {
            get ;
            set ;
        }

		
        public bool IsConf
        {
            get ;
            set ;
        }

		
        public string BillNo
        {
            get ;
            set ;
        }

		
        public string IncDetCode
        {
            get ;
            set ;
        }

		
        public string ProfitCtr
        {
            get ;
            set ;
        }

		
        public string AuthAccCode
        {
            get ;
            set ;
        }

		
        public string ImportUser
        {
            get ;
            set ;
        }

		
        public DateTime? ImportDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_GovPayPlanImport Create()
        {
            return EF.DataPortal.Create<FI_GovPayPlanImport>();
        }

		public static FI_GovPayPlanImport Fetch(System.Linq.Expressions.Expression<Func<FI_GovPayPlanImport, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_GovPayPlanImport>(exp,values);
            return EF.DataPortal.Fetch<FI_GovPayPlanImport>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_GovPayPlanImports))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_GovPayPlanImports:ReadOnlyListBase<FI_GovPayPlanImports,FI_GovPayPlanImport>
    {
        #region Factory Methods

        public static FI_GovPayPlanImports Fetch()
        {
            return EF.DataPortal.Fetch<FI_GovPayPlanImports>();
        }

		public static FI_GovPayPlanImports Fetch(System.Linq.Expressions.Expression<Func<FI_GovPayPlanImport, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_GovPayPlanImport>(exp,values);
            return EF.DataPortal.Fetch<FI_GovPayPlanImports>(lambda);
		}

		public static FI_GovPayPlanImports Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_GovPayPlanImports>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_GovPayPlanImports Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_GovPayPlanImport, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_GovPayPlanImports>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_GovPayPlanImport>(exp,values)});
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
