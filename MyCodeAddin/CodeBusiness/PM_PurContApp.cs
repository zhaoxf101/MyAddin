using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_PurContApp))]
#if Dev
    [RunLocal]
#endif

	public class PM_PurContApp:ReadOnlyBase<PM_PurContApp>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ContractId
        {
            get ;
            set ;
        }

		
        public int SignNo
        {
            get ;
            set ;
        }

		
        public string PurContAppBusCode
        {
            get ;
            set ;
        }

		
        public string BidNo
        {
            get ;
            set ;
        }

		
        public string ContName
        {
            get ;
            set ;
        }

		
        public string PurContent
        {
            get ;
            set ;
        }

		
        public string OContractId
        {
            get ;
            set ;
        }

		
        public string PurContTypeCode
        {
            get ;
            set ;
        }

		
        public string PurTypeCode
        {
            get ;
            set ;
        }

		
        public string PurActCode
        {
            get ;
            set ;
        }

		
        public bool IsAss
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string TaskCode
        {
            get ;
            set ;
        }

		
        public string VendorCode
        {
            get ;
            set ;
        }

		
        public DateTime? SignDate
        {
            get ;
            set ;
        }

		
        public DateTime? EffectDate
        {
            get ;
            set ;
        }

		
        public DateTime? EndDate
        {
            get ;
            set ;
        }

		
        public decimal PlanAmt
        {
            get ;
            set ;
        }

		
        public decimal ContAmt
        {
            get ;
            set ;
        }

		
        public decimal FinalAmt
        {
            get ;
            set ;
        }

		
        public decimal PerfAmt
        {
            get ;
            set ;
        }

		
        public decimal GuaranteeMoney
        {
            get ;
            set ;
        }

		
        public decimal MaxExpRate
        {
            get ;
            set ;
        }

		
        public bool IsPayTerms
        {
            get ;
            set ;
        }

		
        public string BankInstitutions
        {
            get ;
            set ;
        }

		
        public string UnitedBankId
        {
            get ;
            set ;
        }

		
        public bool IsToPub
        {
            get ;
            set ;
        }

		
        public string BankCode
        {
            get ;
            set ;
        }

		
        public string BankDep
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public string Operator
        {
            get ;
            set ;
        }

		
        public bool IsCreate
        {
            get ;
            set ;
        }

		
        public bool IsAppr
        {
            get ;
            set ;
        }

		
        public bool IsCheck
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

		
        public string WorkflowId
        {
            get ;
            set ;
        }

		
        public bool Active
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

		public static PM_PurContApp Create()
        {
            return EF.DataPortal.Create<PM_PurContApp>();
        }

		public static PM_PurContApp Fetch(System.Linq.Expressions.Expression<Func<PM_PurContApp, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_PurContApp>(exp,values);
            return EF.DataPortal.Fetch<PM_PurContApp>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_PurContApps))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_PurContApps:ReadOnlyListBase<PM_PurContApps,PM_PurContApp>
    {
        #region Factory Methods

        public static PM_PurContApps Fetch()
        {
            return EF.DataPortal.Fetch<PM_PurContApps>();
        }

		public static PM_PurContApps Fetch(System.Linq.Expressions.Expression<Func<PM_PurContApp, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_PurContApp>(exp,values);
            return EF.DataPortal.Fetch<PM_PurContApps>(lambda);
		}

		public static PM_PurContApps Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_PurContApps>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_PurContApps Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_PurContApp, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_PurContApps>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_PurContApp>(exp,values)});
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
