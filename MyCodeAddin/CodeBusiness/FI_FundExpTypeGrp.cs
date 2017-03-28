using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_FundExpTypeGrp))]
#if Dev
    [RunLocal]
#endif

	public class FI_FundExpTypeGrp:ReadOnlyBase<FI_FundExpTypeGrp>
    {
        #region Business Methods

		
        public string FundExpTypeGrpCode
        {
            get ;
            set ;
        }

		
        public string FundExpTypeGrpName
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public string Memo
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

		public static FI_FundExpTypeGrp Create()
        {
            return EF.DataPortal.Create<FI_FundExpTypeGrp>();
        }

		public static FI_FundExpTypeGrp Fetch(System.Linq.Expressions.Expression<Func<FI_FundExpTypeGrp, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_FundExpTypeGrp>(exp,values);
            return EF.DataPortal.Fetch<FI_FundExpTypeGrp>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_FundExpTypeGrps))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_FundExpTypeGrps:ReadOnlyListBase<FI_FundExpTypeGrps,FI_FundExpTypeGrp>
    {
        #region Factory Methods

        public static FI_FundExpTypeGrps Fetch()
        {
            return EF.DataPortal.Fetch<FI_FundExpTypeGrps>();
        }

		public static FI_FundExpTypeGrps Fetch(System.Linq.Expressions.Expression<Func<FI_FundExpTypeGrp, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_FundExpTypeGrp>(exp,values);
            return EF.DataPortal.Fetch<FI_FundExpTypeGrps>(lambda);
		}

		public static FI_FundExpTypeGrps Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_FundExpTypeGrps>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_FundExpTypeGrps Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_FundExpTypeGrp, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_FundExpTypeGrps>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_FundExpTypeGrp>(exp,values)});
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
