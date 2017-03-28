using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EventItem))]
#if Dev
    [RunLocal]
#endif

	public class HR_EventItem:ReadOnlyBase<HR_EventItem>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string EventItemCode
        {
            get ;
            set ;
        }

		
        public string EventItemName
        {
            get ;
            set ;
        }

		
        public string EventTypeCode
        {
            get ;
            set ;
        }

		
        public bool IsRelation
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public string WebAppModule
        {
            get ;
            set ;
        }

		
        public string WinAppModule
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EventItem Create()
        {
            return EF.DataPortal.Create<HR_EventItem>();
        }

		public static HR_EventItem Fetch(System.Linq.Expressions.Expression<Func<HR_EventItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EventItem>(exp,values);
            return EF.DataPortal.Fetch<HR_EventItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EventItems))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EventItems:ReadOnlyListBase<HR_EventItems,HR_EventItem>
    {
        #region Factory Methods

        public static HR_EventItems Fetch()
        {
            return EF.DataPortal.Fetch<HR_EventItems>();
        }

		public static HR_EventItems Fetch(System.Linq.Expressions.Expression<Func<HR_EventItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EventItem>(exp,values);
            return EF.DataPortal.Fetch<HR_EventItems>(lambda);
		}

		public static HR_EventItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EventItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EventItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EventItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EventItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EventItem>(exp,values)});
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
