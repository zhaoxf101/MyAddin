using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_Event))]
#if Dev
    [RunLocal]
#endif

	public class HR_Event:ReadOnlyBase<HR_Event>
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

		
        public string EventName
        {
            get ;
            set ;
        }

		
        public string EventType
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_Event Create()
        {
            return EF.DataPortal.Create<HR_Event>();
        }

		public static HR_Event Fetch(System.Linq.Expressions.Expression<Func<HR_Event, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_Event>(exp,values);
            return EF.DataPortal.Fetch<HR_Event>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_Events))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_Events:ReadOnlyListBase<HR_Events,HR_Event>
    {
        #region Factory Methods

        public static HR_Events Fetch()
        {
            return EF.DataPortal.Fetch<HR_Events>();
        }

		public static HR_Events Fetch(System.Linq.Expressions.Expression<Func<HR_Event, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_Event>(exp,values);
            return EF.DataPortal.Fetch<HR_Events>(lambda);
		}

		public static HR_Events Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_Events>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_Events Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_Event, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_Events>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_Event>(exp,values)});
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
