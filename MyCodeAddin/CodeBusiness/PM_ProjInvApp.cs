using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ProjInvApp))]
#if Dev
    [RunLocal]
#endif

	public class PM_ProjInvApp:ReadOnlyBase<PM_ProjInvApp>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ProjInvAppNo
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public decimal? InvAppAmt
        {
            get ;
            set ;
        }

		
        public decimal? ReceivedAmt
        {
            get ;
            set ;
        }

		
        public string InvProjTypeCode
        {
            get ;
            set ;
        }

		
        public string OtherUnit
        {
            get ;
            set ;
        }

		
        public string InvContent
        {
            get ;
            set ;
        }

		
        public string ContractNo
        {
            get ;
            set ;
        }

		
        public bool? ContractRegYN
        {
            get ;
            set ;
        }

		
        public string InvoiceApplyer
        {
            get ;
            set ;
        }

		
        public string InvoiceDrawer
        {
            get ;
            set ;
        }

		
        public string InvoiceNo
        {
            get ;
            set ;
        }

		
        public bool IsAppr
        {
            get ;
            set ;
        }

		
        public string YSWF
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

		
        public string ObjectId
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

		public static PM_ProjInvApp Create()
        {
            return EF.DataPortal.Create<PM_ProjInvApp>();
        }

		public static PM_ProjInvApp Fetch(System.Linq.Expressions.Expression<Func<PM_ProjInvApp, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjInvApp>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjInvApp>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ProjInvApps))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ProjInvApps:ReadOnlyListBase<PM_ProjInvApps,PM_ProjInvApp>
    {
        #region Factory Methods

        public static PM_ProjInvApps Fetch()
        {
            return EF.DataPortal.Fetch<PM_ProjInvApps>();
        }

		public static PM_ProjInvApps Fetch(System.Linq.Expressions.Expression<Func<PM_ProjInvApp, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjInvApp>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjInvApps>(lambda);
		}

		public static PM_ProjInvApps Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ProjInvApps>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ProjInvApps Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ProjInvApp, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ProjInvApps>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ProjInvApp>(exp,values)});
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
