using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ProjPreInBill))]
#if Dev
    [RunLocal]
#endif

	public class PM_ProjPreInBill:ReadOnlyBase<PM_ProjPreInBill>
    {
        #region Business Methods

		
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

		
        public string PreInNo
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public bool IsSubmit
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

		
        public string CheckedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CheckedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_ProjPreInBill Create()
        {
            return EF.DataPortal.Create<PM_ProjPreInBill>();
        }

		public static PM_ProjPreInBill Fetch(System.Linq.Expressions.Expression<Func<PM_ProjPreInBill, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjPreInBill>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjPreInBill>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ProjPreInBills))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ProjPreInBills:ReadOnlyListBase<PM_ProjPreInBills,PM_ProjPreInBill>
    {
        #region Factory Methods

        public static PM_ProjPreInBills Fetch()
        {
            return EF.DataPortal.Fetch<PM_ProjPreInBills>();
        }

		public static PM_ProjPreInBills Fetch(System.Linq.Expressions.Expression<Func<PM_ProjPreInBill, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjPreInBill>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjPreInBills>(lambda);
		}

		public static PM_ProjPreInBills Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ProjPreInBills>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ProjPreInBills Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ProjPreInBill, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ProjPreInBills>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ProjPreInBill>(exp,values)});
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
