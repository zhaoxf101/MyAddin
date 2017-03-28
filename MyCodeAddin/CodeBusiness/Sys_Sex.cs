using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_Sex))]
#if Dev
    [RunLocal]
#endif

	public class Sys_Sex:ReadOnlyBase<Sys_Sex>
    {
        #region Business Methods

		
        public string SexCode
        {
            get ;
            set ;
        }

		
        public string SexName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static Sys_Sex Create()
        {
            return EF.DataPortal.Create<Sys_Sex>();
        }

		public static Sys_Sex Fetch(System.Linq.Expressions.Expression<Func<Sys_Sex, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_Sex>(exp,values);
            return EF.DataPortal.Fetch<Sys_Sex>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_Sexs))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_Sexs:ReadOnlyListBase<Sys_Sexs,Sys_Sex>
    {
        #region Factory Methods

        public static Sys_Sexs Fetch()
        {
            return EF.DataPortal.Fetch<Sys_Sexs>();
        }

		public static Sys_Sexs Fetch(System.Linq.Expressions.Expression<Func<Sys_Sex, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_Sex>(exp,values);
            return EF.DataPortal.Fetch<Sys_Sexs>(lambda);
		}

		public static Sys_Sexs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_Sexs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_Sexs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_Sex, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_Sexs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_Sex>(exp,values)});
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
