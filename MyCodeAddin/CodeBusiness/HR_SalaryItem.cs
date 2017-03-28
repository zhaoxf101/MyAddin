using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_SalaryItem))]
#if Dev
    [RunLocal]
#endif

	public class HR_SalaryItem:ReadOnlyBase<HR_SalaryItem>
    {
        #region Business Methods

		
        public string Client
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

		
        public string ResouItemCode
        {
            get ;
            set ;
        }

		
        public bool IsIncrease
        {
            get ;
            set ;
        }

		
        public string TaxTypeCode
        {
            get ;
            set ;
        }

		
        public string AccType
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

		
        public bool IsTax
        {
            get ;
            set ;
        }

		
        public bool IsSalaryItem
        {
            get ;
            set ;
        }

		
        public bool IsWithhold
        {
            get ;
            set ;
        }

		
        public bool IsUseAccCode
        {
            get ;
            set ;
        }

		
        public int Sort
        {
            get ;
            set ;
        }

		
        public string SumGroup
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_SalaryItem Create()
        {
            return EF.DataPortal.Create<HR_SalaryItem>();
        }

		public static HR_SalaryItem Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryItem>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_SalaryItems))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_SalaryItems:ReadOnlyListBase<HR_SalaryItems,HR_SalaryItem>
    {
        #region Factory Methods

        public static HR_SalaryItems Fetch()
        {
            return EF.DataPortal.Fetch<HR_SalaryItems>();
        }

		public static HR_SalaryItems Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryItem>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryItems>(lambda);
		}

		public static HR_SalaryItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_SalaryItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_SalaryItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_SalaryItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_SalaryItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_SalaryItem>(exp,values)});
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
