using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(UP_UserCard))]
#if Dev
    [RunLocal]
#endif

	public class UP_UserCard:ReadOnlyBase<UP_UserCard>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
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

		
        public Guid? AccountId
        {
            get ;
            set ;
        }

		
        public Guid? CardId
        {
            get ;
            set ;
        }

		
        public DateTime? LossTime
        {
            get ;
            set ;
        }

		
        public DateTime? StartTime
        {
            get ;
            set ;
        }

		
        public DateTime? EndTime
        {
            get ;
            set ;
        }

		
        public string Status
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

		public static UP_UserCard Create()
        {
            return EF.DataPortal.Create<UP_UserCard>();
        }

		public static UP_UserCard Fetch(System.Linq.Expressions.Expression<Func<UP_UserCard, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<UP_UserCard>(exp,values);
            return EF.DataPortal.Fetch<UP_UserCard>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(UP_UserCards))]
#if Dev
    [RunLocal]
#endif
	
	public class UP_UserCards:ReadOnlyListBase<UP_UserCards,UP_UserCard>
    {
        #region Factory Methods

        public static UP_UserCards Fetch()
        {
            return EF.DataPortal.Fetch<UP_UserCards>();
        }

		public static UP_UserCards Fetch(System.Linq.Expressions.Expression<Func<UP_UserCard, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<UP_UserCard>(exp,values);
            return EF.DataPortal.Fetch<UP_UserCards>(lambda);
		}

		public static UP_UserCards Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<UP_UserCards>(new Paging { Page=page,RowCount=rowCount});
        }

        public static UP_UserCards Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<UP_UserCard, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<UP_UserCards>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<UP_UserCard>(exp,values)});
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
