using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_TaxAdjVouch))]
#if Dev
    [RunLocal]
#endif

	public class FI_TaxAdjVouch:ReadOnlyBase<FI_TaxAdjVouch>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string TaxAdjCode
        {
            get ;
            set ;
        }

		
        public string VouchNo
        {
            get ;
            set ;
        }

		
        public string AccYear
        {
            get ;
            set ;
        }

		
        public string AccPid
        {
            get ;
            set ;
        }

		
        public string LineNR
        {
            get ;
            set ;
        }

		
        public string VendorCode
        {
            get ;
            set ;
        }

		
        public string ItemText
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_TaxAdjVouch Create()
        {
            return EF.DataPortal.Create<FI_TaxAdjVouch>();
        }

		public static FI_TaxAdjVouch Fetch(System.Linq.Expressions.Expression<Func<FI_TaxAdjVouch, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_TaxAdjVouch>(exp,values);
            return EF.DataPortal.Fetch<FI_TaxAdjVouch>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_TaxAdjVouchs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_TaxAdjVouchs:ReadOnlyListBase<FI_TaxAdjVouchs,FI_TaxAdjVouch>
    {
        #region Factory Methods

        public static FI_TaxAdjVouchs Fetch()
        {
            return EF.DataPortal.Fetch<FI_TaxAdjVouchs>();
        }

		public static FI_TaxAdjVouchs Fetch(System.Linq.Expressions.Expression<Func<FI_TaxAdjVouch, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_TaxAdjVouch>(exp,values);
            return EF.DataPortal.Fetch<FI_TaxAdjVouchs>(lambda);
		}

		public static FI_TaxAdjVouchs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_TaxAdjVouchs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_TaxAdjVouchs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_TaxAdjVouch, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_TaxAdjVouchs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_TaxAdjVouch>(exp,values)});
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
