using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_Job))]
#if Dev
    [RunLocal]
#endif

	public class EF_Job:ReadOnlyBase<EF_Job>
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

		
        public string PgmName
        {
            get ;
            set ;
        }

		
        public string CallParams
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

		public static EF_Job Create()
        {
            return EF.DataPortal.Create<EF_Job>();
        }

		public static EF_Job Fetch(System.Linq.Expressions.Expression<Func<EF_Job, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_Job>(exp,values);
            return EF.DataPortal.Fetch<EF_Job>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_Jobs))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_Jobs:ReadOnlyListBase<EF_Jobs,EF_Job>
    {
        #region Factory Methods

        public static EF_Jobs Fetch()
        {
            return EF.DataPortal.Fetch<EF_Jobs>();
        }

		public static EF_Jobs Fetch(System.Linq.Expressions.Expression<Func<EF_Job, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_Job>(exp,values);
            return EF.DataPortal.Fetch<EF_Jobs>(lambda);
		}

		public static EF_Jobs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_Jobs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_Jobs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_Job, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_Jobs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_Job>(exp,values)});
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
