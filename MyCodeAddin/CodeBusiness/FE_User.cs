using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FE_User))]
#if Dev
    [RunLocal]
#endif

	public class FE_User:ReadOnlyBase<FE_User>
    {
        #region Business Methods

		
        public string AppId
        {
            get ;
            set ;
        }

		
        public string OpenId
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string Nickname
        {
            get ;
            set ;
        }

		
        public string Remark
        {
            get ;
            set ;
        }

		
        public int? Sex
        {
            get ;
            set ;
        }

		
        public string HeadImgUrl
        {
            get ;
            set ;
        }

		
        public DateTime? SubscribeTime
        {
            get ;
            set ;
        }

		
        public string UnionID
        {
            get ;
            set ;
        }

		
        public string GroupID
        {
            get ;
            set ;
        }

		
        public string UserState
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FE_User Create()
        {
            return EF.DataPortal.Create<FE_User>();
        }

		public static FE_User Fetch(System.Linq.Expressions.Expression<Func<FE_User, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FE_User>(exp,values);
            return EF.DataPortal.Fetch<FE_User>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FE_Users))]
#if Dev
    [RunLocal]
#endif
	
	public class FE_Users:ReadOnlyListBase<FE_Users,FE_User>
    {
        #region Factory Methods

        public static FE_Users Fetch()
        {
            return EF.DataPortal.Fetch<FE_Users>();
        }

		public static FE_Users Fetch(System.Linq.Expressions.Expression<Func<FE_User, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FE_User>(exp,values);
            return EF.DataPortal.Fetch<FE_Users>(lambda);
		}

		public static FE_Users Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FE_Users>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FE_Users Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FE_User, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FE_Users>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FE_User>(exp,values)});
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
