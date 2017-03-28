using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(WF_OwnerProtertyRule))]
#if Dev
    [RunLocal]
#endif

	public class WF_OwnerProtertyRule:ReadOnlyBase<WF_OwnerProtertyRule>
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

		
        public string OwnerGroupId
        {
            get ;
            set ;
        }

		
        public string PositionCode
        {
            get ;
            set ;
        }

		
        public int RowId
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

		
        public string AndOr
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static WF_OwnerProtertyRule Create()
        {
            return EF.DataPortal.Create<WF_OwnerProtertyRule>();
        }

		public static WF_OwnerProtertyRule Fetch(System.Linq.Expressions.Expression<Func<WF_OwnerProtertyRule, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<WF_OwnerProtertyRule>(exp,values);
            return EF.DataPortal.Fetch<WF_OwnerProtertyRule>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(WF_OwnerProtertyRules))]
#if Dev
    [RunLocal]
#endif
	
	public class WF_OwnerProtertyRules:ReadOnlyListBase<WF_OwnerProtertyRules,WF_OwnerProtertyRule>
    {
        #region Factory Methods

        public static WF_OwnerProtertyRules Fetch()
        {
            return EF.DataPortal.Fetch<WF_OwnerProtertyRules>();
        }

		public static WF_OwnerProtertyRules Fetch(System.Linq.Expressions.Expression<Func<WF_OwnerProtertyRule, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<WF_OwnerProtertyRule>(exp,values);
            return EF.DataPortal.Fetch<WF_OwnerProtertyRules>(lambda);
		}

		public static WF_OwnerProtertyRules Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<WF_OwnerProtertyRules>(new Paging { Page=page,RowCount=rowCount});
        }

        public static WF_OwnerProtertyRules Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<WF_OwnerProtertyRule, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<WF_OwnerProtertyRules>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<WF_OwnerProtertyRule>(exp,values)});
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
