using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_StuStatus))]
#if Dev
    [RunLocal]
#endif

	public class SM_StuStatus:ReadOnlyBase<SM_StuStatus>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string StudentNo
        {
            get ;
            set ;
        }

		
        public string SDate
        {
            get ;
            set ;
        }

		
        public string EDate
        {
            get ;
            set ;
        }

		
        public string StudentStatusCode
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

		public static SM_StuStatus Create()
        {
            return EF.DataPortal.Create<SM_StuStatus>();
        }

		public static SM_StuStatus Fetch(System.Linq.Expressions.Expression<Func<SM_StuStatus, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_StuStatus>(exp,values);
            return EF.DataPortal.Fetch<SM_StuStatus>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_StuStatuss))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_StuStatuss:ReadOnlyListBase<SM_StuStatuss,SM_StuStatus>
    {
        #region Factory Methods

        public static SM_StuStatuss Fetch()
        {
            return EF.DataPortal.Fetch<SM_StuStatuss>();
        }

		public static SM_StuStatuss Fetch(System.Linq.Expressions.Expression<Func<SM_StuStatus, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_StuStatus>(exp,values);
            return EF.DataPortal.Fetch<SM_StuStatuss>(lambda);
		}

		public static SM_StuStatuss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_StuStatuss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_StuStatuss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_StuStatus, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_StuStatuss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_StuStatus>(exp,values)});
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
