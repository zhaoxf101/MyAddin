using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(MM_MatPlant))]
#if Dev
    [RunLocal]
#endif

	public class MM_MatPlant:ReadOnlyBase<MM_MatPlant>
    {
        #region Business Methods

		
        public string MaterialCode
        {
            get ;
            set ;
        }

		
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

		
        public bool? IsDel
        {
            get ;
            set ;
        }

		
        public string MatABC
        {
            get ;
            set ;
        }

		
        public bool? XKeyPart
        {
            get ;
            set ;
        }

		
        public string PurGrp
        {
            get ;
            set ;
        }

		
        public string AUSME
        {
            get ;
            set ;
        }

		
        public bool? INSMK
        {
            get ;
            set ;
        }

		
        public decimal? LowBalance
        {
            get ;
            set ;
        }

		
        public bool? NCOST
        {
            get ;
            set ;
        }

		
        public string ROTATION_DATE
        {
            get ;
            set ;
        }

		
        public string UCHKZ
        {
            get ;
            set ;
        }

		
        public string UCMAT
        {
            get ;
            set ;
        }

		
        public decimal? TARGET_STOCK
        {
            get ;
            set ;
        }

		
        public decimal? StandPrice
        {
            get ;
            set ;
        }

		
        public string PEINH
        {
            get ;
            set ;
        }

		
        public string BKLAS
        {
            get ;
            set ;
        }

		
        public string CreatedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public string ChangedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static MM_MatPlant Create()
        {
            return EF.DataPortal.Create<MM_MatPlant>();
        }

		public static MM_MatPlant Fetch(System.Linq.Expressions.Expression<Func<MM_MatPlant, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<MM_MatPlant>(exp,values);
            return EF.DataPortal.Fetch<MM_MatPlant>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(MM_MatPlants))]
#if Dev
    [RunLocal]
#endif
	
	public class MM_MatPlants:ReadOnlyListBase<MM_MatPlants,MM_MatPlant>
    {
        #region Factory Methods

        public static MM_MatPlants Fetch()
        {
            return EF.DataPortal.Fetch<MM_MatPlants>();
        }

		public static MM_MatPlants Fetch(System.Linq.Expressions.Expression<Func<MM_MatPlant, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<MM_MatPlant>(exp,values);
            return EF.DataPortal.Fetch<MM_MatPlants>(lambda);
		}

		public static MM_MatPlants Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<MM_MatPlants>(new Paging { Page=page,RowCount=rowCount});
        }

        public static MM_MatPlants Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<MM_MatPlant, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<MM_MatPlants>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<MM_MatPlant>(exp,values)});
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
