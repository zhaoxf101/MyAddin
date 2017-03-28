using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(UP_MerchantShop))]
#if Dev
    [RunLocal]
#endif

	public class UP_MerchantShop:ReadOnlyBase<UP_MerchantShop>
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

		
        public string ShopCode
        {
            get ;
            set ;
        }

		
        public string ShopName
        {
            get ;
            set ;
        }

		
        public string Address
        {
            get ;
            set ;
        }

		
        public string PhoneNo
        {
            get ;
            set ;
        }

		
        public string ImageUrl
        {
            get ;
            set ;
        }

		
        public string RDepCode
        {
            get ;
            set ;
        }

		
        public string Leader
        {
            get ;
            set ;
        }

		
        public Guid MerchantId
        {
            get ;
            set ;
        }

		
        public Guid ShopTypeId
        {
            get ;
            set ;
        }

		
        public Guid AreaId
        {
            get ;
            set ;
        }

		
        public string Remark
        {
            get ;
            set ;
        }

		
        public decimal Longitude
        {
            get ;
            set ;
        }

		
        public decimal Latitude
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

		public static UP_MerchantShop Create()
        {
            return EF.DataPortal.Create<UP_MerchantShop>();
        }

		public static UP_MerchantShop Fetch(System.Linq.Expressions.Expression<Func<UP_MerchantShop, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<UP_MerchantShop>(exp,values);
            return EF.DataPortal.Fetch<UP_MerchantShop>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(UP_MerchantShops))]
#if Dev
    [RunLocal]
#endif
	
	public class UP_MerchantShops:ReadOnlyListBase<UP_MerchantShops,UP_MerchantShop>
    {
        #region Factory Methods

        public static UP_MerchantShops Fetch()
        {
            return EF.DataPortal.Fetch<UP_MerchantShops>();
        }

		public static UP_MerchantShops Fetch(System.Linq.Expressions.Expression<Func<UP_MerchantShop, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<UP_MerchantShop>(exp,values);
            return EF.DataPortal.Fetch<UP_MerchantShops>(lambda);
		}

		public static UP_MerchantShops Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<UP_MerchantShops>(new Paging { Page=page,RowCount=rowCount});
        }

        public static UP_MerchantShops Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<UP_MerchantShop, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<UP_MerchantShops>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<UP_MerchantShop>(exp,values)});
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
