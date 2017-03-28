using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpStatusBill))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpStatusBill:ReadOnlyBase<HR_EmpStatusBill>
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

		
        public string StatusCode
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

		public static HR_EmpStatusBill Create()
        {
            return EF.DataPortal.Create<HR_EmpStatusBill>();
        }

		public static HR_EmpStatusBill Fetch(System.Linq.Expressions.Expression<Func<HR_EmpStatusBill, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpStatusBill>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpStatusBill>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpStatusBills))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpStatusBills:ReadOnlyListBase<HR_EmpStatusBills,HR_EmpStatusBill>
    {
        #region Factory Methods

        public static HR_EmpStatusBills Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpStatusBills>();
        }

		public static HR_EmpStatusBills Fetch(System.Linq.Expressions.Expression<Func<HR_EmpStatusBill, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpStatusBill>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpStatusBills>(lambda);
		}

		public static HR_EmpStatusBills Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpStatusBills>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpStatusBills Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpStatusBill, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpStatusBills>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpStatusBill>(exp,values)});
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
