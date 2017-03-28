using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(WF_OwnerGroupSwitch))]
#if Dev
    [RunLocal]
#endif

	public class WF_OwnerGroupSwitch:ReadOnlyBase<WF_OwnerGroupSwitch>
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

		
        public int Position
        {
            get ;
            set ;
        }

		
        public string RuleId
        {
            get ;
            set ;
        }

		
        public bool Value
        {
            get ;
            set ;
        }

		
        public string Args
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static WF_OwnerGroupSwitch Create()
        {
            return EF.DataPortal.Create<WF_OwnerGroupSwitch>();
        }

		public static WF_OwnerGroupSwitch Fetch(System.Linq.Expressions.Expression<Func<WF_OwnerGroupSwitch, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<WF_OwnerGroupSwitch>(exp,values);
            return EF.DataPortal.Fetch<WF_OwnerGroupSwitch>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(WF_OwnerGroupSwitchs))]
#if Dev
    [RunLocal]
#endif
	
	public class WF_OwnerGroupSwitchs:ReadOnlyListBase<WF_OwnerGroupSwitchs,WF_OwnerGroupSwitch>
    {
        #region Factory Methods

        public static WF_OwnerGroupSwitchs Fetch()
        {
            return EF.DataPortal.Fetch<WF_OwnerGroupSwitchs>();
        }

		public static WF_OwnerGroupSwitchs Fetch(System.Linq.Expressions.Expression<Func<WF_OwnerGroupSwitch, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<WF_OwnerGroupSwitch>(exp,values);
            return EF.DataPortal.Fetch<WF_OwnerGroupSwitchs>(lambda);
		}

		public static WF_OwnerGroupSwitchs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<WF_OwnerGroupSwitchs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static WF_OwnerGroupSwitchs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<WF_OwnerGroupSwitch, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<WF_OwnerGroupSwitchs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<WF_OwnerGroupSwitch>(exp,values)});
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
