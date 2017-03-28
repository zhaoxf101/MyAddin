using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_Voucher))]
#if Dev
    [RunLocal]
#endif

	public class FI_Voucher:ReadOnlyBase<FI_Voucher>
    {
        #region Business Methods

		
        public string Client
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

		
        public string VouType
        {
            get ;
            set ;
        }

		
        public string BusType
        {
            get ;
            set ;
        }

		
        public string VouDate
        {
            get ;
            set ;
        }

		
        public string PostDate
        {
            get ;
            set ;
        }

		
        public string ReferenceNo
        {
            get ;
            set ;
        }

		
        public string RelatedInvBusNo
        {
            get ;
            set ;
        }

		
        public string VouText
        {
            get ;
            set ;
        }

		
        public string CurrCode
        {
            get ;
            set ;
        }

		
        public decimal ExchRate
        {
            get ;
            set ;
        }

		
        public string BarCode
        {
            get ;
            set ;
        }

		
        public string Businesser
        {
            get ;
            set ;
        }

		
        public int BillQty
        {
            get ;
            set ;
        }

		
        public string VouCls
        {
            get ;
            set ;
        }

		
        public string OffsetNo
        {
            get ;
            set ;
        }

		
        public string OffsetYear
        {
            get ;
            set ;
        }

		
        public string OffsetPid
        {
            get ;
            set ;
        }

		
        public string OffSetMark
        {
            get ;
            set ;
        }

		
        public string ParkVouNo
        {
            get ;
            set ;
        }

		
        public bool ChiefPayX
        {
            get ;
            set ;
        }

		
        public bool GovPayX
        {
            get ;
            set ;
        }

		
        public bool CashPayX
        {
            get ;
            set ;
        }

		
        public bool PayMsgX
        {
            get ;
            set ;
        }

		
        public bool ProxyPayX
        {
            get ;
            set ;
        }

		
        public bool ParkCkX
        {
            get ;
            set ;
        }

		
        public bool ChiefCkX
        {
            get ;
            set ;
        }

		
        public bool GovCkX
        {
            get ;
            set ;
        }

		
        public bool CashCkX
        {
            get ;
            set ;
        }

		
        public bool ProxyCkX
        {
            get ;
            set ;
        }

		
        public string ParkUser
        {
            get ;
            set ;
        }

		
        public string ChiefUser
        {
            get ;
            set ;
        }

		
        public string GovUser
        {
            get ;
            set ;
        }

		
        public string CashUser
        {
            get ;
            set ;
        }

		
        public string PostUser
        {
            get ;
            set ;
        }

		
        public string ProxyUser
        {
            get ;
            set ;
        }

		
        public bool AutoVouch
        {
            get ;
            set ;
        }

		
        public string CreatedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public string ChangedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_Voucher Create()
        {
            return EF.DataPortal.Create<FI_Voucher>();
        }

		public static FI_Voucher Fetch(System.Linq.Expressions.Expression<Func<FI_Voucher, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_Voucher>(exp,values);
            return EF.DataPortal.Fetch<FI_Voucher>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_Vouchers))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_Vouchers:ReadOnlyListBase<FI_Vouchers,FI_Voucher>
    {
        #region Factory Methods

        public static FI_Vouchers Fetch()
        {
            return EF.DataPortal.Fetch<FI_Vouchers>();
        }

		public static FI_Vouchers Fetch(System.Linq.Expressions.Expression<Func<FI_Voucher, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_Voucher>(exp,values);
            return EF.DataPortal.Fetch<FI_Vouchers>(lambda);
		}

		public static FI_Vouchers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_Vouchers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_Vouchers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_Voucher, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_Vouchers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_Voucher>(exp,values)});
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
