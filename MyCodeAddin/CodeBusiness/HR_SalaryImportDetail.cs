using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_SalaryImportDetail))]
#if Dev
    [RunLocal]
#endif

	public class HR_SalaryImportDetail:ReadOnlyBase<HR_SalaryImportDetail>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string SalaryCode
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string SalaryItemCode
        {
            get ;
            set ;
        }

		
        public string SalaryItemName
        {
            get ;
            set ;
        }

		
        public decimal SalaryAmt
        {
            get ;
            set ;
        }

		
        public string ResouItemCode
        {
            get ;
            set ;
        }

		
        public string TaxTypeCode
        {
            get ;
            set ;
        }

		
        public bool IsIncrease
        {
            get ;
            set ;
        }

		
        public bool IsFixed
        {
            get ;
            set ;
        }

		
        public bool IsFreeTax
        {
            get ;
            set ;
        }

		
        public int Sort
        {
            get ;
            set ;
        }

		
        public bool IsFixedTaxRate
        {
            get ;
            set ;
        }

		
        public decimal? TaxRate
        {
            get ;
            set ;
        }

		
        public decimal TaxMinIncome
        {
            get ;
            set ;
        }

		
        public int TaxPeriod
        {
            get ;
            set ;
        }

		
        public string CostCtr
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

		
        public string Description
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_SalaryImportDetail Create()
        {
            return EF.DataPortal.Create<HR_SalaryImportDetail>();
        }

		public static HR_SalaryImportDetail Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryImportDetail, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryImportDetail>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryImportDetail>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_SalaryImportDetails))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_SalaryImportDetails:ReadOnlyListBase<HR_SalaryImportDetails,HR_SalaryImportDetail>
    {
        #region Factory Methods

        public static HR_SalaryImportDetails Fetch()
        {
            return EF.DataPortal.Fetch<HR_SalaryImportDetails>();
        }

		public static HR_SalaryImportDetails Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryImportDetail, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryImportDetail>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryImportDetails>(lambda);
		}

		public static HR_SalaryImportDetails Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_SalaryImportDetails>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_SalaryImportDetails Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_SalaryImportDetail, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_SalaryImportDetails>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_SalaryImportDetail>(exp,values)});
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
