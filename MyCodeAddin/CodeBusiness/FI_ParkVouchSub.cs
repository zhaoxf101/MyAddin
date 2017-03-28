using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ParkVouchSub))]
#if Dev
    [RunLocal]
#endif

	public class FI_ParkVouchSub:ReadOnlyBase<FI_ParkVouchSub>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AccCode
        {
            get ;
            set ;
        }

		
        public string VouchNo
        {
            get ;
            set ;
        }

		
        public string LineNR
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

		
        public string PartyCode
        {
            get ;
            set ;
        }

		
        public string AccCls
        {
            get ;
            set ;
        }

		
        public string BAccCode
        {
            get ;
            set ;
        }

		
        public string BPostKey
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

		
        public string PostKey
        {
            get ;
            set ;
        }

		
        public string GLMark
        {
            get ;
            set ;
        }

		
        public string AccType
        {
            get ;
            set ;
        }

		
        public string FundMark
        {
            get ;
            set ;
        }

		
        public string PostBus
        {
            get ;
            set ;
        }

		
        public bool GovPayX
        {
            get ;
            set ;
        }

		
        public bool DeCrX
        {
            get ;
            set ;
        }

		
        public string ItemText
        {
            get ;
            set ;
        }

		
        public bool OneTimeX
        {
            get ;
            set ;
        }

		
        public string OneTimeParty
        {
            get ;
            set ;
        }

		
        public string InvoiceNo
        {
            get ;
            set ;
        }

		
        public string TaxCode
        {
            get ;
            set ;
        }

		
        public decimal LAmt
        {
            get ;
            set ;
        }

		
        public decimal VAmt
        {
            get ;
            set ;
        }

		
        public string CurrCode
        {
            get ;
            set ;
        }

		
        public bool CashFlowX
        {
            get ;
            set ;
        }

		
        public string CashType
        {
            get ;
            set ;
        }

		
        public bool OpenItemX
        {
            get ;
            set ;
        }

		
        public string ValueDate
        {
            get ;
            set ;
        }

		
        public string DueDate
        {
            get ;
            set ;
        }

		
        public string TransactionNo
        {
            get ;
            set ;
        }

		
        public string TransactionDate
        {
            get ;
            set ;
        }

		
        public string FundCode
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

		
        public string PBudExpEcoCode
        {
            get ;
            set ;
        }

		
        public string PBudExpFunCode
        {
            get ;
            set ;
        }

		
        public string PBudExpItemCode
        {
            get ;
            set ;
        }

		
        public string FundExpTypeCode
        {
            get ;
            set ;
        }

		
        public string ExpItemRow
        {
            get ;
            set ;
        }

		
        public string ExpItemCode
        {
            get ;
            set ;
        }

		
        public string ContractId
        {
            get ;
            set ;
        }

		
        public string GovPlayCode
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string CostCtr
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

		
        public bool InvClrX
        {
            get ;
            set ;
        }

		
        public string InvNo
        {
            get ;
            set ;
        }

		
        public string InvYear
        {
            get ;
            set ;
        }

		
        public string InvPid
        {
            get ;
            set ;
        }

		
        public string InvLine
        {
            get ;
            set ;
        }

		
        public int InvDeCr
        {
            get ;
            set ;
        }

		
        public string InvRefNo
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_ParkVouchSub Create()
        {
            return EF.DataPortal.Create<FI_ParkVouchSub>();
        }

		public static FI_ParkVouchSub Fetch(System.Linq.Expressions.Expression<Func<FI_ParkVouchSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ParkVouchSub>(exp,values);
            return EF.DataPortal.Fetch<FI_ParkVouchSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ParkVouchSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ParkVouchSubs:ReadOnlyListBase<FI_ParkVouchSubs,FI_ParkVouchSub>
    {
        #region Factory Methods

        public static FI_ParkVouchSubs Fetch()
        {
            return EF.DataPortal.Fetch<FI_ParkVouchSubs>();
        }

		public static FI_ParkVouchSubs Fetch(System.Linq.Expressions.Expression<Func<FI_ParkVouchSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ParkVouchSub>(exp,values);
            return EF.DataPortal.Fetch<FI_ParkVouchSubs>(lambda);
		}

		public static FI_ParkVouchSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ParkVouchSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ParkVouchSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ParkVouchSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ParkVouchSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ParkVouchSub>(exp,values)});
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
