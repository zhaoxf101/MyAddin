using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(WF_State))]
#if Dev
    [RunLocal]
#endif

	public class WF_State:ReadOnlyBase<WF_State>
    {
        #region Business Methods

		
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

		
        public string StateId
        {
            get ;
            set ;
        }

		
        public string StateName
        {
            get ;
            set ;
        }

		
        public string CheckName
        {
            get ;
            set ;
        }

		
        public string Description
        {
            get ;
            set ;
        }

		
        public string OwnerGroupId
        {
            get ;
            set ;
        }

		
        public bool IsOwnerSubmitter
        {
            get ;
            set ;
        }

		
        public bool IsRule
        {
            get ;
            set ;
        }

		
        public bool IsSpecActivity
        {
            get ;
            set ;
        }

		
        public string StateObjectName
        {
            get ;
            set ;
        }

		
        public string WinformName
        {
            get ;
            set ;
        }

		
        public string WebformName
        {
            get ;
            set ;
        }

		
        public System.Data.Linq.Binary TimeStamp
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

		public static WF_State Create()
        {
            return EF.DataPortal.Create<WF_State>();
        }

		public static WF_State Fetch(System.Linq.Expressions.Expression<Func<WF_State, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<WF_State>(exp,values);
            return EF.DataPortal.Fetch<WF_State>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(WF_States))]
#if Dev
    [RunLocal]
#endif
	
	public class WF_States:ReadOnlyListBase<WF_States,WF_State>
    {
        #region Factory Methods

        public static WF_States Fetch()
        {
            return EF.DataPortal.Fetch<WF_States>();
        }

		public static WF_States Fetch(System.Linq.Expressions.Expression<Func<WF_State, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<WF_State>(exp,values);
            return EF.DataPortal.Fetch<WF_States>(lambda);
		}

		public static WF_States Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<WF_States>(new Paging { Page=page,RowCount=rowCount});
        }

        public static WF_States Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<WF_State, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<WF_States>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<WF_State>(exp,values)});
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
