using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_SetCls))]
#if Dev
    [RunLocal]
#endif

	public class EF_SetCls:ReadOnlyBase<EF_SetCls>
    {
        #region Business Methods

		
        public string SetClass
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

		public static EF_SetCls Create()
        {
            return EF.DataPortal.Create<EF_SetCls>();
        }

		public static EF_SetCls Fetch(System.Linq.Expressions.Expression<Func<EF_SetCls, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_SetCls>(exp,values);
            return EF.DataPortal.Fetch<EF_SetCls>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_SetClss))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_SetClss:ReadOnlyListBase<EF_SetClss,EF_SetCls>
    {
        #region Factory Methods

        public static EF_SetClss Fetch()
        {
            return EF.DataPortal.Fetch<EF_SetClss>();
        }

		public static EF_SetClss Fetch(System.Linq.Expressions.Expression<Func<EF_SetCls, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_SetCls>(exp,values);
            return EF.DataPortal.Fetch<EF_SetClss>(lambda);
		}

		public static EF_SetClss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_SetClss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_SetClss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_SetCls, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_SetClss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_SetCls>(exp,values)});
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
