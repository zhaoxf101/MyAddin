using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_GovPayAllotVouch))]
#if Dev
    [RunLocal]
#endif

	public class FI_GovPayAllotVouch:ReadOnlyBase<FI_GovPayAllotVouch>
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

		
        public string GovPlayCode
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

		public static FI_GovPayAllotVouch Create()
        {
            return EF.DataPortal.Create<FI_GovPayAllotVouch>();
        }

		public static FI_GovPayAllotVouch Fetch(System.Linq.Expressions.Expression<Func<FI_GovPayAllotVouch, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_GovPayAllotVouch>(exp,values);
            return EF.DataPortal.Fetch<FI_GovPayAllotVouch>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_GovPayAllotVouchs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_GovPayAllotVouchs:ReadOnlyListBase<FI_GovPayAllotVouchs,FI_GovPayAllotVouch>
    {
        #region Factory Methods

        public static FI_GovPayAllotVouchs Fetch()
        {
            return EF.DataPortal.Fetch<FI_GovPayAllotVouchs>();
        }

		public static FI_GovPayAllotVouchs Fetch(System.Linq.Expressions.Expression<Func<FI_GovPayAllotVouch, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_GovPayAllotVouch>(exp,values);
            return EF.DataPortal.Fetch<FI_GovPayAllotVouchs>(lambda);
		}

		public static FI_GovPayAllotVouchs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_GovPayAllotVouchs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_GovPayAllotVouchs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_GovPayAllotVouch, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_GovPayAllotVouchs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_GovPayAllotVouch>(exp,values)});
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
