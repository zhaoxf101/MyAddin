using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CO_ProfitCtrType))]
#if Dev
    [RunLocal]
#endif

	public class CO_ProfitCtrType:ReadOnlyBase<CO_ProfitCtrType>
    {
        #region Business Methods

		
        public string CostArea
        {
            get ;
            set ;
        }

		
        public string ProfitCtrGroup
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static CO_ProfitCtrType Create()
        {
            return EF.DataPortal.Create<CO_ProfitCtrType>();
        }

		public static CO_ProfitCtrType Fetch(System.Linq.Expressions.Expression<Func<CO_ProfitCtrType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CO_ProfitCtrType>(exp,values);
            return EF.DataPortal.Fetch<CO_ProfitCtrType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CO_ProfitCtrTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class CO_ProfitCtrTypes:ReadOnlyListBase<CO_ProfitCtrTypes,CO_ProfitCtrType>
    {
        #region Factory Methods

        public static CO_ProfitCtrTypes Fetch()
        {
            return EF.DataPortal.Fetch<CO_ProfitCtrTypes>();
        }

		public static CO_ProfitCtrTypes Fetch(System.Linq.Expressions.Expression<Func<CO_ProfitCtrType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CO_ProfitCtrType>(exp,values);
            return EF.DataPortal.Fetch<CO_ProfitCtrTypes>(lambda);
		}

		public static CO_ProfitCtrTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CO_ProfitCtrTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CO_ProfitCtrTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CO_ProfitCtrType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CO_ProfitCtrTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CO_ProfitCtrType>(exp,values)});
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
