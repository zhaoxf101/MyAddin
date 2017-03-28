using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CO_CostElemType))]
#if Dev
    [RunLocal]
#endif

	public class CO_CostElemType:ReadOnlyBase<CO_CostElemType>
    {
        #region Business Methods

		
        public string CostElemType
        {
            get ;
            set ;
        }

		
        public bool FirstElemX
        {
            get ;
            set ;
        }

		
        public bool ProfitElemX
        {
            get ;
            set ;
        }

		
        public string SText
        {
            get ;
            set ;
        }

		
        public string LText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static CO_CostElemType Create()
        {
            return EF.DataPortal.Create<CO_CostElemType>();
        }

		public static CO_CostElemType Fetch(System.Linq.Expressions.Expression<Func<CO_CostElemType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CO_CostElemType>(exp,values);
            return EF.DataPortal.Fetch<CO_CostElemType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CO_CostElemTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class CO_CostElemTypes:ReadOnlyListBase<CO_CostElemTypes,CO_CostElemType>
    {
        #region Factory Methods

        public static CO_CostElemTypes Fetch()
        {
            return EF.DataPortal.Fetch<CO_CostElemTypes>();
        }

		public static CO_CostElemTypes Fetch(System.Linq.Expressions.Expression<Func<CO_CostElemType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CO_CostElemType>(exp,values);
            return EF.DataPortal.Fetch<CO_CostElemTypes>(lambda);
		}

		public static CO_CostElemTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CO_CostElemTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CO_CostElemTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CO_CostElemType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CO_CostElemTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CO_CostElemType>(exp,values)});
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
