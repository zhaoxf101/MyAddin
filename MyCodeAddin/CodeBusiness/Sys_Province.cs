using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_Province))]
#if Dev
    [RunLocal]
#endif

	public class Sys_Province:ReadOnlyBase<Sys_Province>
    {
        #region Business Methods

		
        public string ProvinceCode
        {
            get ;
            set ;
        }

		
        public string ProvinceName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static Sys_Province Create()
        {
            return EF.DataPortal.Create<Sys_Province>();
        }

		public static Sys_Province Fetch(System.Linq.Expressions.Expression<Func<Sys_Province, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_Province>(exp,values);
            return EF.DataPortal.Fetch<Sys_Province>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_Provinces))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_Provinces:ReadOnlyListBase<Sys_Provinces,Sys_Province>
    {
        #region Factory Methods

        public static Sys_Provinces Fetch()
        {
            return EF.DataPortal.Fetch<Sys_Provinces>();
        }

		public static Sys_Provinces Fetch(System.Linq.Expressions.Expression<Func<Sys_Province, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_Province>(exp,values);
            return EF.DataPortal.Fetch<Sys_Provinces>(lambda);
		}

		public static Sys_Provinces Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_Provinces>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_Provinces Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_Province, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_Provinces>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_Province>(exp,values)});
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
