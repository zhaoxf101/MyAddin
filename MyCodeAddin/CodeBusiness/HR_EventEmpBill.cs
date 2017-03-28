using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EventEmpBill))]
#if Dev
    [RunLocal]
#endif

	public class HR_EventEmpBill:ReadOnlyBase<HR_EventEmpBill>
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

		
        public string FileNo
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string GetDate
        {
            get ;
            set ;
        }

		
        public bool Appovel
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EventEmpBill Create()
        {
            return EF.DataPortal.Create<HR_EventEmpBill>();
        }

		public static HR_EventEmpBill Fetch(System.Linq.Expressions.Expression<Func<HR_EventEmpBill, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EventEmpBill>(exp,values);
            return EF.DataPortal.Fetch<HR_EventEmpBill>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EventEmpBills))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EventEmpBills:ReadOnlyListBase<HR_EventEmpBills,HR_EventEmpBill>
    {
        #region Factory Methods

        public static HR_EventEmpBills Fetch()
        {
            return EF.DataPortal.Fetch<HR_EventEmpBills>();
        }

		public static HR_EventEmpBills Fetch(System.Linq.Expressions.Expression<Func<HR_EventEmpBill, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EventEmpBill>(exp,values);
            return EF.DataPortal.Fetch<HR_EventEmpBills>(lambda);
		}

		public static HR_EventEmpBills Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EventEmpBills>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EventEmpBills Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EventEmpBill, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EventEmpBills>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EventEmpBill>(exp,values)});
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
