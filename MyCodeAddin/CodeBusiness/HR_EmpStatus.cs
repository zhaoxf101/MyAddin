using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpStatus))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpStatus:ReadOnlyBase<HR_EmpStatus>
    {
        #region Business Methods

		
        public string EmpStatusCode
        {
            get ;
            set ;
        }

		
        public string EmpStatusName
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public bool IsFreeTax
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EmpStatus Create()
        {
            return EF.DataPortal.Create<HR_EmpStatus>();
        }

		public static HR_EmpStatus Fetch(System.Linq.Expressions.Expression<Func<HR_EmpStatus, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpStatus>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpStatus>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpStatuss))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpStatuss:ReadOnlyListBase<HR_EmpStatuss,HR_EmpStatus>
    {
        #region Factory Methods

        public static HR_EmpStatuss Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpStatuss>();
        }

		public static HR_EmpStatuss Fetch(System.Linq.Expressions.Expression<Func<HR_EmpStatus, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpStatus>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpStatuss>(lambda);
		}

		public static HR_EmpStatuss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpStatuss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpStatuss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpStatus, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpStatuss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpStatus>(exp,values)});
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
