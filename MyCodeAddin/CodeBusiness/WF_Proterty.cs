using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(WF_Proterty))]
#if Dev
    [RunLocal]
#endif

	public class WF_Proterty:ReadOnlyBase<WF_Proterty>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string WorkflowId
        {
            get ;
            set ;
        }

		
        public string PropertyId
        {
            get ;
            set ;
        }

		
        public string TableName
        {
            get ;
            set ;
        }

		
        public string FieldName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static WF_Proterty Create()
        {
            return EF.DataPortal.Create<WF_Proterty>();
        }

		public static WF_Proterty Fetch(System.Linq.Expressions.Expression<Func<WF_Proterty, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<WF_Proterty>(exp,values);
            return EF.DataPortal.Fetch<WF_Proterty>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(WF_Protertys))]
#if Dev
    [RunLocal]
#endif
	
	public class WF_Protertys:ReadOnlyListBase<WF_Protertys,WF_Proterty>
    {
        #region Factory Methods

        public static WF_Protertys Fetch()
        {
            return EF.DataPortal.Fetch<WF_Protertys>();
        }

		public static WF_Protertys Fetch(System.Linq.Expressions.Expression<Func<WF_Proterty, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<WF_Proterty>(exp,values);
            return EF.DataPortal.Fetch<WF_Protertys>(lambda);
		}

		public static WF_Protertys Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<WF_Protertys>(new Paging { Page=page,RowCount=rowCount});
        }

        public static WF_Protertys Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<WF_Proterty, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<WF_Protertys>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<WF_Proterty>(exp,values)});
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
