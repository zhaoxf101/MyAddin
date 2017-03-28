using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FE_Job))]
#if Dev
    [RunLocal]
#endif

	public class FE_Job:ReadOnlyBase<FE_Job>
    {
        #region Business Methods

		
        public string JobCode
        {
            get ;
            set ;
        }

		
        public string JobName
        {
            get ;
            set ;
        }

		
        public string JobGroup
        {
            get ;
            set ;
        }

		
        public DateTime JobStartTime
        {
            get ;
            set ;
        }

		
        public string JobStatus
        {
            get ;
            set ;
        }

		
        public string JobMsg
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FE_Job Create()
        {
            return EF.DataPortal.Create<FE_Job>();
        }

		public static FE_Job Fetch(System.Linq.Expressions.Expression<Func<FE_Job, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FE_Job>(exp,values);
            return EF.DataPortal.Fetch<FE_Job>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FE_Jobs))]
#if Dev
    [RunLocal]
#endif
	
	public class FE_Jobs:ReadOnlyListBase<FE_Jobs,FE_Job>
    {
        #region Factory Methods

        public static FE_Jobs Fetch()
        {
            return EF.DataPortal.Fetch<FE_Jobs>();
        }

		public static FE_Jobs Fetch(System.Linq.Expressions.Expression<Func<FE_Job, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FE_Job>(exp,values);
            return EF.DataPortal.Fetch<FE_Jobs>(lambda);
		}

		public static FE_Jobs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FE_Jobs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FE_Jobs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FE_Job, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FE_Jobs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FE_Job>(exp,values)});
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
