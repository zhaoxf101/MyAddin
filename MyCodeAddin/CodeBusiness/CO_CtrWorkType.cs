using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CO_CtrWorkType))]
#if Dev
    [RunLocal]
#endif

	public class CO_CtrWorkType:ReadOnlyBase<CO_CtrWorkType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string WorkType
        {
            get ;
            set ;
        }

		
        public string AccYear
        {
            get ;
            set ;
        }

		
        public string PERID
        {
            get ;
            set ;
        }

		
        public string CostCtr
        {
            get ;
            set ;
        }

		
        public string UnitCode
        {
            get ;
            set ;
        }

		
        public decimal? LST
        {
            get ;
            set ;
        }

		
        public decimal? KAP
        {
            get ;
            set ;
        }

		
        public decimal? TKF
        {
            get ;
            set ;
        }

		
        public decimal? TKV
        {
            get ;
            set ;
        }

		
        public decimal? AEQ
        {
            get ;
            set ;
        }

		
        public string CostElem
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static CO_CtrWorkType Create()
        {
            return EF.DataPortal.Create<CO_CtrWorkType>();
        }

		public static CO_CtrWorkType Fetch(System.Linq.Expressions.Expression<Func<CO_CtrWorkType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CO_CtrWorkType>(exp,values);
            return EF.DataPortal.Fetch<CO_CtrWorkType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CO_CtrWorkTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class CO_CtrWorkTypes:ReadOnlyListBase<CO_CtrWorkTypes,CO_CtrWorkType>
    {
        #region Factory Methods

        public static CO_CtrWorkTypes Fetch()
        {
            return EF.DataPortal.Fetch<CO_CtrWorkTypes>();
        }

		public static CO_CtrWorkTypes Fetch(System.Linq.Expressions.Expression<Func<CO_CtrWorkType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CO_CtrWorkType>(exp,values);
            return EF.DataPortal.Fetch<CO_CtrWorkTypes>(lambda);
		}

		public static CO_CtrWorkTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CO_CtrWorkTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CO_CtrWorkTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CO_CtrWorkType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CO_CtrWorkTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CO_CtrWorkType>(exp,values)});
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
