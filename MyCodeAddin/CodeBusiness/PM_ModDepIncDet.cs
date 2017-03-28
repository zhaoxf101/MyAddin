using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ModDepIncDet))]
#if Dev
    [RunLocal]
#endif

	public class PM_ModDepIncDet:ReadOnlyBase<PM_ModDepIncDet>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string IncDetCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_ModDepIncDet Create()
        {
            return EF.DataPortal.Create<PM_ModDepIncDet>();
        }

		public static PM_ModDepIncDet Fetch(System.Linq.Expressions.Expression<Func<PM_ModDepIncDet, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ModDepIncDet>(exp,values);
            return EF.DataPortal.Fetch<PM_ModDepIncDet>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ModDepIncDets))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ModDepIncDets:ReadOnlyListBase<PM_ModDepIncDets,PM_ModDepIncDet>
    {
        #region Factory Methods

        public static PM_ModDepIncDets Fetch()
        {
            return EF.DataPortal.Fetch<PM_ModDepIncDets>();
        }

		public static PM_ModDepIncDets Fetch(System.Linq.Expressions.Expression<Func<PM_ModDepIncDet, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ModDepIncDet>(exp,values);
            return EF.DataPortal.Fetch<PM_ModDepIncDets>(lambda);
		}

		public static PM_ModDepIncDets Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ModDepIncDets>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ModDepIncDets Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ModDepIncDet, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ModDepIncDets>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ModDepIncDet>(exp,values)});
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
