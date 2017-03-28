using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FE_AdminUser))]
#if Dev
    [RunLocal]
#endif

	public class FE_AdminUser:ReadOnlyBase<FE_AdminUser>
    {
        #region Business Methods

		
        public string UserName
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string PassCode
        {
            get ;
            set ;
        }

		
        public string UserGroup
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FE_AdminUser Create()
        {
            return EF.DataPortal.Create<FE_AdminUser>();
        }

		public static FE_AdminUser Fetch(System.Linq.Expressions.Expression<Func<FE_AdminUser, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FE_AdminUser>(exp,values);
            return EF.DataPortal.Fetch<FE_AdminUser>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FE_AdminUsers))]
#if Dev
    [RunLocal]
#endif
	
	public class FE_AdminUsers:ReadOnlyListBase<FE_AdminUsers,FE_AdminUser>
    {
        #region Factory Methods

        public static FE_AdminUsers Fetch()
        {
            return EF.DataPortal.Fetch<FE_AdminUsers>();
        }

		public static FE_AdminUsers Fetch(System.Linq.Expressions.Expression<Func<FE_AdminUser, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FE_AdminUser>(exp,values);
            return EF.DataPortal.Fetch<FE_AdminUsers>(lambda);
		}

		public static FE_AdminUsers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FE_AdminUsers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FE_AdminUsers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FE_AdminUser, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FE_AdminUsers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FE_AdminUser>(exp,values)});
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
