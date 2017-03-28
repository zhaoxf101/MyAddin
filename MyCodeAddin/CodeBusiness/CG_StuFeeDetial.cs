using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CG_StuFeeDetial))]
#if Dev
    [RunLocal]
#endif

	public class CG_StuFeeDetial:ReadOnlyBase<CG_StuFeeDetial>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public Guid Id
        {
            get ;
            set ;
        }

		
        public string FeeItemCode
        {
            get ;
            set ;
        }

		
        public string IntervalCode
        {
            get ;
            set ;
        }

		
        public string StudentNo
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public decimal CAmt
        {
            get ;
            set ;
        }

		
        public decimal AdjAmt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static CG_StuFeeDetial Create()
        {
            return EF.DataPortal.Create<CG_StuFeeDetial>();
        }

		public static CG_StuFeeDetial Fetch(System.Linq.Expressions.Expression<Func<CG_StuFeeDetial, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CG_StuFeeDetial>(exp,values);
            return EF.DataPortal.Fetch<CG_StuFeeDetial>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CG_StuFeeDetials))]
#if Dev
    [RunLocal]
#endif
	
	public class CG_StuFeeDetials:ReadOnlyListBase<CG_StuFeeDetials,CG_StuFeeDetial>
    {
        #region Factory Methods

        public static CG_StuFeeDetials Fetch()
        {
            return EF.DataPortal.Fetch<CG_StuFeeDetials>();
        }

		public static CG_StuFeeDetials Fetch(System.Linq.Expressions.Expression<Func<CG_StuFeeDetial, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CG_StuFeeDetial>(exp,values);
            return EF.DataPortal.Fetch<CG_StuFeeDetials>(lambda);
		}

		public static CG_StuFeeDetials Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CG_StuFeeDetials>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CG_StuFeeDetials Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CG_StuFeeDetial, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CG_StuFeeDetials>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CG_StuFeeDetial>(exp,values)});
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
