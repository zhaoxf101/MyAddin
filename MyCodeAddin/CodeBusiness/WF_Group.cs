using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(WF_Group))]
#if Dev
    [RunLocal]
#endif

	public class WF_Group:ReadOnlyBase<WF_Group>
    {
        #region Business Methods

		
        public string WorkflowGroup
        {
            get ;
            set ;
        }

		
        public string WorkflowGroupName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static WF_Group Create()
        {
            return EF.DataPortal.Create<WF_Group>();
        }

		public static WF_Group Fetch(System.Linq.Expressions.Expression<Func<WF_Group, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<WF_Group>(exp,values);
            return EF.DataPortal.Fetch<WF_Group>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(WF_Groups))]
#if Dev
    [RunLocal]
#endif
	
	public class WF_Groups:ReadOnlyListBase<WF_Groups,WF_Group>
    {
        #region Factory Methods

        public static WF_Groups Fetch()
        {
            return EF.DataPortal.Fetch<WF_Groups>();
        }

		public static WF_Groups Fetch(System.Linq.Expressions.Expression<Func<WF_Group, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<WF_Group>(exp,values);
            return EF.DataPortal.Fetch<WF_Groups>(lambda);
		}

		public static WF_Groups Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<WF_Groups>(new Paging { Page=page,RowCount=rowCount});
        }

        public static WF_Groups Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<WF_Group, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<WF_Groups>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<WF_Group>(exp,values)});
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
