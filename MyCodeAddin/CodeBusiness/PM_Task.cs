using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_Task))]
#if Dev
    [RunLocal]
#endif

	public class PM_Task:ReadOnlyBase<PM_Task>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string TaskCode
        {
            get ;
            set ;
        }

		
        public string TaskName
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public bool IsAdd
        {
            get ;
            set ;
        }

		
        public bool IsCWCHK
        {
            get ;
            set ;
        }

		
        public string LPersonId
        {
            get ;
            set ;
        }

		
        public string DeptCode
        {
            get ;
            set ;
        }

		
        public decimal? Timelimit
        {
            get ;
            set ;
        }

		
        public string TimeUnit
        {
            get ;
            set ;
        }

		
        public DateTime? StartTime
        {
            get ;
            set ;
        }

		
        public DateTime? EndTime
        {
            get ;
            set ;
        }

		
        public decimal FDAmt
        {
            get ;
            set ;
        }

		
        public string SBudExpFunCode
        {
            get ;
            set ;
        }

		
        public string ExpAcctCode1
        {
            get ;
            set ;
        }

		
        public string ExpAcctCode2
        {
            get ;
            set ;
        }

		
        public string BTaskCode
        {
            get ;
            set ;
        }

		
        public bool IsEscrow
        {
            get ;
            set ;
        }

		
        public bool IsBudCtrl
        {
            get ;
            set ;
        }

		
        public bool IsSpecial
        {
            get ;
            set ;
        }

		
        public decimal MaxDeficit
        {
            get ;
            set ;
        }

		
        public string ParentId
        {
            get ;
            set ;
        }

		
        public bool IsGroup
        {
            get ;
            set ;
        }

		
        public int? SortOrder
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

		public static PM_Task Create()
        {
            return EF.DataPortal.Create<PM_Task>();
        }

		public static PM_Task Fetch(System.Linq.Expressions.Expression<Func<PM_Task, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_Task>(exp,values);
            return EF.DataPortal.Fetch<PM_Task>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_Tasks))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_Tasks:ReadOnlyListBase<PM_Tasks,PM_Task>
    {
        #region Factory Methods

        public static PM_Tasks Fetch()
        {
            return EF.DataPortal.Fetch<PM_Tasks>();
        }

		public static PM_Tasks Fetch(System.Linq.Expressions.Expression<Func<PM_Task, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_Task>(exp,values);
            return EF.DataPortal.Fetch<PM_Tasks>(lambda);
		}

		public static PM_Tasks Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_Tasks>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_Tasks Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_Task, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_Tasks>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_Task>(exp,values)});
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
