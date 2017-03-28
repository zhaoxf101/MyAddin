using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(UP_Merchant))]
#if Dev
    [RunLocal]
#endif

	public class UP_Merchant:ReadOnlyBase<UP_Merchant>
    {
        #region Business Methods

		
        public Guid Id
        {
            get ;
            set ;
        }

		
        public string MerchantNo
        {
            get ;
            set ;
        }

		
        public string MerchantName
        {
            get ;
            set ;
        }

		
        public string BusinessNo
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

		
        public string BusinessPerson
        {
            get ;
            set ;
        }

		
        public bool IsRecMsg
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

		public static UP_Merchant Create()
        {
            return EF.DataPortal.Create<UP_Merchant>();
        }

		public static UP_Merchant Fetch(System.Linq.Expressions.Expression<Func<UP_Merchant, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<UP_Merchant>(exp,values);
            return EF.DataPortal.Fetch<UP_Merchant>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(UP_Merchants))]
#if Dev
    [RunLocal]
#endif
	
	public class UP_Merchants:ReadOnlyListBase<UP_Merchants,UP_Merchant>
    {
        #region Factory Methods

        public static UP_Merchants Fetch()
        {
            return EF.DataPortal.Fetch<UP_Merchants>();
        }

		public static UP_Merchants Fetch(System.Linq.Expressions.Expression<Func<UP_Merchant, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<UP_Merchant>(exp,values);
            return EF.DataPortal.Fetch<UP_Merchants>(lambda);
		}

		public static UP_Merchants Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<UP_Merchants>(new Paging { Page=page,RowCount=rowCount});
        }

        public static UP_Merchants Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<UP_Merchant, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<UP_Merchants>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<UP_Merchant>(exp,values)});
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
