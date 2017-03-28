using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CO_Voucher))]
#if Dev
    [RunLocal]
#endif

	public class CO_Voucher:ReadOnlyBase<CO_Voucher>
    {
        #region Business Methods

		
        public string CostArea
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

		
        public string RefCLT
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

		public static CO_Voucher Create()
        {
            return EF.DataPortal.Create<CO_Voucher>();
        }

		public static CO_Voucher Fetch(System.Linq.Expressions.Expression<Func<CO_Voucher, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CO_Voucher>(exp,values);
            return EF.DataPortal.Fetch<CO_Voucher>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CO_Vouchers))]
#if Dev
    [RunLocal]
#endif
	
	public class CO_Vouchers:ReadOnlyListBase<CO_Vouchers,CO_Voucher>
    {
        #region Factory Methods

        public static CO_Vouchers Fetch()
        {
            return EF.DataPortal.Fetch<CO_Vouchers>();
        }

		public static CO_Vouchers Fetch(System.Linq.Expressions.Expression<Func<CO_Voucher, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CO_Voucher>(exp,values);
            return EF.DataPortal.Fetch<CO_Vouchers>(lambda);
		}

		public static CO_Vouchers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CO_Vouchers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CO_Vouchers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CO_Voucher, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CO_Vouchers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CO_Voucher>(exp,values)});
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
