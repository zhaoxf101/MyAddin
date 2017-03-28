using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_Job))]
#if Dev
    [RunLocal]
#endif

	public class HR_Job:ReadOnlyBase<HR_Job>
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

		
        public string JobTypeCode
        {
            get ;
            set ;
        }

		
        public string JobLevelCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_Job Create()
        {
            return EF.DataPortal.Create<HR_Job>();
        }

		public static HR_Job Fetch(System.Linq.Expressions.Expression<Func<HR_Job, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_Job>(exp,values);
            return EF.DataPortal.Fetch<HR_Job>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_Jobs))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_Jobs:ReadOnlyListBase<HR_Jobs,HR_Job>
    {
        #region Factory Methods

        public static HR_Jobs Fetch()
        {
            return EF.DataPortal.Fetch<HR_Jobs>();
        }

		public static HR_Jobs Fetch(System.Linq.Expressions.Expression<Func<HR_Job, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_Job>(exp,values);
            return EF.DataPortal.Fetch<HR_Jobs>(lambda);
		}

		public static HR_Jobs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_Jobs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_Jobs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_Job, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_Jobs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_Job>(exp,values)});
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
