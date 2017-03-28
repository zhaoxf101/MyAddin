using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PerIncomeTax))]
#if Dev
    [RunLocal]
#endif

	public class FI_PerIncomeTax:ReadOnlyBase<FI_PerIncomeTax>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public long RowDeal
        {
            get ;
            set ;
        }

		
        public string AccYear
        {
            get ;
            set ;
        }

		
        public string Period
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string BusTypeCode
        {
            get ;
            set ;
        }

		
        public string BusBillCode
        {
            get ;
            set ;
        }

		
        public int RowId
        {
            get ;
            set ;
        }

		
        public string TaxTypeCode
        {
            get ;
            set ;
        }

		
        public string Description
        {
            get ;
            set ;
        }

		
        public string IncomeItem
        {
            get ;
            set ;
        }

		
        public decimal Income
        {
            get ;
            set ;
        }

		
        public decimal Payment
        {
            get ;
            set ;
        }

		
        public decimal FreeTaxIncome
        {
            get ;
            set ;
        }

		
        public decimal TaxIncome
        {
            get ;
            set ;
        }

		
        public decimal TaxRate
        {
            get ;
            set ;
        }

		
        public decimal AccruedTax
        {
            get ;
            set ;
        }

		
        public decimal WaitTaxAmt
        {
            get ;
            set ;
        }

		
        public decimal PaidTax
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

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public bool IsCalTax
        {
            get ;
            set ;
        }

		
        public bool IsPaidTax
        {
            get ;
            set ;
        }

		
        public bool IsQuery
        {
            get ;
            set ;
        }

		
        public string ResouSalaryItemCode
        {
            get ;
            set ;
        }

		
        public string ResouSalaryItemName
        {
            get ;
            set ;
        }

		
        public bool IsResouItem
        {
            get ;
            set ;
        }

		
        public bool IsIncrease
        {
            get ;
            set ;
        }

		
        public bool IsSum
        {
            get ;
            set ;
        }

		
        public string CostCtr
        {
            get ;
            set ;
        }

		
        public string UserType
        {
            get ;
            set ;
        }

		
        public string UserID
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_PerIncomeTax Create()
        {
            return EF.DataPortal.Create<FI_PerIncomeTax>();
        }

		public static FI_PerIncomeTax Fetch(System.Linq.Expressions.Expression<Func<FI_PerIncomeTax, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PerIncomeTax>(exp,values);
            return EF.DataPortal.Fetch<FI_PerIncomeTax>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PerIncomeTaxs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PerIncomeTaxs:ReadOnlyListBase<FI_PerIncomeTaxs,FI_PerIncomeTax>
    {
        #region Factory Methods

        public static FI_PerIncomeTaxs Fetch()
        {
            return EF.DataPortal.Fetch<FI_PerIncomeTaxs>();
        }

		public static FI_PerIncomeTaxs Fetch(System.Linq.Expressions.Expression<Func<FI_PerIncomeTax, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PerIncomeTax>(exp,values);
            return EF.DataPortal.Fetch<FI_PerIncomeTaxs>(lambda);
		}

		public static FI_PerIncomeTaxs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PerIncomeTaxs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PerIncomeTaxs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PerIncomeTax, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PerIncomeTaxs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PerIncomeTax>(exp,values)});
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
