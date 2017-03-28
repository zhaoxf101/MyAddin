using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_CoCtrTypeAcc))]
#if Dev
    [RunLocal]
#endif

	public class FI_CoCtrTypeAcc:ReadOnlyBase<FI_CoCtrTypeAcc>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string CostCtrType
        {
            get ;
            set ;
        }

		
        public string AccCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_CoCtrTypeAcc Create()
        {
            return EF.DataPortal.Create<FI_CoCtrTypeAcc>();
        }

		public static FI_CoCtrTypeAcc Fetch(System.Linq.Expressions.Expression<Func<FI_CoCtrTypeAcc, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_CoCtrTypeAcc>(exp,values);
            return EF.DataPortal.Fetch<FI_CoCtrTypeAcc>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_CoCtrTypeAccs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_CoCtrTypeAccs:ReadOnlyListBase<FI_CoCtrTypeAccs,FI_CoCtrTypeAcc>
    {
        #region Factory Methods

        public static FI_CoCtrTypeAccs Fetch()
        {
            return EF.DataPortal.Fetch<FI_CoCtrTypeAccs>();
        }

		public static FI_CoCtrTypeAccs Fetch(System.Linq.Expressions.Expression<Func<FI_CoCtrTypeAcc, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_CoCtrTypeAcc>(exp,values);
            return EF.DataPortal.Fetch<FI_CoCtrTypeAccs>(lambda);
		}

		public static FI_CoCtrTypeAccs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_CoCtrTypeAccs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_CoCtrTypeAccs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_CoCtrTypeAcc, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_CoCtrTypeAccs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_CoCtrTypeAcc>(exp,values)});
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
