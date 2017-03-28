using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(WF_Instance))]
#if Dev
    [RunLocal]
#endif

	public class WF_Instance:ReadOnlyBase<WF_Instance>
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

		
        public string ItemId
        {
            get ;
            set ;
        }

		
        public string BarCode
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

		
        public DateTime? SubmitDate
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

		public static WF_Instance Create()
        {
            return EF.DataPortal.Create<WF_Instance>();
        }

		public static WF_Instance Fetch(System.Linq.Expressions.Expression<Func<WF_Instance, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<WF_Instance>(exp,values);
            return EF.DataPortal.Fetch<WF_Instance>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(WF_Instances))]
#if Dev
    [RunLocal]
#endif
	
	public class WF_Instances:ReadOnlyListBase<WF_Instances,WF_Instance>
    {
        #region Factory Methods

        public static WF_Instances Fetch()
        {
            return EF.DataPortal.Fetch<WF_Instances>();
        }

		public static WF_Instances Fetch(System.Linq.Expressions.Expression<Func<WF_Instance, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<WF_Instance>(exp,values);
            return EF.DataPortal.Fetch<WF_Instances>(lambda);
		}

		public static WF_Instances Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<WF_Instances>(new Paging { Page=page,RowCount=rowCount});
        }

        public static WF_Instances Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<WF_Instance, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<WF_Instances>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<WF_Instance>(exp,values)});
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
