using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpBusSubsidy))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpBusSubsidy:ReadOnlyBase<FI_ExpBusSubsidy>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ExpBusCode
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string PosId
        {
            get ;
            set ;
        }

		
        public string Staff
        {
            get ;
            set ;
        }

		
        public string UType
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

		
        public string ExpItemId
        {
            get ;
            set ;
        }

		
        public string PersonName
        {
            get ;
            set ;
        }

		
        public string IdNo
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

		
        public string ResouItemName
        {
            get ;
            set ;
        }

		
        public string CostCtr
        {
            get ;
            set ;
        }

		
        public string TaxTypeCode
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

		
        public bool IsFixedTax
        {
            get ;
            set ;
        }

		
        public bool IsFreeTax
        {
            get ;
            set ;
        }

		
        public bool IsTimelyTax
        {
            get ;
            set ;
        }

		
        public bool IsCalTax
        {
            get ;
            set ;
        }

		
        public bool IsTax
        {
            get ;
            set ;
        }

		
        public bool IsIncrease
        {
            get ;
            set ;
        }

		
        public int TaxPeriod
        {
            get ;
            set ;
        }

		
        public decimal TaxRate
        {
            get ;
            set ;
        }

		
        public decimal ActTaxRate
        {
            get ;
            set ;
        }

		
        public decimal FreeTax
        {
            get ;
            set ;
        }

		
        public decimal PayablTaxAmt
        {
            get ;
            set ;
        }

		
        public decimal TaxMinIncome
        {
            get ;
            set ;
        }

		
        public decimal TaxIncome
        {
            get ;
            set ;
        }

		
        public decimal WaitTaxAmt
        {
            get ;
            set ;
        }

		
        public decimal ActTaxAmt
        {
            get ;
            set ;
        }

		
        public decimal PaidtAmt
        {
            get ;
            set ;
        }

		
        public bool IsDeferItem
        {
            get ;
            set ;
        }

		
        public decimal Payment
        {
            get ;
            set ;
        }

		
        public string BankCode
        {
            get ;
            set ;
        }

		
        public string BankName
        {
            get ;
            set ;
        }

		
        public string UnitedBankId
        {
            get ;
            set ;
        }

		
        public bool IsPublic
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_ExpBusSubsidy Create()
        {
            return EF.DataPortal.Create<FI_ExpBusSubsidy>();
        }

		public static FI_ExpBusSubsidy Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusSubsidy, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusSubsidy>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusSubsidy>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpBusSubsidys))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpBusSubsidys:ReadOnlyListBase<FI_ExpBusSubsidys,FI_ExpBusSubsidy>
    {
        #region Factory Methods

        public static FI_ExpBusSubsidys Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpBusSubsidys>();
        }

		public static FI_ExpBusSubsidys Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusSubsidy, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusSubsidy>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusSubsidys>(lambda);
		}

		public static FI_ExpBusSubsidys Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpBusSubsidys>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpBusSubsidys Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpBusSubsidy, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpBusSubsidys>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpBusSubsidy>(exp,values)});
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
