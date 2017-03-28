using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(TU_TuitionStandard))]
#if Dev
    [RunLocal]
#endif

	public class TU_TuitionStandard:ReadOnlyBase<TU_TuitionStandard>
    {
        #region Business Methods

		
        public string StudentNo
        {
            get ;
            set ;
        }

		
        public string Year
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string SpecialityCode
        {
            get ;
            set ;
        }

		
        public string ClassCode
        {
            get ;
            set ;
        }

		
        public string ReduceCode
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

		public static TU_TuitionStandard Create()
        {
            return EF.DataPortal.Create<TU_TuitionStandard>();
        }

		public static TU_TuitionStandard Fetch(System.Linq.Expressions.Expression<Func<TU_TuitionStandard, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<TU_TuitionStandard>(exp,values);
            return EF.DataPortal.Fetch<TU_TuitionStandard>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(TU_TuitionStandards))]
#if Dev
    [RunLocal]
#endif
	
	public class TU_TuitionStandards:ReadOnlyListBase<TU_TuitionStandards,TU_TuitionStandard>
    {
        #region Factory Methods

        public static TU_TuitionStandards Fetch()
        {
            return EF.DataPortal.Fetch<TU_TuitionStandards>();
        }

		public static TU_TuitionStandards Fetch(System.Linq.Expressions.Expression<Func<TU_TuitionStandard, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<TU_TuitionStandard>(exp,values);
            return EF.DataPortal.Fetch<TU_TuitionStandards>(lambda);
		}

		public static TU_TuitionStandards Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<TU_TuitionStandards>(new Paging { Page=page,RowCount=rowCount});
        }

        public static TU_TuitionStandards Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<TU_TuitionStandard, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<TU_TuitionStandards>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<TU_TuitionStandard>(exp,values)});
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
