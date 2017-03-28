using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_AppGB))]
#if Dev
    [RunLocal]
#endif

	public class EF_AppGB:ReadOnlyBase<EF_AppGB>
    {
        #region Business Methods

		
        public string AGBlock
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

		public static EF_AppGB Create()
        {
            return EF.DataPortal.Create<EF_AppGB>();
        }

		public static EF_AppGB Fetch(System.Linq.Expressions.Expression<Func<EF_AppGB, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_AppGB>(exp,values);
            return EF.DataPortal.Fetch<EF_AppGB>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_AppGBs))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_AppGBs:ReadOnlyListBase<EF_AppGBs,EF_AppGB>
    {
        #region Factory Methods

        public static EF_AppGBs Fetch()
        {
            return EF.DataPortal.Fetch<EF_AppGBs>();
        }

		public static EF_AppGBs Fetch(System.Linq.Expressions.Expression<Func<EF_AppGB, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_AppGB>(exp,values);
            return EF.DataPortal.Fetch<EF_AppGBs>(lambda);
		}

		public static EF_AppGBs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_AppGBs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_AppGBs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_AppGB, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_AppGBs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_AppGB>(exp,values)});
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
