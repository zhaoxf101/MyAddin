using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CO_CostLedger))]
#if Dev
    [RunLocal]
#endif

	public class CO_CostLedger:ReadOnlyBase<CO_CostLedger>
    {
        #region Business Methods

		
        public string CostArea
        {
            get ;
            set ;
        }

		
        public string CostCtr
        {
            get ;
            set ;
        }

		
        public string CostElem
        {
            get ;
            set ;
        }

		
        public string ExpItemCode
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

		public static CO_CostLedger Create()
        {
            return EF.DataPortal.Create<CO_CostLedger>();
        }

		public static CO_CostLedger Fetch(System.Linq.Expressions.Expression<Func<CO_CostLedger, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CO_CostLedger>(exp,values);
            return EF.DataPortal.Fetch<CO_CostLedger>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CO_CostLedgers))]
#if Dev
    [RunLocal]
#endif
	
	public class CO_CostLedgers:ReadOnlyListBase<CO_CostLedgers,CO_CostLedger>
    {
        #region Factory Methods

        public static CO_CostLedgers Fetch()
        {
            return EF.DataPortal.Fetch<CO_CostLedgers>();
        }

		public static CO_CostLedgers Fetch(System.Linq.Expressions.Expression<Func<CO_CostLedger, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CO_CostLedger>(exp,values);
            return EF.DataPortal.Fetch<CO_CostLedgers>(lambda);
		}

		public static CO_CostLedgers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CO_CostLedgers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CO_CostLedgers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CO_CostLedger, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CO_CostLedgers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CO_CostLedger>(exp,values)});
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
