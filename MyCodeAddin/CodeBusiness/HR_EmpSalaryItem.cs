using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpSalaryItem))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpSalaryItem:ReadOnlyBase<HR_EmpSalaryItem>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public Guid Id
        {
            get ;
            set ;
        }

		
        public string SalaryRange
        {
            get ;
            set ;
        }

		
        public string EmpCode
        {
            get ;
            set ;
        }

		
        public string StartDate
        {
            get ;
            set ;
        }

		
        public string EndDate
        {
            get ;
            set ;
        }

		
        public string SalaryItemCode
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public string RowStatus
        {
            get ;
            set ;
        }

		
        public string CreatedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public string ChangedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EmpSalaryItem Create()
        {
            return EF.DataPortal.Create<HR_EmpSalaryItem>();
        }

		public static HR_EmpSalaryItem Fetch(System.Linq.Expressions.Expression<Func<HR_EmpSalaryItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpSalaryItem>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpSalaryItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpSalaryItems))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpSalaryItems:ReadOnlyListBase<HR_EmpSalaryItems,HR_EmpSalaryItem>
    {
        #region Factory Methods

        public static HR_EmpSalaryItems Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpSalaryItems>();
        }

		public static HR_EmpSalaryItems Fetch(System.Linq.Expressions.Expression<Func<HR_EmpSalaryItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpSalaryItem>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpSalaryItems>(lambda);
		}

		public static HR_EmpSalaryItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpSalaryItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpSalaryItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpSalaryItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpSalaryItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpSalaryItem>(exp,values)});
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
