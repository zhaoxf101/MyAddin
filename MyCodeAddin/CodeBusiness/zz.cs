using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(zz))]
#if Dev
    [RunLocal]
#endif

	public class zz:ReadOnlyBase<zz>
    {
        #region Business Methods

		
        public string code
        {
            get ;
            set ;
        }

		
        public string name
        {
            get ;
            set ;
        }

		
        public string dcod
        {
            get ;
            set ;
        }

		
        public string dnam
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static zz Create()
        {
            return EF.DataPortal.Create<zz>();
        }

		public static zz Fetch(System.Linq.Expressions.Expression<Func<zz, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<zz>(exp,values);
            return EF.DataPortal.Fetch<zz>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(zzs))]
#if Dev
    [RunLocal]
#endif
	
	public class zzs:ReadOnlyListBase<zzs,zz>
    {
        #region Factory Methods

        public static zzs Fetch()
        {
            return EF.DataPortal.Fetch<zzs>();
        }

		public static zzs Fetch(System.Linq.Expressions.Expression<Func<zz, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<zz>(exp,values);
            return EF.DataPortal.Fetch<zzs>(lambda);
		}

		public static zzs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<zzs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static zzs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<zz, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<zzs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<zz>(exp,values)});
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
