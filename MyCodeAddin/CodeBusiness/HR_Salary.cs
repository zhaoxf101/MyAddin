using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_Salary))]
#if Dev
    [RunLocal]
#endif

	public class HR_Salary:ReadOnlyBase<HR_Salary>
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

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string CostCtr
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

		
        public string ExpItemCode
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

		public static HR_Salary Create()
        {
            return EF.DataPortal.Create<HR_Salary>();
        }

		public static HR_Salary Fetch(System.Linq.Expressions.Expression<Func<HR_Salary, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_Salary>(exp,values);
            return EF.DataPortal.Fetch<HR_Salary>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_Salarys))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_Salarys:ReadOnlyListBase<HR_Salarys,HR_Salary>
    {
        #region Factory Methods

        public static HR_Salarys Fetch()
        {
            return EF.DataPortal.Fetch<HR_Salarys>();
        }

		public static HR_Salarys Fetch(System.Linq.Expressions.Expression<Func<HR_Salary, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_Salary>(exp,values);
            return EF.DataPortal.Fetch<HR_Salarys>(lambda);
		}

		public static HR_Salarys Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_Salarys>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_Salarys Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_Salary, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_Salarys>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_Salary>(exp,values)});
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
