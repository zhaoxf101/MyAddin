using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_BudIncBill))]
#if Dev
    [RunLocal]
#endif

	public class PM_BudIncBill:ReadOnlyBase<PM_BudIncBill>
    {
        #region Business Methods

		
        public string AppNo
        {
            get ;
            set ;
        }

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string Year
        {
            get ;
            set ;
        }

		
        public string BudBusCode
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public bool IsAppr
        {
            get ;
            set ;
        }

		
        public bool IsCheck
        {
            get ;
            set ;
        }

		
        public bool Cancelled
        {
            get ;
            set ;
        }

		
        public bool Approved
        {
            get ;
            set ;
        }

		
        public string ObjectId
        {
            get ;
            set ;
        }

		
        public string WorkflowId
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

		public static PM_BudIncBill Create()
        {
            return EF.DataPortal.Create<PM_BudIncBill>();
        }

		public static PM_BudIncBill Fetch(System.Linq.Expressions.Expression<Func<PM_BudIncBill, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_BudIncBill>(exp,values);
            return EF.DataPortal.Fetch<PM_BudIncBill>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_BudIncBills))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_BudIncBills:ReadOnlyListBase<PM_BudIncBills,PM_BudIncBill>
    {
        #region Factory Methods

        public static PM_BudIncBills Fetch()
        {
            return EF.DataPortal.Fetch<PM_BudIncBills>();
        }

		public static PM_BudIncBills Fetch(System.Linq.Expressions.Expression<Func<PM_BudIncBill, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_BudIncBill>(exp,values);
            return EF.DataPortal.Fetch<PM_BudIncBills>(lambda);
		}

		public static PM_BudIncBills Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_BudIncBills>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_BudIncBills Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_BudIncBill, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_BudIncBills>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_BudIncBill>(exp,values)});
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
