using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PayBack))]
#if Dev
    [RunLocal]
#endif

	public class FI_PayBack:ReadOnlyBase<FI_PayBack>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string PayBackNo
        {
            get ;
            set ;
        }

		
        public string PayBankText
        {
            get ;
            set ;
        }

		
        public string BusType
        {
            get ;
            set ;
        }

		
        public string AccType
        {
            get ;
            set ;
        }

		
        public string PayBackType
        {
            get ;
            set ;
        }

		
        public string GLMarK
        {
            get ;
            set ;
        }

		
        public string PartyCode
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public bool RelPartyX
        {
            get ;
            set ;
        }

		
        public bool IsSubmit
        {
            get ;
            set ;
        }

		
        public bool Approved
        {
            get ;
            set ;
        }

		
        public string AccDateTime
        {
            get ;
            set ;
        }

		
        public bool GenVouX
        {
            get ;
            set ;
        }

		
        public string OpenVouchNo
        {
            get ;
            set ;
        }

		
        public string VouchText
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

		
        public string CheckUser
        {
            get ;
            set ;
        }

		
        public DateTime? CheckDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_PayBack Create()
        {
            return EF.DataPortal.Create<FI_PayBack>();
        }

		public static FI_PayBack Fetch(System.Linq.Expressions.Expression<Func<FI_PayBack, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PayBack>(exp,values);
            return EF.DataPortal.Fetch<FI_PayBack>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PayBacks))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PayBacks:ReadOnlyListBase<FI_PayBacks,FI_PayBack>
    {
        #region Factory Methods

        public static FI_PayBacks Fetch()
        {
            return EF.DataPortal.Fetch<FI_PayBacks>();
        }

		public static FI_PayBacks Fetch(System.Linq.Expressions.Expression<Func<FI_PayBack, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PayBack>(exp,values);
            return EF.DataPortal.Fetch<FI_PayBacks>(lambda);
		}

		public static FI_PayBacks Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PayBacks>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PayBacks Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PayBack, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PayBacks>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PayBack>(exp,values)});
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
