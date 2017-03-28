using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpEventSub))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpEventSub:ReadOnlyBase<HR_EmpEventSub>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string EmpEvent
        {
            get ;
            set ;
        }

		
        public string InfoType
        {
            get ;
            set ;
        }

		
        public int Sequence
        {
            get ;
            set ;
        }

		
        public bool IsValidate
        {
            get ;
            set ;
        }

		
        public bool IsDefaut
        {
            get ;
            set ;
        }

		
        public bool IsShow
        {
            get ;
            set ;
        }

		
        public string DefautPara
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EmpEventSub Create()
        {
            return EF.DataPortal.Create<HR_EmpEventSub>();
        }

		public static HR_EmpEventSub Fetch(System.Linq.Expressions.Expression<Func<HR_EmpEventSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpEventSub>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpEventSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpEventSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpEventSubs:ReadOnlyListBase<HR_EmpEventSubs,HR_EmpEventSub>
    {
        #region Factory Methods

        public static HR_EmpEventSubs Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpEventSubs>();
        }

		public static HR_EmpEventSubs Fetch(System.Linq.Expressions.Expression<Func<HR_EmpEventSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpEventSub>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpEventSubs>(lambda);
		}

		public static HR_EmpEventSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpEventSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpEventSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpEventSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpEventSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpEventSub>(exp,values)});
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
