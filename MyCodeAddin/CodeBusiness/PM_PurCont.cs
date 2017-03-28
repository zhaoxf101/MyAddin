using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_PurCont))]
#if Dev
    [RunLocal]
#endif

	public class PM_PurCont:ReadOnlyBase<PM_PurCont>
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

		
        public bool IsPayTerms
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

		
        public bool IsCheck
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

		
        public decimal AdjAmt
        {
            get ;
            set ;
        }

		
        public decimal FinalAmt
        {
            get ;
            set ;
        }

		
        public decimal ControlAmt
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt
        {
            get ;
            set ;
        }

		
        public decimal LoanAmt
        {
            get ;
            set ;
        }

		
        public decimal WoffAmt
        {
            get ;
            set ;
        }

		
        public decimal OrdAmt
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

		
        public string BankDep
        {
            get ;
            set ;
        }

		
        public string BankInstitutions
        {
            get ;
            set ;
        }

		
        public string BankCode
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

		
        public bool? IsPBuy
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_PurCont Create()
        {
            return EF.DataPortal.Create<PM_PurCont>();
        }

		public static PM_PurCont Fetch(System.Linq.Expressions.Expression<Func<PM_PurCont, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_PurCont>(exp,values);
            return EF.DataPortal.Fetch<PM_PurCont>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_PurConts))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_PurConts:ReadOnlyListBase<PM_PurConts,PM_PurCont>
    {
        #region Factory Methods

        public static PM_PurConts Fetch()
        {
            return EF.DataPortal.Fetch<PM_PurConts>();
        }

		public static PM_PurConts Fetch(System.Linq.Expressions.Expression<Func<PM_PurCont, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_PurCont>(exp,values);
            return EF.DataPortal.Fetch<PM_PurConts>(lambda);
		}

		public static PM_PurConts Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_PurConts>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_PurConts Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_PurCont, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_PurConts>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_PurCont>(exp,values)});
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
