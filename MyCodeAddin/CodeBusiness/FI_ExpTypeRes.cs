using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpTypeRes))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpTypeRes:ReadOnlyBase<FI_ExpTypeRes>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ExpTypeCode
        {
            get ;
            set ;
        }

		
        public string ResouItemCode
        {
            get ;
            set ;
        }

		
        public bool IsSubsidy
        {
            get ;
            set ;
        }

		
        public decimal SubsidyStand
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_ExpTypeRes Create()
        {
            return EF.DataPortal.Create<FI_ExpTypeRes>();
        }

		public static FI_ExpTypeRes Fetch(System.Linq.Expressions.Expression<Func<FI_ExpTypeRes, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpTypeRes>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpTypeRes>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpTypeRess))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpTypeRess:ReadOnlyListBase<FI_ExpTypeRess,FI_ExpTypeRes>
    {
        #region Factory Methods

        public static FI_ExpTypeRess Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpTypeRess>();
        }

		public static FI_ExpTypeRess Fetch(System.Linq.Expressions.Expression<Func<FI_ExpTypeRes, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpTypeRes>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpTypeRess>(lambda);
		}

		public static FI_ExpTypeRess Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpTypeRess>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpTypeRess Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpTypeRes, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpTypeRess>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpTypeRes>(exp,values)});
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
