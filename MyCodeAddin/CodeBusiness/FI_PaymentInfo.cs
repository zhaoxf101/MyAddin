using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PaymentInfo))]
#if Dev
    [RunLocal]
#endif

	public class FI_PaymentInfo:ReadOnlyBase<FI_PaymentInfo>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ObjType
        {
            get ;
            set ;
        }

		
        public string ItemId
        {
            get ;
            set ;
        }

		
        public string BankCode
        {
            get ;
            set ;
        }

		
        public string PayType
        {
            get ;
            set ;
        }

		
        public string PesonId
        {
            get ;
            set ;
        }

		
        public bool IsExpBus
        {
            get ;
            set ;
        }

		
        public string UserName
        {
            get ;
            set ;
        }

		
        public string BankName
        {
            get ;
            set ;
        }

		
        public string UnitedBankId
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public decimal ActAmt
        {
            get ;
            set ;
        }

		
        public decimal ActTaxAmt
        {
            get ;
            set ;
        }

		
        public string PayText
        {
            get ;
            set ;
        }

		
        public int RowId
        {
            get ;
            set ;
        }

		
        public decimal PaymentAmt
        {
            get ;
            set ;
        }

		
        public bool IsPublic
        {
            get ;
            set ;
        }

		
        public bool IsOffCard
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_PaymentInfo Create()
        {
            return EF.DataPortal.Create<FI_PaymentInfo>();
        }

		public static FI_PaymentInfo Fetch(System.Linq.Expressions.Expression<Func<FI_PaymentInfo, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PaymentInfo>(exp,values);
            return EF.DataPortal.Fetch<FI_PaymentInfo>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PaymentInfos))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PaymentInfos:ReadOnlyListBase<FI_PaymentInfos,FI_PaymentInfo>
    {
        #region Factory Methods

        public static FI_PaymentInfos Fetch()
        {
            return EF.DataPortal.Fetch<FI_PaymentInfos>();
        }

		public static FI_PaymentInfos Fetch(System.Linq.Expressions.Expression<Func<FI_PaymentInfo, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PaymentInfo>(exp,values);
            return EF.DataPortal.Fetch<FI_PaymentInfos>(lambda);
		}

		public static FI_PaymentInfos Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PaymentInfos>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PaymentInfos Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PaymentInfo, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PaymentInfos>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PaymentInfo>(exp,values)});
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
