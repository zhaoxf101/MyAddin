using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(zif))]
#if Dev
    [RunLocal]
#endif

	public class zif:ReadOnlyBase<zif>
    {
        #region Business Methods

		
        public string y
        {
            get ;
            set ;
        }

		
        public string pcode
        {
            get ;
            set ;
        }

		
        public string tcode
        {
            get ;
            set ;
        }

		
        public string fcode
        {
            get ;
            set ;
        }

		
        public string exprow
        {
            get ;
            set ;
        }

		
        public decimal? bamt
        {
            get ;
            set ;
        }

		
        public decimal? camt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static zif Create()
        {
            return EF.DataPortal.Create<zif>();
        }

		public static zif Fetch(System.Linq.Expressions.Expression<Func<zif, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<zif>(exp,values);
            return EF.DataPortal.Fetch<zif>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(zifs))]
#if Dev
    [RunLocal]
#endif
	
	public class zifs:ReadOnlyListBase<zifs,zif>
    {
        #region Factory Methods

        public static zifs Fetch()
        {
            return EF.DataPortal.Fetch<zifs>();
        }

		public static zifs Fetch(System.Linq.Expressions.Expression<Func<zif, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<zif>(exp,values);
            return EF.DataPortal.Fetch<zifs>(lambda);
		}

		public static zifs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<zifs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static zifs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<zif, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<zifs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<zif>(exp,values)});
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
