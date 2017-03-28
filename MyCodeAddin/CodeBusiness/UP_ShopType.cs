using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(UP_ShopType))]
#if Dev
    [RunLocal]
#endif

	public class UP_ShopType:ReadOnlyBase<UP_ShopType>
    {
        #region Business Methods

		
        public Guid Id
        {
            get ;
            set ;
        }

		
        public string ShopTypeCode
        {
            get ;
            set ;
        }

		
        public string ShopTypeName
        {
            get ;
            set ;
        }

		
        public string ImageUrl
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

		public static UP_ShopType Create()
        {
            return EF.DataPortal.Create<UP_ShopType>();
        }

		public static UP_ShopType Fetch(System.Linq.Expressions.Expression<Func<UP_ShopType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<UP_ShopType>(exp,values);
            return EF.DataPortal.Fetch<UP_ShopType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(UP_ShopTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class UP_ShopTypes:ReadOnlyListBase<UP_ShopTypes,UP_ShopType>
    {
        #region Factory Methods

        public static UP_ShopTypes Fetch()
        {
            return EF.DataPortal.Fetch<UP_ShopTypes>();
        }

		public static UP_ShopTypes Fetch(System.Linq.Expressions.Expression<Func<UP_ShopType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<UP_ShopType>(exp,values);
            return EF.DataPortal.Fetch<UP_ShopTypes>(lambda);
		}

		public static UP_ShopTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<UP_ShopTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static UP_ShopTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<UP_ShopType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<UP_ShopTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<UP_ShopType>(exp,values)});
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
