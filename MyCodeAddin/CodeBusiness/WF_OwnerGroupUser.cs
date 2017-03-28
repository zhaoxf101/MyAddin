using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(WF_OwnerGroupUser))]
#if Dev
    [RunLocal]
#endif

	public class WF_OwnerGroupUser:ReadOnlyBase<WF_OwnerGroupUser>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string WorkFlowId
        {
            get ;
            set ;
        }

		
        public string OwnerGroupId
        {
            get ;
            set ;
        }

		
        public string PositionCode
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

		public static WF_OwnerGroupUser Create()
        {
            return EF.DataPortal.Create<WF_OwnerGroupUser>();
        }

		public static WF_OwnerGroupUser Fetch(System.Linq.Expressions.Expression<Func<WF_OwnerGroupUser, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<WF_OwnerGroupUser>(exp,values);
            return EF.DataPortal.Fetch<WF_OwnerGroupUser>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(WF_OwnerGroupUsers))]
#if Dev
    [RunLocal]
#endif
	
	public class WF_OwnerGroupUsers:ReadOnlyListBase<WF_OwnerGroupUsers,WF_OwnerGroupUser>
    {
        #region Factory Methods

        public static WF_OwnerGroupUsers Fetch()
        {
            return EF.DataPortal.Fetch<WF_OwnerGroupUsers>();
        }

		public static WF_OwnerGroupUsers Fetch(System.Linq.Expressions.Expression<Func<WF_OwnerGroupUser, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<WF_OwnerGroupUser>(exp,values);
            return EF.DataPortal.Fetch<WF_OwnerGroupUsers>(lambda);
		}

		public static WF_OwnerGroupUsers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<WF_OwnerGroupUsers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static WF_OwnerGroupUsers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<WF_OwnerGroupUser, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<WF_OwnerGroupUsers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<WF_OwnerGroupUser>(exp,values)});
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
