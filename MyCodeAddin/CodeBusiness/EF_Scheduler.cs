using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_Scheduler))]
#if Dev
    [RunLocal]
#endif

	public class EF_Scheduler:ReadOnlyBase<EF_Scheduler>
    {
        #region Business Methods

		
        public Guid Id
        {
            get ;
            set ;
        }

		
        public string SchedUnit
        {
            get ;
            set ;
        }

		
        public string JobCode
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public bool RunNowX
        {
            get ;
            set ;
        }

		
        public bool RunOnceX
        {
            get ;
            set ;
        }

		
        public int RunTimes
        {
            get ;
            set ;
        }

		
        public bool TimeFreqX
        {
            get ;
            set ;
        }

		
        public string DateUnit
        {
            get ;
            set ;
        }

		
        public string TimeUnit
        {
            get ;
            set ;
        }

		
        public int Interval
        {
            get ;
            set ;
        }

		
        public int SpecDay
        {
            get ;
            set ;
        }

		
        public string StartTime
        {
            get ;
            set ;
        }

		
        public string EndTime
        {
            get ;
            set ;
        }

		
        public string RowStatus
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

		public static EF_Scheduler Create()
        {
            return EF.DataPortal.Create<EF_Scheduler>();
        }

		public static EF_Scheduler Fetch(System.Linq.Expressions.Expression<Func<EF_Scheduler, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_Scheduler>(exp,values);
            return EF.DataPortal.Fetch<EF_Scheduler>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_Schedulers))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_Schedulers:ReadOnlyListBase<EF_Schedulers,EF_Scheduler>
    {
        #region Factory Methods

        public static EF_Schedulers Fetch()
        {
            return EF.DataPortal.Fetch<EF_Schedulers>();
        }

		public static EF_Schedulers Fetch(System.Linq.Expressions.Expression<Func<EF_Scheduler, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_Scheduler>(exp,values);
            return EF.DataPortal.Fetch<EF_Schedulers>(lambda);
		}

		public static EF_Schedulers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_Schedulers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_Schedulers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_Scheduler, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_Schedulers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_Scheduler>(exp,values)});
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
