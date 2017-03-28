using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(zz3))]
#if Dev
    [RunLocal]
#endif

	public class zz3:ReadOnlyBase<zz3>
    {
        #region Business Methods

		
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

		
        public string ecode
        {
            get ;
            set ;
        }

		
        public string h
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static zz3 Create()
        {
            return EF.DataPortal.Create<zz3>();
        }

		public static zz3 Fetch(System.Linq.Expressions.Expression<Func<zz3, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<zz3>(exp,values);
            return EF.DataPortal.Fetch<zz3>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(zz3s))]
#if Dev
    [RunLocal]
#endif
	
	public class zz3s:ReadOnlyListBase<zz3s,zz3>
    {
        #region Factory Methods

        public static zz3s Fetch()
        {
            return EF.DataPortal.Fetch<zz3s>();
        }

		public static zz3s Fetch(System.Linq.Expressions.Expression<Func<zz3, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<zz3>(exp,values);
            return EF.DataPortal.Fetch<zz3s>(lambda);
		}

		public static zz3s Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<zz3s>(new Paging { Page=page,RowCount=rowCount});
        }

        public static zz3s Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<zz3, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<zz3s>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<zz3>(exp,values)});
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
