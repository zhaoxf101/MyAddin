using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_Message))]
#if Dev
    [RunLocal]
#endif

	public class EF_Message:ReadOnlyBase<EF_Message>
    {
        #region Business Methods

		
        public string AGBlock
        {
            get ;
            set ;
        }

		
        public string MsgNo
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

		public static EF_Message Create()
        {
            return EF.DataPortal.Create<EF_Message>();
        }

		public static EF_Message Fetch(System.Linq.Expressions.Expression<Func<EF_Message, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_Message>(exp,values);
            return EF.DataPortal.Fetch<EF_Message>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_Messages))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_Messages:ReadOnlyListBase<EF_Messages,EF_Message>
    {
        #region Factory Methods

        public static EF_Messages Fetch()
        {
            return EF.DataPortal.Fetch<EF_Messages>();
        }

		public static EF_Messages Fetch(System.Linq.Expressions.Expression<Func<EF_Message, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_Message>(exp,values);
            return EF.DataPortal.Fetch<EF_Messages>(lambda);
		}

		public static EF_Messages Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_Messages>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_Messages Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_Message, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_Messages>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_Message>(exp,values)});
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
