using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_Area))]
#if Dev
    [RunLocal]
#endif

	public class Sys_Area:ReadOnlyBase<Sys_Area>
    {
        #region Business Methods

		
        public string AreaId
        {
            get ;
            set ;
        }

		
        public string AreaCode
        {
            get ;
            set ;
        }

		
        public string AreaName
        {
            get ;
            set ;
        }

		
        public string ProvinceCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static Sys_Area Create()
        {
            return EF.DataPortal.Create<Sys_Area>();
        }

		public static Sys_Area Fetch(System.Linq.Expressions.Expression<Func<Sys_Area, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_Area>(exp,values);
            return EF.DataPortal.Fetch<Sys_Area>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_Areas))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_Areas:ReadOnlyListBase<Sys_Areas,Sys_Area>
    {
        #region Factory Methods

        public static Sys_Areas Fetch()
        {
            return EF.DataPortal.Fetch<Sys_Areas>();
        }

		public static Sys_Areas Fetch(System.Linq.Expressions.Expression<Func<Sys_Area, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_Area>(exp,values);
            return EF.DataPortal.Fetch<Sys_Areas>(lambda);
		}

		public static Sys_Areas Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_Areas>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_Areas Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_Area, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_Areas>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_Area>(exp,values)});
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
