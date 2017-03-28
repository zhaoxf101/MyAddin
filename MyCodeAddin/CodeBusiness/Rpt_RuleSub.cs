using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Rpt_RuleSub))]
#if Dev
    [RunLocal]
#endif

	public class Rpt_RuleSub:ReadOnlyBase<Rpt_RuleSub>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string RuleId
        {
            get ;
            set ;
        }

		
        public int Position
        {
            get ;
            set ;
        }

		
        public string PropertyId
        {
            get ;
            set ;
        }

		
        public string Operator
        {
            get ;
            set ;
        }

		
        public string Constants
        {
            get ;
            set ;
        }

		
        public bool IsGroup
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static Rpt_RuleSub Create()
        {
            return EF.DataPortal.Create<Rpt_RuleSub>();
        }

		public static Rpt_RuleSub Fetch(System.Linq.Expressions.Expression<Func<Rpt_RuleSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Rpt_RuleSub>(exp,values);
            return EF.DataPortal.Fetch<Rpt_RuleSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Rpt_RuleSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class Rpt_RuleSubs:ReadOnlyListBase<Rpt_RuleSubs,Rpt_RuleSub>
    {
        #region Factory Methods

        public static Rpt_RuleSubs Fetch()
        {
            return EF.DataPortal.Fetch<Rpt_RuleSubs>();
        }

		public static Rpt_RuleSubs Fetch(System.Linq.Expressions.Expression<Func<Rpt_RuleSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Rpt_RuleSub>(exp,values);
            return EF.DataPortal.Fetch<Rpt_RuleSubs>(lambda);
		}

		public static Rpt_RuleSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Rpt_RuleSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Rpt_RuleSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Rpt_RuleSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Rpt_RuleSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Rpt_RuleSub>(exp,values)});
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
