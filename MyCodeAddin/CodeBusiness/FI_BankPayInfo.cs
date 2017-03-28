using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_BankPayInfo))]
#if Dev
    [RunLocal]
#endif

	public class FI_BankPayInfo:ReadOnlyBase<FI_BankPayInfo>
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

		
        public string RBankCode
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

		
        public string RemType
        {
            get ;
            set ;
        }

		
        public int RowId
        {
            get ;
            set ;
        }

		
        public string GovPayCode
        {
            get ;
            set ;
        }

		
        public string PersonName
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public bool IsProxy
        {
            get ;
            set ;
        }

		
        public bool IsConfig
        {
            get ;
            set ;
        }

		
        public string PBankCode
        {
            get ;
            set ;
        }

		
        public string PBankId
        {
            get ;
            set ;
        }

		
        public string PUnitedBankId
        {
            get ;
            set ;
        }

		
        public string PAccCode
        {
            get ;
            set ;
        }

		
        public string BAccCode
        {
            get ;
            set ;
        }

		
        public string ProxyId
        {
            get ;
            set ;
        }

		
        public string ProxyCode
        {
            get ;
            set ;
        }

		
        public string AUnitedBankId
        {
            get ;
            set ;
        }

		
        public string RUnitedBankId
        {
            get ;
            set ;
        }

		
        public string RBankName
        {
            get ;
            set ;
        }

		
        public bool IsPublic
        {
            get ;
            set ;
        }

		
        public bool CanProxy
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

		public static FI_BankPayInfo Create()
        {
            return EF.DataPortal.Create<FI_BankPayInfo>();
        }

		public static FI_BankPayInfo Fetch(System.Linq.Expressions.Expression<Func<FI_BankPayInfo, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_BankPayInfo>(exp,values);
            return EF.DataPortal.Fetch<FI_BankPayInfo>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_BankPayInfos))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_BankPayInfos:ReadOnlyListBase<FI_BankPayInfos,FI_BankPayInfo>
    {
        #region Factory Methods

        public static FI_BankPayInfos Fetch()
        {
            return EF.DataPortal.Fetch<FI_BankPayInfos>();
        }

		public static FI_BankPayInfos Fetch(System.Linq.Expressions.Expression<Func<FI_BankPayInfo, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_BankPayInfo>(exp,values);
            return EF.DataPortal.Fetch<FI_BankPayInfos>(lambda);
		}

		public static FI_BankPayInfos Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_BankPayInfos>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_BankPayInfos Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_BankPayInfo, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_BankPayInfos>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_BankPayInfo>(exp,values)});
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
