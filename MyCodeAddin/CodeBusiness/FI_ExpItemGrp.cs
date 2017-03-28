using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpItemGrp))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpItemGrp:ReadOnlyBase<FI_ExpItemGrp>
    {
        #region Business Methods

		
        public string ExpItemGrpCode
        {
            get ;
            set ;
        }

		
        public string ExpItemGrpName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_ExpItemGrp Create()
        {
            return EF.DataPortal.Create<FI_ExpItemGrp>();
        }

		public static FI_ExpItemGrp Fetch(System.Linq.Expressions.Expression<Func<FI_ExpItemGrp, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpItemGrp>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpItemGrp>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpItemGrps))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpItemGrps:ReadOnlyListBase<FI_ExpItemGrps,FI_ExpItemGrp>
    {
        #region Factory Methods

        public static FI_ExpItemGrps Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpItemGrps>();
        }

		public static FI_ExpItemGrps Fetch(System.Linq.Expressions.Expression<Func<FI_ExpItemGrp, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpItemGrp>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpItemGrps>(lambda);
		}

		public static FI_ExpItemGrps Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpItemGrps>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpItemGrps Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpItemGrp, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpItemGrps>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpItemGrp>(exp,values)});
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
