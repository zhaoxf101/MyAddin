using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_VouchRes))]
#if Dev
    [RunLocal]
#endif

	public class FI_VouchRes:ReadOnlyBase<FI_VouchRes>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string VouchNo
        {
            get ;
            set ;
        }

		
        public string AccYear
        {
            get ;
            set ;
        }

		
        public string AccPid
        {
            get ;
            set ;
        }

		
        public string LineNR
        {
            get ;
            set ;
        }

		
        public string CostCtr
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string TaskCode
        {
            get ;
            set ;
        }

		
        public string ExpItemRow
        {
            get ;
            set ;
        }

		
        public string ExpItemCode
        {
            get ;
            set ;
        }

		
        public string ResouItemCode
        {
            get ;
            set ;
        }

		
        public decimal Qty
        {
            get ;
            set ;
        }

		
        public decimal LAmt
        {
            get ;
            set ;
        }

		
        public decimal VAmt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_VouchRes Create()
        {
            return EF.DataPortal.Create<FI_VouchRes>();
        }

		public static FI_VouchRes Fetch(System.Linq.Expressions.Expression<Func<FI_VouchRes, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_VouchRes>(exp,values);
            return EF.DataPortal.Fetch<FI_VouchRes>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_VouchRess))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_VouchRess:ReadOnlyListBase<FI_VouchRess,FI_VouchRes>
    {
        #region Factory Methods

        public static FI_VouchRess Fetch()
        {
            return EF.DataPortal.Fetch<FI_VouchRess>();
        }

		public static FI_VouchRess Fetch(System.Linq.Expressions.Expression<Func<FI_VouchRes, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_VouchRes>(exp,values);
            return EF.DataPortal.Fetch<FI_VouchRess>(lambda);
		}

		public static FI_VouchRess Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_VouchRess>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_VouchRess Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_VouchRes, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_VouchRess>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_VouchRes>(exp,values)});
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
