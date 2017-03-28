using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(TU_StuTuitionSub))]
#if Dev
    [RunLocal]
#endif

	public class TU_StuTuitionSub:ReadOnlyBase<TU_StuTuitionSub>
    {
        #region Business Methods

		
        public string VoucherNo
        {
            get ;
            set ;
        }

		
        public decimal TuitionFee
        {
            get ;
            set ;
        }

		
        public decimal RentFee
        {
            get ;
            set ;
        }

		
        public decimal BookFee
        {
            get ;
            set ;
        }

		
        public decimal MedicareFee
        {
            get ;
            set ;
        }

		
        public decimal HealthCheckFee
        {
            get ;
            set ;
        }

		
        public decimal PracticeClothFee
        {
            get ;
            set ;
        }

		
        public decimal TrainClothFee
        {
            get ;
            set ;
        }

		
        public decimal DailyUseFee
        {
            get ;
            set ;
        }

		
        public decimal EngHeadphonesFee
        {
            get ;
            set ;
        }

		
        public decimal Fee0
        {
            get ;
            set ;
        }

		
        public decimal TotalAmt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static TU_StuTuitionSub Create()
        {
            return EF.DataPortal.Create<TU_StuTuitionSub>();
        }

		public static TU_StuTuitionSub Fetch(System.Linq.Expressions.Expression<Func<TU_StuTuitionSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<TU_StuTuitionSub>(exp,values);
            return EF.DataPortal.Fetch<TU_StuTuitionSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(TU_StuTuitionSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class TU_StuTuitionSubs:ReadOnlyListBase<TU_StuTuitionSubs,TU_StuTuitionSub>
    {
        #region Factory Methods

        public static TU_StuTuitionSubs Fetch()
        {
            return EF.DataPortal.Fetch<TU_StuTuitionSubs>();
        }

		public static TU_StuTuitionSubs Fetch(System.Linq.Expressions.Expression<Func<TU_StuTuitionSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<TU_StuTuitionSub>(exp,values);
            return EF.DataPortal.Fetch<TU_StuTuitionSubs>(lambda);
		}

		public static TU_StuTuitionSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<TU_StuTuitionSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static TU_StuTuitionSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<TU_StuTuitionSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<TU_StuTuitionSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<TU_StuTuitionSub>(exp,values)});
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
