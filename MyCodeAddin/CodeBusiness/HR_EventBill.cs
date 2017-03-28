using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EventBill))]
#if Dev
    [RunLocal]
#endif

	public class HR_EventBill:ReadOnlyBase<HR_EventBill>
    {
        #region Business Methods

		
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

		
        public string EventCode
        {
            get ;
            set ;
        }

		
        public string BillText
        {
            get ;
            set ;
        }

		
        public string FileNo
        {
            get ;
            set ;
        }

		
        public string StartDate
        {
            get ;
            set ;
        }

		
        public string EmpCode
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public bool IsBatch
        {
            get ;
            set ;
        }

		
        public bool IsSubmit
        {
            get ;
            set ;
        }

		
        public bool Appovel
        {
            get ;
            set ;
        }

		
        public DateTime? CreateDate
        {
            get ;
            set ;
        }

		
        public string CreateUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangeDate
        {
            get ;
            set ;
        }

		
        public string ChangeUser
        {
            get ;
            set ;
        }

		
        public string CheckUser
        {
            get ;
            set ;
        }

		
        public DateTime? CheckDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EventBill Create()
        {
            return EF.DataPortal.Create<HR_EventBill>();
        }

		public static HR_EventBill Fetch(System.Linq.Expressions.Expression<Func<HR_EventBill, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EventBill>(exp,values);
            return EF.DataPortal.Fetch<HR_EventBill>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EventBills))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EventBills:ReadOnlyListBase<HR_EventBills,HR_EventBill>
    {
        #region Factory Methods

        public static HR_EventBills Fetch()
        {
            return EF.DataPortal.Fetch<HR_EventBills>();
        }

		public static HR_EventBills Fetch(System.Linq.Expressions.Expression<Func<HR_EventBill, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EventBill>(exp,values);
            return EF.DataPortal.Fetch<HR_EventBills>(lambda);
		}

		public static HR_EventBills Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EventBills>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EventBills Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EventBill, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EventBills>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EventBill>(exp,values)});
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
