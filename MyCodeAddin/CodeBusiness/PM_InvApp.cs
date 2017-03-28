using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_InvApp))]
#if Dev
    [RunLocal]
#endif

	public class PM_InvApp:ReadOnlyBase<PM_InvApp>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string InvAppNo
        {
            get ;
            set ;
        }

		
        public string AppType
        {
            get ;
            set ;
        }

		
        public string BusType
        {
            get ;
            set ;
        }

		
        public string BarCode
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string LPersonId
        {
            get ;
            set ;
        }

		
        public string ContractNO
        {
            get ;
            set ;
        }

		
        public string VendorCode
        {
            get ;
            set ;
        }

		
        public string OEntity
        {
            get ;
            set ;
        }

		
        public string InvItemCode
        {
            get ;
            set ;
        }

		
        public string InvContent
        {
            get ;
            set ;
        }

		
        public decimal FDAmt
        {
            get ;
            set ;
        }

		
        public decimal UnNeedTaxAmt
        {
            get ;
            set ;
        }

		
        public decimal NeedTaxAmt
        {
            get ;
            set ;
        }

		
        public decimal TaxAmt
        {
            get ;
            set ;
        }

		
        public string TaxCode
        {
            get ;
            set ;
        }

		
        public decimal RDAppAmt
        {
            get ;
            set ;
        }

		
        public string RcvApper
        {
            get ;
            set ;
        }

		
        public string ConTel
        {
            get ;
            set ;
        }

		
        public string ConPhone
        {
            get ;
            set ;
        }

		
        public string ProfitCtr
        {
            get ;
            set ;
        }

		
        public string IncDetCode
        {
            get ;
            set ;
        }

		
        public bool IsProjInv
        {
            get ;
            set ;
        }

		
        public bool IsAppr
        {
            get ;
            set ;
        }

		
        public bool IsChk
        {
            get ;
            set ;
        }

		
        public bool Cancelled
        {
            get ;
            set ;
        }

		
        public bool Approved
        {
            get ;
            set ;
        }

		
        public bool IsReAppr
        {
            get ;
            set ;
        }

		
        public bool IsReCHK
        {
            get ;
            set ;
        }

		
        public bool ReApproved
        {
            get ;
            set ;
        }

		
        public bool ReCancelled
        {
            get ;
            set ;
        }

		
        public string InvNo
        {
            get ;
            set ;
        }

		
        public string Memo
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

		
        public bool ReGenVouX
        {
            get ;
            set ;
        }

		
        public string VouchNo
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

		
        public string CheckedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CheckedDate
        {
            get ;
            set ;
        }

		
        public string FICheckedUser
        {
            get ;
            set ;
        }

		
        public DateTime? FICheckedDate
        {
            get ;
            set ;
        }

		
        public string ReCreatedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ReCreatedDate
        {
            get ;
            set ;
        }

		
        public string ReCheckedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ReCheckedDate
        {
            get ;
            set ;
        }

		
        public string ReFICheckedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ReFICheckedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_InvApp Create()
        {
            return EF.DataPortal.Create<PM_InvApp>();
        }

		public static PM_InvApp Fetch(System.Linq.Expressions.Expression<Func<PM_InvApp, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_InvApp>(exp,values);
            return EF.DataPortal.Fetch<PM_InvApp>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_InvApps))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_InvApps:ReadOnlyListBase<PM_InvApps,PM_InvApp>
    {
        #region Factory Methods

        public static PM_InvApps Fetch()
        {
            return EF.DataPortal.Fetch<PM_InvApps>();
        }

		public static PM_InvApps Fetch(System.Linq.Expressions.Expression<Func<PM_InvApp, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_InvApp>(exp,values);
            return EF.DataPortal.Fetch<PM_InvApps>(lambda);
		}

		public static PM_InvApps Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_InvApps>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_InvApps Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_InvApp, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_InvApps>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_InvApp>(exp,values)});
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
