using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ParkVouchRes))]
#if Dev
    [RunLocal]
#endif

	public class FI_ParkVouchRes:ReadOnlyBase<FI_ParkVouchRes>
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

		public static FI_ParkVouchRes Create()
        {
            return EF.DataPortal.Create<FI_ParkVouchRes>();
        }

		public static FI_ParkVouchRes Fetch(System.Linq.Expressions.Expression<Func<FI_ParkVouchRes, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ParkVouchRes>(exp,values);
            return EF.DataPortal.Fetch<FI_ParkVouchRes>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ParkVouchRess))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ParkVouchRess:ReadOnlyListBase<FI_ParkVouchRess,FI_ParkVouchRes>
    {
        #region Factory Methods

        public static FI_ParkVouchRess Fetch()
        {
            return EF.DataPortal.Fetch<FI_ParkVouchRess>();
        }

		public static FI_ParkVouchRess Fetch(System.Linq.Expressions.Expression<Func<FI_ParkVouchRes, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ParkVouchRes>(exp,values);
            return EF.DataPortal.Fetch<FI_ParkVouchRess>(lambda);
		}

		public static FI_ParkVouchRess Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ParkVouchRess>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ParkVouchRess Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ParkVouchRes, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ParkVouchRess>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ParkVouchRes>(exp,values)});
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
