using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(UP_AccountType))]
#if Dev
    [RunLocal]
#endif

	public class UP_AccountType:ReadOnlyBase<UP_AccountType>
    {
        #region Business Methods

		
        public string AccTypeCode
        {
            get ;
            set ;
        }

		
        public string AccTypeName
        {
            get ;
            set ;
        }

		
        public Guid AccountGroupId
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static UP_AccountType Create()
        {
            return EF.DataPortal.Create<UP_AccountType>();
        }

		public static UP_AccountType Fetch(System.Linq.Expressions.Expression<Func<UP_AccountType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<UP_AccountType>(exp,values);
            return EF.DataPortal.Fetch<UP_AccountType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(UP_AccountTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class UP_AccountTypes:ReadOnlyListBase<UP_AccountTypes,UP_AccountType>
    {
        #region Factory Methods

        public static UP_AccountTypes Fetch()
        {
            return EF.DataPortal.Fetch<UP_AccountTypes>();
        }

		public static UP_AccountTypes Fetch(System.Linq.Expressions.Expression<Func<UP_AccountType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<UP_AccountType>(exp,values);
            return EF.DataPortal.Fetch<UP_AccountTypes>(lambda);
		}

		public static UP_AccountTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<UP_AccountTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static UP_AccountTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<UP_AccountType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<UP_AccountTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<UP_AccountType>(exp,values)});
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
