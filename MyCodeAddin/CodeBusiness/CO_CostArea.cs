using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CO_CostArea))]
#if Dev
    [RunLocal]
#endif

	public class CO_CostArea:ReadOnlyBase<CO_CostArea>
    {
        #region Business Methods

		
        public string CostArea
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string CostStdLev
        {
            get ;
            set ;
        }

		
        public string ProfitStdLev
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static CO_CostArea Create()
        {
            return EF.DataPortal.Create<CO_CostArea>();
        }

		public static CO_CostArea Fetch(System.Linq.Expressions.Expression<Func<CO_CostArea, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CO_CostArea>(exp,values);
            return EF.DataPortal.Fetch<CO_CostArea>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CO_CostAreas))]
#if Dev
    [RunLocal]
#endif
	
	public class CO_CostAreas:ReadOnlyListBase<CO_CostAreas,CO_CostArea>
    {
        #region Factory Methods

        public static CO_CostAreas Fetch()
        {
            return EF.DataPortal.Fetch<CO_CostAreas>();
        }

		public static CO_CostAreas Fetch(System.Linq.Expressions.Expression<Func<CO_CostArea, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CO_CostArea>(exp,values);
            return EF.DataPortal.Fetch<CO_CostAreas>(lambda);
		}

		public static CO_CostAreas Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CO_CostAreas>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CO_CostAreas Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CO_CostArea, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CO_CostAreas>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CO_CostArea>(exp,values)});
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
