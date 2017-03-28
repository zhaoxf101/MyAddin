using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(WF_InsHistory))]
#if Dev
    [RunLocal]
#endif

	public class WF_InsHistory:ReadOnlyBase<WF_InsHistory>
    {
        #region Business Methods

		
        public int iRowId
        {
            get ;
            set ;
        }

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string WorkflowId
        {
            get ;
            set ;
        }

		
        public string ItemId
        {
            get ;
            set ;
        }

		
        public string CurrentState
        {
            get ;
            set ;
        }

		
        public string FromState
        {
            get ;
            set ;
        }

		
        public string ActivityId
        {
            get ;
            set ;
        }

		
        public string Suggestion
        {
            get ;
            set ;
        }

		
        public string CheckReason
        {
            get ;
            set ;
        }

		
        public string Submitter
        {
            get ;
            set ;
        }

		
        public DateTime SubmitDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static WF_InsHistory Create()
        {
            return EF.DataPortal.Create<WF_InsHistory>();
        }

		public static WF_InsHistory Fetch(System.Linq.Expressions.Expression<Func<WF_InsHistory, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<WF_InsHistory>(exp,values);
            return EF.DataPortal.Fetch<WF_InsHistory>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(WF_InsHistorys))]
#if Dev
    [RunLocal]
#endif
	
	public class WF_InsHistorys:ReadOnlyListBase<WF_InsHistorys,WF_InsHistory>
    {
        #region Factory Methods

        public static WF_InsHistorys Fetch()
        {
            return EF.DataPortal.Fetch<WF_InsHistorys>();
        }

		public static WF_InsHistorys Fetch(System.Linq.Expressions.Expression<Func<WF_InsHistory, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<WF_InsHistory>(exp,values);
            return EF.DataPortal.Fetch<WF_InsHistorys>(lambda);
		}

		public static WF_InsHistorys Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<WF_InsHistorys>(new Paging { Page=page,RowCount=rowCount});
        }

        public static WF_InsHistorys Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<WF_InsHistory, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<WF_InsHistorys>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<WF_InsHistory>(exp,values)});
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
