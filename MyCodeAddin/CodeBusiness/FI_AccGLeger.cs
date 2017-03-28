using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_AccGLeger))]
#if Dev
    [RunLocal]
#endif

	public class FI_AccGLeger:ReadOnlyBase<FI_AccGLeger>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AccYear
        {
            get ;
            set ;
        }

		
        public string AccCode
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

		
        public decimal VBAmt
        {
            get ;
            set ;
        }

		
        public decimal VDAmt01
        {
            get ;
            set ;
        }

		
        public decimal VDAmt02
        {
            get ;
            set ;
        }

		
        public decimal VDAmt03
        {
            get ;
            set ;
        }

		
        public decimal VDAmt04
        {
            get ;
            set ;
        }

		
        public decimal VDAmt05
        {
            get ;
            set ;
        }

		
        public decimal VDAmt06
        {
            get ;
            set ;
        }

		
        public decimal VDAmt07
        {
            get ;
            set ;
        }

		
        public decimal VDAmt08
        {
            get ;
            set ;
        }

		
        public decimal VDAmt09
        {
            get ;
            set ;
        }

		
        public decimal VDAmt10
        {
            get ;
            set ;
        }

		
        public decimal VDAmt11
        {
            get ;
            set ;
        }

		
        public decimal VDAmt12
        {
            get ;
            set ;
        }

		
        public decimal VDAmt13
        {
            get ;
            set ;
        }

		
        public decimal VDAmt14
        {
            get ;
            set ;
        }

		
        public decimal VDAmt15
        {
            get ;
            set ;
        }

		
        public decimal VDAmt16
        {
            get ;
            set ;
        }

		
        public decimal VCAmt01
        {
            get ;
            set ;
        }

		
        public decimal VCAmt02
        {
            get ;
            set ;
        }

		
        public decimal VCAmt03
        {
            get ;
            set ;
        }

		
        public decimal VCAmt04
        {
            get ;
            set ;
        }

		
        public decimal VCAmt05
        {
            get ;
            set ;
        }

		
        public decimal VCAmt06
        {
            get ;
            set ;
        }

		
        public decimal VCAmt07
        {
            get ;
            set ;
        }

		
        public decimal VCAmt08
        {
            get ;
            set ;
        }

		
        public decimal VCAmt09
        {
            get ;
            set ;
        }

		
        public decimal VCAmt10
        {
            get ;
            set ;
        }

		
        public decimal VCAmt11
        {
            get ;
            set ;
        }

		
        public decimal VCAmt12
        {
            get ;
            set ;
        }

		
        public decimal VCAmt13
        {
            get ;
            set ;
        }

		
        public decimal VCAmt14
        {
            get ;
            set ;
        }

		
        public decimal VCAmt15
        {
            get ;
            set ;
        }

		
        public decimal VCAmt16
        {
            get ;
            set ;
        }

		
        public decimal BQty
        {
            get ;
            set ;
        }

		
        public decimal DQty01
        {
            get ;
            set ;
        }

		
        public decimal DQty02
        {
            get ;
            set ;
        }

		
        public decimal DQty03
        {
            get ;
            set ;
        }

		
        public decimal DQty04
        {
            get ;
            set ;
        }

		
        public decimal DQty05
        {
            get ;
            set ;
        }

		
        public decimal DQty06
        {
            get ;
            set ;
        }

		
        public decimal DQty07
        {
            get ;
            set ;
        }

		
        public decimal DQty08
        {
            get ;
            set ;
        }

		
        public decimal DQty09
        {
            get ;
            set ;
        }

		
        public decimal DQty10
        {
            get ;
            set ;
        }

		
        public decimal DQty11
        {
            get ;
            set ;
        }

		
        public decimal DQty12
        {
            get ;
            set ;
        }

		
        public decimal DQty13
        {
            get ;
            set ;
        }

		
        public decimal DQty14
        {
            get ;
            set ;
        }

		
        public decimal DQty15
        {
            get ;
            set ;
        }

		
        public decimal DQty16
        {
            get ;
            set ;
        }

		
        public decimal CQty01
        {
            get ;
            set ;
        }

		
        public decimal CQty02
        {
            get ;
            set ;
        }

		
        public decimal CQty03
        {
            get ;
            set ;
        }

		
        public decimal CQty04
        {
            get ;
            set ;
        }

		
        public decimal CQty05
        {
            get ;
            set ;
        }

		
        public decimal CQty06
        {
            get ;
            set ;
        }

		
        public decimal CQty07
        {
            get ;
            set ;
        }

		
        public decimal CQty08
        {
            get ;
            set ;
        }

		
        public decimal CQty09
        {
            get ;
            set ;
        }

		
        public decimal CQty10
        {
            get ;
            set ;
        }

		
        public decimal CQty11
        {
            get ;
            set ;
        }

		
        public decimal CQty12
        {
            get ;
            set ;
        }

		
        public decimal CQty13
        {
            get ;
            set ;
        }

		
        public decimal CQty14
        {
            get ;
            set ;
        }

		
        public decimal CQty15
        {
            get ;
            set ;
        }

		
        public decimal CQty16
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_AccGLeger Create()
        {
            return EF.DataPortal.Create<FI_AccGLeger>();
        }

		public static FI_AccGLeger Fetch(System.Linq.Expressions.Expression<Func<FI_AccGLeger, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_AccGLeger>(exp,values);
            return EF.DataPortal.Fetch<FI_AccGLeger>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_AccGLegers))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_AccGLegers:ReadOnlyListBase<FI_AccGLegers,FI_AccGLeger>
    {
        #region Factory Methods

        public static FI_AccGLegers Fetch()
        {
            return EF.DataPortal.Fetch<FI_AccGLegers>();
        }

		public static FI_AccGLegers Fetch(System.Linq.Expressions.Expression<Func<FI_AccGLeger, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_AccGLeger>(exp,values);
            return EF.DataPortal.Fetch<FI_AccGLegers>(lambda);
		}

		public static FI_AccGLegers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_AccGLegers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_AccGLegers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_AccGLeger, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_AccGLegers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_AccGLeger>(exp,values)});
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
