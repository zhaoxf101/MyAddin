using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpSalaryBill))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpSalaryBill:ReadOnlyBase<HR_EmpSalaryBill>
    {
        #region Business Methods

		
        public Guid ID
        {
            get ;
            set ;
        }

		
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

		
        public string EmpCode
        {
            get ;
            set ;
        }

		
        public bool IsSalary
        {
            get ;
            set ;
        }

		
        public bool IsInsReturn
        {
            get ;
            set ;
        }

		
        public bool IsSalReturn
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

		
        public Guid? OldId
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EmpSalaryBill Create()
        {
            return EF.DataPortal.Create<HR_EmpSalaryBill>();
        }

		public static HR_EmpSalaryBill Fetch(System.Linq.Expressions.Expression<Func<HR_EmpSalaryBill, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpSalaryBill>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpSalaryBill>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpSalaryBills))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpSalaryBills:ReadOnlyListBase<HR_EmpSalaryBills,HR_EmpSalaryBill>
    {
        #region Factory Methods

        public static HR_EmpSalaryBills Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpSalaryBills>();
        }

		public static HR_EmpSalaryBills Fetch(System.Linq.Expressions.Expression<Func<HR_EmpSalaryBill, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpSalaryBill>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpSalaryBills>(lambda);
		}

		public static HR_EmpSalaryBills Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpSalaryBills>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpSalaryBills Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpSalaryBill, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpSalaryBills>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpSalaryBill>(exp,values)});
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
