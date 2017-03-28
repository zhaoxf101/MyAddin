using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(UP_Card))]
#if Dev
    [RunLocal]
#endif

	public class UP_Card:ReadOnlyBase<UP_Card>
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

		
        public string CardNo
        {
            get ;
            set ;
        }

		
        public string ChipNo
        {
            get ;
            set ;
        }

		
        public DateTime? StorageTime
        {
            get ;
            set ;
        }

		
        public string Supplier
        {
            get ;
            set ;
        }

		
        public decimal BuyPrice
        {
            get ;
            set ;
        }

		
        public bool IsUse
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

		public static UP_Card Create()
        {
            return EF.DataPortal.Create<UP_Card>();
        }

		public static UP_Card Fetch(System.Linq.Expressions.Expression<Func<UP_Card, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<UP_Card>(exp,values);
            return EF.DataPortal.Fetch<UP_Card>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(UP_Cards))]
#if Dev
    [RunLocal]
#endif
	
	public class UP_Cards:ReadOnlyListBase<UP_Cards,UP_Card>
    {
        #region Factory Methods

        public static UP_Cards Fetch()
        {
            return EF.DataPortal.Fetch<UP_Cards>();
        }

		public static UP_Cards Fetch(System.Linq.Expressions.Expression<Func<UP_Card, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<UP_Card>(exp,values);
            return EF.DataPortal.Fetch<UP_Cards>(lambda);
		}

		public static UP_Cards Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<UP_Cards>(new Paging { Page=page,RowCount=rowCount});
        }

        public static UP_Cards Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<UP_Card, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<UP_Cards>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<UP_Card>(exp,values)});
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
