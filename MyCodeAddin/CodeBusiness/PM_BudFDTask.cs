using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_BudFDTask))]
#if Dev
    [RunLocal]
#endif

	public class PM_BudFDTask:ReadOnlyBase<PM_BudFDTask>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AppNo
        {
            get ;
            set ;
        }

		
        public string TaskCode
        {
            get ;
            set ;
        }

		
        public string Year
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string SBudExpFunCode
        {
            get ;
            set ;
        }

		
        public bool? IsAdd
        {
            get ;
            set ;
        }

		
        public decimal FDAmt
        {
            get ;
            set ;
        }

		
        public decimal BudAmt
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

		public static PM_BudFDTask Create()
        {
            return EF.DataPortal.Create<PM_BudFDTask>();
        }

		public static PM_BudFDTask Fetch(System.Linq.Expressions.Expression<Func<PM_BudFDTask, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_BudFDTask>(exp,values);
            return EF.DataPortal.Fetch<PM_BudFDTask>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_BudFDTasks))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_BudFDTasks:ReadOnlyListBase<PM_BudFDTasks,PM_BudFDTask>
    {
        #region Factory Methods

        public static PM_BudFDTasks Fetch()
        {
            return EF.DataPortal.Fetch<PM_BudFDTasks>();
        }

		public static PM_BudFDTasks Fetch(System.Linq.Expressions.Expression<Func<PM_BudFDTask, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_BudFDTask>(exp,values);
            return EF.DataPortal.Fetch<PM_BudFDTasks>(lambda);
		}

		public static PM_BudFDTasks Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_BudFDTasks>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_BudFDTasks Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_BudFDTask, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_BudFDTasks>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_BudFDTask>(exp,values)});
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
