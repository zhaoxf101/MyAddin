using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(UP_User))]
#if Dev
    [RunLocal]
#endif

	public class UP_User:ReadOnlyBase<UP_User>
    {
        #region Business Methods

		
        public Guid Id
        {
            get ;
            set ;
        }

		
        public string UserCode
        {
            get ;
            set ;
        }

		
        public string PayPassword
        {
            get ;
            set ;
        }

		
        public bool IsNoPayPassword
        {
            get ;
            set ;
        }

		
        public decimal FreeAmt
        {
            get ;
            set ;
        }

		
        public bool PwdInitial
        {
            get ;
            set ;
        }

		
        public Guid AccountId
        {
            get ;
            set ;
        }

		
        public string PhoneNo
        {
            get ;
            set ;
        }

		
        public string Email
        {
            get ;
            set ;
        }

		
        public string Remark
        {
            get ;
            set ;
        }

		
        public string RowStatus
        {
            get ;
            set ;
        }

		
        public string CreateUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreateDate
        {
            get ;
            set ;
        }

		
        public string ChangeUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangeDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static UP_User Create()
        {
            return EF.DataPortal.Create<UP_User>();
        }

		public static UP_User Fetch(System.Linq.Expressions.Expression<Func<UP_User, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<UP_User>(exp,values);
            return EF.DataPortal.Fetch<UP_User>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(UP_Users))]
#if Dev
    [RunLocal]
#endif
	
	public class UP_Users:ReadOnlyListBase<UP_Users,UP_User>
    {
        #region Factory Methods

        public static UP_Users Fetch()
        {
            return EF.DataPortal.Fetch<UP_Users>();
        }

		public static UP_Users Fetch(System.Linq.Expressions.Expression<Func<UP_User, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<UP_User>(exp,values);
            return EF.DataPortal.Fetch<UP_Users>(lambda);
		}

		public static UP_Users Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<UP_Users>(new Paging { Page=page,RowCount=rowCount});
        }

        public static UP_Users Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<UP_User, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<UP_Users>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<UP_User>(exp,values)});
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
