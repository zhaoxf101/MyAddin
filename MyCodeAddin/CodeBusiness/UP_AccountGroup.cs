using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(UP_AccountGroup))]
#if Dev
    [RunLocal]
#endif

	public class UP_AccountGroup:ReadOnlyBase<UP_AccountGroup>
    {
        #region Business Methods

		
        public Guid Id
        {
            get ;
            set ;
        }

		
        public string AccGroupCode
        {
            get ;
            set ;
        }

		
        public string AccGroupName
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

		public static UP_AccountGroup Create()
        {
            return EF.DataPortal.Create<UP_AccountGroup>();
        }

		public static UP_AccountGroup Fetch(System.Linq.Expressions.Expression<Func<UP_AccountGroup, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<UP_AccountGroup>(exp,values);
            return EF.DataPortal.Fetch<UP_AccountGroup>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(UP_AccountGroups))]
#if Dev
    [RunLocal]
#endif
	
	public class UP_AccountGroups:ReadOnlyListBase<UP_AccountGroups,UP_AccountGroup>
    {
        #region Factory Methods

        public static UP_AccountGroups Fetch()
        {
            return EF.DataPortal.Fetch<UP_AccountGroups>();
        }

		public static UP_AccountGroups Fetch(System.Linq.Expressions.Expression<Func<UP_AccountGroup, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<UP_AccountGroup>(exp,values);
            return EF.DataPortal.Fetch<UP_AccountGroups>(lambda);
		}

		public static UP_AccountGroups Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<UP_AccountGroups>(new Paging { Page=page,RowCount=rowCount});
        }

        public static UP_AccountGroups Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<UP_AccountGroup, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<UP_AccountGroups>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<UP_AccountGroup>(exp,values)});
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
