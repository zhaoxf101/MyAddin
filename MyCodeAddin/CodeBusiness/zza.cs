using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(zza))]
#if Dev
    [RunLocal]
#endif

	public class zza:ReadOnlyBase<zza>
    {
        #region Business Methods

		
        public string a
        {
            get ;
            set ;
        }

		
        public string b
        {
            get ;
            set ;
        }

		
        public string c
        {
            get ;
            set ;
        }

		
        public string d
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static zza Create()
        {
            return EF.DataPortal.Create<zza>();
        }

		public static zza Fetch(System.Linq.Expressions.Expression<Func<zza, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<zza>(exp,values);
            return EF.DataPortal.Fetch<zza>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(zzas))]
#if Dev
    [RunLocal]
#endif
	
	public class zzas:ReadOnlyListBase<zzas,zza>
    {
        #region Factory Methods

        public static zzas Fetch()
        {
            return EF.DataPortal.Fetch<zzas>();
        }

		public static zzas Fetch(System.Linq.Expressions.Expression<Func<zza, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<zza>(exp,values);
            return EF.DataPortal.Fetch<zzas>(lambda);
		}

		public static zzas Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<zzas>(new Paging { Page=page,RowCount=rowCount});
        }

        public static zzas Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<zza, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<zzas>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<zza>(exp,values)});
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
