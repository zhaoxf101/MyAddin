using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(MM_Warehouse))]
#if Dev
    [RunLocal]
#endif

	public class MM_Warehouse:ReadOnlyBase<MM_Warehouse>
    {
        #region Business Methods

		
        public string Plant
        {
            get ;
            set ;
        }

		
        public string Warehouse
        {
            get ;
            set ;
        }

		
        public string LText
        {
            get ;
            set ;
        }

		
        public bool? CanNegative
        {
            get ;
            set ;
        }

		
        public bool? CanMRP
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static MM_Warehouse Create()
        {
            return EF.DataPortal.Create<MM_Warehouse>();
        }

		public static MM_Warehouse Fetch(System.Linq.Expressions.Expression<Func<MM_Warehouse, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<MM_Warehouse>(exp,values);
            return EF.DataPortal.Fetch<MM_Warehouse>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(MM_Warehouses))]
#if Dev
    [RunLocal]
#endif
	
	public class MM_Warehouses:ReadOnlyListBase<MM_Warehouses,MM_Warehouse>
    {
        #region Factory Methods

        public static MM_Warehouses Fetch()
        {
            return EF.DataPortal.Fetch<MM_Warehouses>();
        }

		public static MM_Warehouses Fetch(System.Linq.Expressions.Expression<Func<MM_Warehouse, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<MM_Warehouse>(exp,values);
            return EF.DataPortal.Fetch<MM_Warehouses>(lambda);
		}

		public static MM_Warehouses Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<MM_Warehouses>(new Paging { Page=page,RowCount=rowCount});
        }

        public static MM_Warehouses Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<MM_Warehouse, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<MM_Warehouses>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<MM_Warehouse>(exp,values)});
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
