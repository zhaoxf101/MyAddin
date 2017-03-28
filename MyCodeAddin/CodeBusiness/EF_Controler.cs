using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_Controler))]
#if Dev
    [RunLocal]
#endif

	public class EF_Controler:ReadOnlyBase<EF_Controler>
    {
        #region Business Methods

		
        public string Controler
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string PgmName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_Controler Create()
        {
            return EF.DataPortal.Create<EF_Controler>();
        }

		public static EF_Controler Fetch(System.Linq.Expressions.Expression<Func<EF_Controler, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_Controler>(exp,values);
            return EF.DataPortal.Fetch<EF_Controler>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_Controlers))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_Controlers:ReadOnlyListBase<EF_Controlers,EF_Controler>
    {
        #region Factory Methods

        public static EF_Controlers Fetch()
        {
            return EF.DataPortal.Fetch<EF_Controlers>();
        }

		public static EF_Controlers Fetch(System.Linq.Expressions.Expression<Func<EF_Controler, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_Controler>(exp,values);
            return EF.DataPortal.Fetch<EF_Controlers>(lambda);
		}

		public static EF_Controlers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_Controlers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_Controlers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_Controler, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_Controlers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_Controler>(exp,values)});
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
