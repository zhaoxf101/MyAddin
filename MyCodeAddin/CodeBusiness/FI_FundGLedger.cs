using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_FundGLedger))]
#if Dev
    [RunLocal]
#endif

	public class FI_FundGLedger:ReadOnlyBase<FI_FundGLedger>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string FundCode
        {
            get ;
            set ;
        }

		
        public string AccYear
        {
            get ;
            set ;
        }

		
        public decimal LBAmt
        {
            get ;
            set ;
        }

		
        public decimal LDAmt01
        {
            get ;
            set ;
        }

		
        public decimal LDAmt02
        {
            get ;
            set ;
        }

		
        public decimal LDAmt03
        {
            get ;
            set ;
        }

		
        public decimal LDAmt04
        {
            get ;
            set ;
        }

		
        public decimal LDAmt05
        {
            get ;
            set ;
        }

		
        public decimal LDAmt06
        {
            get ;
            set ;
        }

		
        public decimal LDAmt07
        {
            get ;
            set ;
        }

		
        public decimal LDAmt08
        {
            get ;
            set ;
        }

		
        public decimal LDAmt09
        {
            get ;
            set ;
        }

		
        public decimal LDAmt10
        {
            get ;
            set ;
        }

		
        public decimal LDAmt11
        {
            get ;
            set ;
        }

		
        public decimal LDAmt12
        {
            get ;
            set ;
        }

		
        public decimal LDAmt13
        {
            get ;
            set ;
        }

		
        public decimal LDAmt14
        {
            get ;
            set ;
        }

		
        public decimal LDAmt15
        {
            get ;
            set ;
        }

		
        public decimal LDAmt16
        {
            get ;
            set ;
        }

		
        public decimal LCAmt01
        {
            get ;
            set ;
        }

		
        public decimal LCAmt02
        {
            get ;
            set ;
        }

		
        public decimal LCAmt03
        {
            get ;
            set ;
        }

		
        public decimal LCAmt04
        {
            get ;
            set ;
        }

		
        public decimal LCAmt05
        {
            get ;
            set ;
        }

		
        public decimal LCAmt06
        {
            get ;
            set ;
        }

		
        public decimal LCAmt07
        {
            get ;
            set ;
        }

		
        public decimal LCAmt08
        {
            get ;
            set ;
        }

		
        public decimal LCAmt09
        {
            get ;
            set ;
        }

		
        public decimal LCAmt10
        {
            get ;
            set ;
        }

		
        public decimal LCAmt11
        {
            get ;
            set ;
        }

		
        public decimal LCAmt12
        {
            get ;
            set ;
        }

		
        public decimal LCAmt13
        {
            get ;
            set ;
        }

		
        public decimal LCAmt14
        {
            get ;
            set ;
        }

		
        public decimal LCAmt15
        {
            get ;
            set ;
        }

		
        public decimal LCAmt16
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_FundGLedger Create()
        {
            return EF.DataPortal.Create<FI_FundGLedger>();
        }

		public static FI_FundGLedger Fetch(System.Linq.Expressions.Expression<Func<FI_FundGLedger, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_FundGLedger>(exp,values);
            return EF.DataPortal.Fetch<FI_FundGLedger>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_FundGLedgers))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_FundGLedgers:ReadOnlyListBase<FI_FundGLedgers,FI_FundGLedger>
    {
        #region Factory Methods

        public static FI_FundGLedgers Fetch()
        {
            return EF.DataPortal.Fetch<FI_FundGLedgers>();
        }

		public static FI_FundGLedgers Fetch(System.Linq.Expressions.Expression<Func<FI_FundGLedger, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_FundGLedger>(exp,values);
            return EF.DataPortal.Fetch<FI_FundGLedgers>(lambda);
		}

		public static FI_FundGLedgers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_FundGLedgers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_FundGLedgers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_FundGLedger, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_FundGLedgers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_FundGLedger>(exp,values)});
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
