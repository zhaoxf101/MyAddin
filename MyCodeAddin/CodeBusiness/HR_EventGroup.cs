using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EventGroup))]
#if Dev
    [RunLocal]
#endif

	public class HR_EventGroup:ReadOnlyBase<HR_EventGroup>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string EventCode
        {
            get ;
            set ;
        }

		
        public string RelationGroup
        {
            get ;
            set ;
        }

		
        public int Sort
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EventGroup Create()
        {
            return EF.DataPortal.Create<HR_EventGroup>();
        }

		public static HR_EventGroup Fetch(System.Linq.Expressions.Expression<Func<HR_EventGroup, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EventGroup>(exp,values);
            return EF.DataPortal.Fetch<HR_EventGroup>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EventGroups))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EventGroups:ReadOnlyListBase<HR_EventGroups,HR_EventGroup>
    {
        #region Factory Methods

        public static HR_EventGroups Fetch()
        {
            return EF.DataPortal.Fetch<HR_EventGroups>();
        }

		public static HR_EventGroups Fetch(System.Linq.Expressions.Expression<Func<HR_EventGroup, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EventGroup>(exp,values);
            return EF.DataPortal.Fetch<HR_EventGroups>(lambda);
		}

		public static HR_EventGroups Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EventGroups>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EventGroups Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EventGroup, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EventGroups>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EventGroup>(exp,values)});
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
