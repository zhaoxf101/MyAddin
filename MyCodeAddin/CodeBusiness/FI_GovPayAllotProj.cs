using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_GovPayAllotProj))]
#if Dev
    [RunLocal]
#endif

	public class FI_GovPayAllotProj:ReadOnlyBase<FI_GovPayAllotProj>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string GovAllotNo
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string TaskCode
        {
            get ;
            set ;
        }

		
        public string FundCode
        {
            get ;
            set ;
        }

		
        public string ProfitCtr
        {
            get ;
            set ;
        }

		
        public string Description
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public bool IsDis
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_GovPayAllotProj Create()
        {
            return EF.DataPortal.Create<FI_GovPayAllotProj>();
        }

		public static FI_GovPayAllotProj Fetch(System.Linq.Expressions.Expression<Func<FI_GovPayAllotProj, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_GovPayAllotProj>(exp,values);
            return EF.DataPortal.Fetch<FI_GovPayAllotProj>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_GovPayAllotProjs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_GovPayAllotProjs:ReadOnlyListBase<FI_GovPayAllotProjs,FI_GovPayAllotProj>
    {
        #region Factory Methods

        public static FI_GovPayAllotProjs Fetch()
        {
            return EF.DataPortal.Fetch<FI_GovPayAllotProjs>();
        }

		public static FI_GovPayAllotProjs Fetch(System.Linq.Expressions.Expression<Func<FI_GovPayAllotProj, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_GovPayAllotProj>(exp,values);
            return EF.DataPortal.Fetch<FI_GovPayAllotProjs>(lambda);
		}

		public static FI_GovPayAllotProjs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_GovPayAllotProjs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_GovPayAllotProjs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_GovPayAllotProj, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_GovPayAllotProjs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_GovPayAllotProj>(exp,values)});
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
