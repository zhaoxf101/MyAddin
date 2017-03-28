using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExchRate))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExchRate:ReadOnlyBase<FI_ExchRate>
    {
        #region Business Methods

		
        public string FCurr
        {
            get ;
            set ;
        }

		
        public string TCurr
        {
            get ;
            set ;
        }

		
        public string VDate
        {
            get ;
            set ;
        }

		
        public decimal Rate
        {
            get ;
            set ;
        }

		
        public int FRatio
        {
            get ;
            set ;
        }

		
        public int TRatio
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public string CreatedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public string ChangedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_ExchRate Create()
        {
            return EF.DataPortal.Create<FI_ExchRate>();
        }

		public static FI_ExchRate Fetch(System.Linq.Expressions.Expression<Func<FI_ExchRate, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExchRate>(exp,values);
            return EF.DataPortal.Fetch<FI_ExchRate>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExchRates))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExchRates:ReadOnlyListBase<FI_ExchRates,FI_ExchRate>
    {
        #region Factory Methods

        public static FI_ExchRates Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExchRates>();
        }

		public static FI_ExchRates Fetch(System.Linq.Expressions.Expression<Func<FI_ExchRate, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExchRate>(exp,values);
            return EF.DataPortal.Fetch<FI_ExchRates>(lambda);
		}

		public static FI_ExchRates Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExchRates>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExchRates Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExchRate, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExchRates>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExchRate>(exp,values)});
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
