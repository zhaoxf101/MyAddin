using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpOgnBill))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpOgnBill:ReadOnlyBase<HR_EmpOgnBill>
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

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string PositionCode
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

		
        public Guid? OldID
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EmpOgnBill Create()
        {
            return EF.DataPortal.Create<HR_EmpOgnBill>();
        }

		public static HR_EmpOgnBill Fetch(System.Linq.Expressions.Expression<Func<HR_EmpOgnBill, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpOgnBill>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpOgnBill>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpOgnBills))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpOgnBills:ReadOnlyListBase<HR_EmpOgnBills,HR_EmpOgnBill>
    {
        #region Factory Methods

        public static HR_EmpOgnBills Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpOgnBills>();
        }

		public static HR_EmpOgnBills Fetch(System.Linq.Expressions.Expression<Func<HR_EmpOgnBill, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpOgnBill>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpOgnBills>(lambda);
		}

		public static HR_EmpOgnBills Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpOgnBills>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpOgnBills Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpOgnBill, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpOgnBills>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpOgnBill>(exp,values)});
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
