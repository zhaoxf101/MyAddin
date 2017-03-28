using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_Voucher))]
#if Dev
    [RunLocal]
#endif

	public class PM_Voucher:ReadOnlyBase<PM_Voucher>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AccYear
        {
            get ;
            set ;
        }

		
        public string VouchNo
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

		
        public string ReferenceNo
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

		
        public string OffSetMark
        {
            get ;
            set ;
        }

		
        public string RefNo
        {
            get ;
            set ;
        }

		
        public string RefYear
        {
            get ;
            set ;
        }

		
        public string RefPid
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

		
		#endregion

		#region Factory Methods

		public static PM_Voucher Create()
        {
            return EF.DataPortal.Create<PM_Voucher>();
        }

		public static PM_Voucher Fetch(System.Linq.Expressions.Expression<Func<PM_Voucher, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_Voucher>(exp,values);
            return EF.DataPortal.Fetch<PM_Voucher>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_Vouchers))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_Vouchers:ReadOnlyListBase<PM_Vouchers,PM_Voucher>
    {
        #region Factory Methods

        public static PM_Vouchers Fetch()
        {
            return EF.DataPortal.Fetch<PM_Vouchers>();
        }

		public static PM_Vouchers Fetch(System.Linq.Expressions.Expression<Func<PM_Voucher, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_Voucher>(exp,values);
            return EF.DataPortal.Fetch<PM_Vouchers>(lambda);
		}

		public static PM_Vouchers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_Vouchers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_Vouchers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_Voucher, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_Vouchers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_Voucher>(exp,values)});
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
