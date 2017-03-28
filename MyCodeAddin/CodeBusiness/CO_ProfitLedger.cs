using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CO_ProfitLedger))]
#if Dev
    [RunLocal]
#endif

	public class CO_ProfitLedger:ReadOnlyBase<CO_ProfitLedger>
    {
        #region Business Methods

		
        public string CostArea
        {
            get ;
            set ;
        }

		
        public string ProfitCtr
        {
            get ;
            set ;
        }

		
        public string CostElem
        {
            get ;
            set ;
        }

		
        public string IncDetCode
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

		public static CO_ProfitLedger Create()
        {
            return EF.DataPortal.Create<CO_ProfitLedger>();
        }

		public static CO_ProfitLedger Fetch(System.Linq.Expressions.Expression<Func<CO_ProfitLedger, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CO_ProfitLedger>(exp,values);
            return EF.DataPortal.Fetch<CO_ProfitLedger>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CO_ProfitLedgers))]
#if Dev
    [RunLocal]
#endif
	
	public class CO_ProfitLedgers:ReadOnlyListBase<CO_ProfitLedgers,CO_ProfitLedger>
    {
        #region Factory Methods

        public static CO_ProfitLedgers Fetch()
        {
            return EF.DataPortal.Fetch<CO_ProfitLedgers>();
        }

		public static CO_ProfitLedgers Fetch(System.Linq.Expressions.Expression<Func<CO_ProfitLedger, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CO_ProfitLedger>(exp,values);
            return EF.DataPortal.Fetch<CO_ProfitLedgers>(lambda);
		}

		public static CO_ProfitLedgers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CO_ProfitLedgers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CO_ProfitLedgers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CO_ProfitLedger, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CO_ProfitLedgers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CO_ProfitLedger>(exp,values)});
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
