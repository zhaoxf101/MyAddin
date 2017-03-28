using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FE_UserMessageGroup))]
#if Dev
    [RunLocal]
#endif

	public class FE_UserMessageGroup:ReadOnlyBase<FE_UserMessageGroup>
    {
        #region Business Methods

		
        public string MessageID
        {
            get ;
            set ;
        }

		
        public string UserName
        {
            get ;
            set ;
        }

		
        public string GroupName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FE_UserMessageGroup Create()
        {
            return EF.DataPortal.Create<FE_UserMessageGroup>();
        }

		public static FE_UserMessageGroup Fetch(System.Linq.Expressions.Expression<Func<FE_UserMessageGroup, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FE_UserMessageGroup>(exp,values);
            return EF.DataPortal.Fetch<FE_UserMessageGroup>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FE_UserMessageGroups))]
#if Dev
    [RunLocal]
#endif
	
	public class FE_UserMessageGroups:ReadOnlyListBase<FE_UserMessageGroups,FE_UserMessageGroup>
    {
        #region Factory Methods

        public static FE_UserMessageGroups Fetch()
        {
            return EF.DataPortal.Fetch<FE_UserMessageGroups>();
        }

		public static FE_UserMessageGroups Fetch(System.Linq.Expressions.Expression<Func<FE_UserMessageGroup, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FE_UserMessageGroup>(exp,values);
            return EF.DataPortal.Fetch<FE_UserMessageGroups>(lambda);
		}

		public static FE_UserMessageGroups Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FE_UserMessageGroups>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FE_UserMessageGroups Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FE_UserMessageGroup, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FE_UserMessageGroups>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FE_UserMessageGroup>(exp,values)});
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
