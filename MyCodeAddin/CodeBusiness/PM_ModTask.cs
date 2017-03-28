using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ModTask))]
#if Dev
    [RunLocal]
#endif

	public class PM_ModTask:ReadOnlyBase<PM_ModTask>
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

		
        public string SBudExpFunCode
        {
            get ;
            set ;
        }

		
        public bool Active
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

		
        public bool IsEscrow
        {
            get ;
            set ;
        }

		
        public bool IsBudItem
        {
            get ;
            set ;
        }

		
        public bool IsFinItem
        {
            get ;
            set ;
        }

		
        public string BTaskCode
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

		
        public decimal FDAmt
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

		public static PM_ModTask Create()
        {
            return EF.DataPortal.Create<PM_ModTask>();
        }

		public static PM_ModTask Fetch(System.Linq.Expressions.Expression<Func<PM_ModTask, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ModTask>(exp,values);
            return EF.DataPortal.Fetch<PM_ModTask>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ModTasks))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ModTasks:ReadOnlyListBase<PM_ModTasks,PM_ModTask>
    {
        #region Factory Methods

        public static PM_ModTasks Fetch()
        {
            return EF.DataPortal.Fetch<PM_ModTasks>();
        }

		public static PM_ModTasks Fetch(System.Linq.Expressions.Expression<Func<PM_ModTask, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ModTask>(exp,values);
            return EF.DataPortal.Fetch<PM_ModTasks>(lambda);
		}

		public static PM_ModTasks Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ModTasks>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ModTasks Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ModTask, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ModTasks>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ModTask>(exp,values)});
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
