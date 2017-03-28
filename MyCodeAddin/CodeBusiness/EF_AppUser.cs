using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_AppUser))]
#if Dev
    [RunLocal]
#endif

	public class EF_AppUser:ReadOnlyBase<EF_AppUser>
    {
        #region Business Methods

		
        public string AppId
        {
            get ;
            set ;
        }

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string Secret
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_AppUser Create()
        {
            return EF.DataPortal.Create<EF_AppUser>();
        }

		public static EF_AppUser Fetch(System.Linq.Expressions.Expression<Func<EF_AppUser, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_AppUser>(exp,values);
            return EF.DataPortal.Fetch<EF_AppUser>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_AppUsers))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_AppUsers:ReadOnlyListBase<EF_AppUsers,EF_AppUser>
    {
        #region Factory Methods

        public static EF_AppUsers Fetch()
        {
            return EF.DataPortal.Fetch<EF_AppUsers>();
        }

		public static EF_AppUsers Fetch(System.Linq.Expressions.Expression<Func<EF_AppUser, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_AppUser>(exp,values);
            return EF.DataPortal.Fetch<EF_AppUsers>(lambda);
		}

		public static EF_AppUsers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_AppUsers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_AppUsers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_AppUser, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_AppUsers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_AppUser>(exp,values)});
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
