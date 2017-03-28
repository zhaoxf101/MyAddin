using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpPositionBill))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpPositionBill:ReadOnlyBase<HR_EmpPositionBill>
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

		
        public string PositionCode
        {
            get ;
            set ;
        }

		
        public DateTime? StartDate
        {
            get ;
            set ;
        }

		
        public DateTime? EndDate
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

		public static HR_EmpPositionBill Create()
        {
            return EF.DataPortal.Create<HR_EmpPositionBill>();
        }

		public static HR_EmpPositionBill Fetch(System.Linq.Expressions.Expression<Func<HR_EmpPositionBill, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpPositionBill>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpPositionBill>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpPositionBills))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpPositionBills:ReadOnlyListBase<HR_EmpPositionBills,HR_EmpPositionBill>
    {
        #region Factory Methods

        public static HR_EmpPositionBills Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpPositionBills>();
        }

		public static HR_EmpPositionBills Fetch(System.Linq.Expressions.Expression<Func<HR_EmpPositionBill, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpPositionBill>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpPositionBills>(lambda);
		}

		public static HR_EmpPositionBills Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpPositionBills>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpPositionBills Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpPositionBill, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpPositionBills>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpPositionBill>(exp,values)});
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
