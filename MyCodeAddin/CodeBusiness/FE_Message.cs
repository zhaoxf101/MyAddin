using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FE_Message))]
#if Dev
    [RunLocal]
#endif

	public class FE_Message:ReadOnlyBase<FE_Message>
    {
        #region Business Methods

		
        public string MessageID
        {
            get ;
            set ;
        }

		
        public string TemplateID
        {
            get ;
            set ;
        }

		
        public string TemplateName
        {
            get ;
            set ;
        }

		
        public string TemplateDesc
        {
            get ;
            set ;
        }

		
        public bool IsActive
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FE_Message Create()
        {
            return EF.DataPortal.Create<FE_Message>();
        }

		public static FE_Message Fetch(System.Linq.Expressions.Expression<Func<FE_Message, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FE_Message>(exp,values);
            return EF.DataPortal.Fetch<FE_Message>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FE_Messages))]
#if Dev
    [RunLocal]
#endif
	
	public class FE_Messages:ReadOnlyListBase<FE_Messages,FE_Message>
    {
        #region Factory Methods

        public static FE_Messages Fetch()
        {
            return EF.DataPortal.Fetch<FE_Messages>();
        }

		public static FE_Messages Fetch(System.Linq.Expressions.Expression<Func<FE_Message, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FE_Message>(exp,values);
            return EF.DataPortal.Fetch<FE_Messages>(lambda);
		}

		public static FE_Messages Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FE_Messages>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FE_Messages Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FE_Message, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FE_Messages>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FE_Message>(exp,values)});
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
