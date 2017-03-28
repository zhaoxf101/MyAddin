using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(TU_StuTuition))]
#if Dev
    [RunLocal]
#endif

	public class TU_StuTuition:ReadOnlyBase<TU_StuTuition>
    {
        #region Business Methods

		
        public string StudentNo
        {
            get ;
            set ;
        }

		
        public string VoucherNo
        {
            get ;
            set ;
        }

		
        public string ReceiptNo
        {
            get ;
            set ;
        }

		
        public string RecTypeCode
        {
            get ;
            set ;
        }

		
        public string Operator
        {
            get ;
            set ;
        }

		
        public DateTime? ChargeDate
        {
            get ;
            set ;
        }

		
        public string Maker
        {
            get ;
            set ;
        }

		
        public DateTime? MakeDate
        {
            get ;
            set ;
        }

		
        public bool? IsPrint
        {
            get ;
            set ;
        }

		
        public decimal? TotalAmt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static TU_StuTuition Create()
        {
            return EF.DataPortal.Create<TU_StuTuition>();
        }

		public static TU_StuTuition Fetch(System.Linq.Expressions.Expression<Func<TU_StuTuition, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<TU_StuTuition>(exp,values);
            return EF.DataPortal.Fetch<TU_StuTuition>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(TU_StuTuitions))]
#if Dev
    [RunLocal]
#endif
	
	public class TU_StuTuitions:ReadOnlyListBase<TU_StuTuitions,TU_StuTuition>
    {
        #region Factory Methods

        public static TU_StuTuitions Fetch()
        {
            return EF.DataPortal.Fetch<TU_StuTuitions>();
        }

		public static TU_StuTuitions Fetch(System.Linq.Expressions.Expression<Func<TU_StuTuition, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<TU_StuTuition>(exp,values);
            return EF.DataPortal.Fetch<TU_StuTuitions>(lambda);
		}

		public static TU_StuTuitions Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<TU_StuTuitions>(new Paging { Page=page,RowCount=rowCount});
        }

        public static TU_StuTuitions Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<TU_StuTuition, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<TU_StuTuitions>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<TU_StuTuition>(exp,values)});
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
