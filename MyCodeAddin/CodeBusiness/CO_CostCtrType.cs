using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CO_CostCtrType))]
#if Dev
    [RunLocal]
#endif

	public class CO_CostCtrType:ReadOnlyBase<CO_CostCtrType>
    {
        #region Business Methods

		
        public string CostCtrType
        {
            get ;
            set ;
        }

		
        public string STEXT
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static CO_CostCtrType Create()
        {
            return EF.DataPortal.Create<CO_CostCtrType>();
        }

		public static CO_CostCtrType Fetch(System.Linq.Expressions.Expression<Func<CO_CostCtrType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CO_CostCtrType>(exp,values);
            return EF.DataPortal.Fetch<CO_CostCtrType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CO_CostCtrTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class CO_CostCtrTypes:ReadOnlyListBase<CO_CostCtrTypes,CO_CostCtrType>
    {
        #region Factory Methods

        public static CO_CostCtrTypes Fetch()
        {
            return EF.DataPortal.Fetch<CO_CostCtrTypes>();
        }

		public static CO_CostCtrTypes Fetch(System.Linq.Expressions.Expression<Func<CO_CostCtrType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CO_CostCtrType>(exp,values);
            return EF.DataPortal.Fetch<CO_CostCtrTypes>(lambda);
		}

		public static CO_CostCtrTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CO_CostCtrTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CO_CostCtrTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CO_CostCtrType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CO_CostCtrTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CO_CostCtrType>(exp,values)});
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
