using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_City))]
#if Dev
    [RunLocal]
#endif

	public class Sys_City:ReadOnlyBase<Sys_City>
    {
        #region Business Methods

		
        public string CityCode
        {
            get ;
            set ;
        }

		
        public string CityName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static Sys_City Create()
        {
            return EF.DataPortal.Create<Sys_City>();
        }

		public static Sys_City Fetch(System.Linq.Expressions.Expression<Func<Sys_City, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_City>(exp,values);
            return EF.DataPortal.Fetch<Sys_City>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_Citys))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_Citys:ReadOnlyListBase<Sys_Citys,Sys_City>
    {
        #region Factory Methods

        public static Sys_Citys Fetch()
        {
            return EF.DataPortal.Fetch<Sys_Citys>();
        }

		public static Sys_Citys Fetch(System.Linq.Expressions.Expression<Func<Sys_City, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_City>(exp,values);
            return EF.DataPortal.Fetch<Sys_Citys>(lambda);
		}

		public static Sys_Citys Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_Citys>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_Citys Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_City, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_Citys>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_City>(exp,values)});
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
