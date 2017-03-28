using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_StudentStatus))]
#if Dev
    [RunLocal]
#endif

	public class SM_StudentStatus:ReadOnlyBase<SM_StudentStatus>
    {
        #region Business Methods

		
        public string StudentStatusCode
        {
            get ;
            set ;
        }

		
        public string StudentStatusName
        {
            get ;
            set ;
        }

		
        public string StudentStatusTypeCode
        {
            get ;
            set ;
        }

		
        public bool bFeeYN
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

		public static SM_StudentStatus Create()
        {
            return EF.DataPortal.Create<SM_StudentStatus>();
        }

		public static SM_StudentStatus Fetch(System.Linq.Expressions.Expression<Func<SM_StudentStatus, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_StudentStatus>(exp,values);
            return EF.DataPortal.Fetch<SM_StudentStatus>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_StudentStatuss))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_StudentStatuss:ReadOnlyListBase<SM_StudentStatuss,SM_StudentStatus>
    {
        #region Factory Methods

        public static SM_StudentStatuss Fetch()
        {
            return EF.DataPortal.Fetch<SM_StudentStatuss>();
        }

		public static SM_StudentStatuss Fetch(System.Linq.Expressions.Expression<Func<SM_StudentStatus, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_StudentStatus>(exp,values);
            return EF.DataPortal.Fetch<SM_StudentStatuss>(lambda);
		}

		public static SM_StudentStatuss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_StudentStatuss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_StudentStatuss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_StudentStatus, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_StudentStatuss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_StudentStatus>(exp,values)});
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
