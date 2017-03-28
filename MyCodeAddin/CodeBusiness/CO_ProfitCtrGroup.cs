using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CO_ProfitCtrGroup))]
#if Dev
    [RunLocal]
#endif

	public class CO_ProfitCtrGroup:ReadOnlyBase<CO_ProfitCtrGroup>
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

		public static CO_ProfitCtrGroup Create()
        {
            return EF.DataPortal.Create<CO_ProfitCtrGroup>();
        }

		public static CO_ProfitCtrGroup Fetch(System.Linq.Expressions.Expression<Func<CO_ProfitCtrGroup, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CO_ProfitCtrGroup>(exp,values);
            return EF.DataPortal.Fetch<CO_ProfitCtrGroup>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CO_ProfitCtrGroups))]
#if Dev
    [RunLocal]
#endif
	
	public class CO_ProfitCtrGroups:ReadOnlyListBase<CO_ProfitCtrGroups,CO_ProfitCtrGroup>
    {
        #region Factory Methods

        public static CO_ProfitCtrGroups Fetch()
        {
            return EF.DataPortal.Fetch<CO_ProfitCtrGroups>();
        }

		public static CO_ProfitCtrGroups Fetch(System.Linq.Expressions.Expression<Func<CO_ProfitCtrGroup, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CO_ProfitCtrGroup>(exp,values);
            return EF.DataPortal.Fetch<CO_ProfitCtrGroups>(lambda);
		}

		public static CO_ProfitCtrGroups Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CO_ProfitCtrGroups>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CO_ProfitCtrGroups Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CO_ProfitCtrGroup, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CO_ProfitCtrGroups>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CO_ProfitCtrGroup>(exp,values)});
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
