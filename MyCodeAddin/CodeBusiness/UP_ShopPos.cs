using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(UP_ShopPos))]
#if Dev
    [RunLocal]
#endif

	public class UP_ShopPos:ReadOnlyBase<UP_ShopPos>
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

		
        public Guid MerchantId
        {
            get ;
            set ;
        }

		
        public Guid ShopId
        {
            get ;
            set ;
        }

		
        public Guid PosId
        {
            get ;
            set ;
        }

		
        public string StartDate
        {
            get ;
            set ;
        }

		
        public string EndDate
        {
            get ;
            set ;
        }

		
        public Guid AccountGroupId
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

		public static UP_ShopPos Create()
        {
            return EF.DataPortal.Create<UP_ShopPos>();
        }

		public static UP_ShopPos Fetch(System.Linq.Expressions.Expression<Func<UP_ShopPos, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<UP_ShopPos>(exp,values);
            return EF.DataPortal.Fetch<UP_ShopPos>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(UP_ShopPoss))]
#if Dev
    [RunLocal]
#endif
	
	public class UP_ShopPoss:ReadOnlyListBase<UP_ShopPoss,UP_ShopPos>
    {
        #region Factory Methods

        public static UP_ShopPoss Fetch()
        {
            return EF.DataPortal.Fetch<UP_ShopPoss>();
        }

		public static UP_ShopPoss Fetch(System.Linq.Expressions.Expression<Func<UP_ShopPos, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<UP_ShopPos>(exp,values);
            return EF.DataPortal.Fetch<UP_ShopPoss>(lambda);
		}

		public static UP_ShopPoss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<UP_ShopPoss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static UP_ShopPoss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<UP_ShopPos, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<UP_ShopPoss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<UP_ShopPos>(exp,values)});
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
