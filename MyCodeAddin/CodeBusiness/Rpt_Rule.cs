using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Rpt_Rule))]
#if Dev
    [RunLocal]
#endif

	public class Rpt_Rule:ReadOnlyBase<Rpt_Rule>
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

		
        public string RuleName
        {
            get ;
            set ;
        }

		
        public string AccType
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static Rpt_Rule Create()
        {
            return EF.DataPortal.Create<Rpt_Rule>();
        }

		public static Rpt_Rule Fetch(System.Linq.Expressions.Expression<Func<Rpt_Rule, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Rpt_Rule>(exp,values);
            return EF.DataPortal.Fetch<Rpt_Rule>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Rpt_Rules))]
#if Dev
    [RunLocal]
#endif
	
	public class Rpt_Rules:ReadOnlyListBase<Rpt_Rules,Rpt_Rule>
    {
        #region Factory Methods

        public static Rpt_Rules Fetch()
        {
            return EF.DataPortal.Fetch<Rpt_Rules>();
        }

		public static Rpt_Rules Fetch(System.Linq.Expressions.Expression<Func<Rpt_Rule, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Rpt_Rule>(exp,values);
            return EF.DataPortal.Fetch<Rpt_Rules>(lambda);
		}

		public static Rpt_Rules Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Rpt_Rules>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Rpt_Rules Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Rpt_Rule, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Rpt_Rules>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Rpt_Rule>(exp,values)});
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
