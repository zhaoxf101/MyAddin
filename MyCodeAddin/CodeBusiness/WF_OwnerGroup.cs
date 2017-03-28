using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(WF_OwnerGroup))]
#if Dev
    [RunLocal]
#endif

	public class WF_OwnerGroup:ReadOnlyBase<WF_OwnerGroup>
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

		
        public string OwnerGroupId
        {
            get ;
            set ;
        }

		
        public string OwnerGroupName
        {
            get ;
            set ;
        }

		
        public string Description
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

		public static WF_OwnerGroup Create()
        {
            return EF.DataPortal.Create<WF_OwnerGroup>();
        }

		public static WF_OwnerGroup Fetch(System.Linq.Expressions.Expression<Func<WF_OwnerGroup, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<WF_OwnerGroup>(exp,values);
            return EF.DataPortal.Fetch<WF_OwnerGroup>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(WF_OwnerGroups))]
#if Dev
    [RunLocal]
#endif
	
	public class WF_OwnerGroups:ReadOnlyListBase<WF_OwnerGroups,WF_OwnerGroup>
    {
        #region Factory Methods

        public static WF_OwnerGroups Fetch()
        {
            return EF.DataPortal.Fetch<WF_OwnerGroups>();
        }

		public static WF_OwnerGroups Fetch(System.Linq.Expressions.Expression<Func<WF_OwnerGroup, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<WF_OwnerGroup>(exp,values);
            return EF.DataPortal.Fetch<WF_OwnerGroups>(lambda);
		}

		public static WF_OwnerGroups Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<WF_OwnerGroups>(new Paging { Page=page,RowCount=rowCount});
        }

        public static WF_OwnerGroups Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<WF_OwnerGroup, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<WF_OwnerGroups>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<WF_OwnerGroup>(exp,values)});
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
