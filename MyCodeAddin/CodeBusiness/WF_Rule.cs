using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(WF_Rule))]
#if Dev
    [RunLocal]
#endif

	public class WF_Rule:ReadOnlyBase<WF_Rule>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string WorkFlowId
        {
            get ;
            set ;
        }

		
        public string RuleId
        {
            get ;
            set ;
        }

		
        public string RuleType
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string ObjectName
        {
            get ;
            set ;
        }

		
        public string Description
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static WF_Rule Create()
        {
            return EF.DataPortal.Create<WF_Rule>();
        }

		public static WF_Rule Fetch(System.Linq.Expressions.Expression<Func<WF_Rule, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<WF_Rule>(exp,values);
            return EF.DataPortal.Fetch<WF_Rule>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(WF_Rules))]
#if Dev
    [RunLocal]
#endif
	
	public class WF_Rules:ReadOnlyListBase<WF_Rules,WF_Rule>
    {
        #region Factory Methods

        public static WF_Rules Fetch()
        {
            return EF.DataPortal.Fetch<WF_Rules>();
        }

		public static WF_Rules Fetch(System.Linq.Expressions.Expression<Func<WF_Rule, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<WF_Rule>(exp,values);
            return EF.DataPortal.Fetch<WF_Rules>(lambda);
		}

		public static WF_Rules Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<WF_Rules>(new Paging { Page=page,RowCount=rowCount});
        }

        public static WF_Rules Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<WF_Rule, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<WF_Rules>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<WF_Rule>(exp,values)});
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
