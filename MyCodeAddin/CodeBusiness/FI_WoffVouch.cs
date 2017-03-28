using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_WoffVouch))]
#if Dev
    [RunLocal]
#endif

	public class FI_WoffVouch:ReadOnlyBase<FI_WoffVouch>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string WoffCode
        {
            get ;
            set ;
        }

		
        public string RowId
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

		public static FI_WoffVouch Create()
        {
            return EF.DataPortal.Create<FI_WoffVouch>();
        }

		public static FI_WoffVouch Fetch(System.Linq.Expressions.Expression<Func<FI_WoffVouch, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_WoffVouch>(exp,values);
            return EF.DataPortal.Fetch<FI_WoffVouch>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_WoffVouchs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_WoffVouchs:ReadOnlyListBase<FI_WoffVouchs,FI_WoffVouch>
    {
        #region Factory Methods

        public static FI_WoffVouchs Fetch()
        {
            return EF.DataPortal.Fetch<FI_WoffVouchs>();
        }

		public static FI_WoffVouchs Fetch(System.Linq.Expressions.Expression<Func<FI_WoffVouch, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_WoffVouch>(exp,values);
            return EF.DataPortal.Fetch<FI_WoffVouchs>(lambda);
		}

		public static FI_WoffVouchs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_WoffVouchs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_WoffVouchs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_WoffVouch, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_WoffVouchs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_WoffVouch>(exp,values)});
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
