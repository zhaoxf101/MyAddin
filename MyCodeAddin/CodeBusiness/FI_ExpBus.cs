using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpBus))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpBus:ReadOnlyBase<FI_ExpBus>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ExpBusCode
        {
            get ;
            set ;
        }

		
        public string ExpTypeCode
        {
            get ;
            set ;
        }

		
        public string ExpBusText
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

		
        public string WorkFlowID
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt
        {
            get ;
            set ;
        }

		
        public decimal ActAmt
        {
            get ;
            set ;
        }

		
        public decimal ActTaxAmt
        {
            get ;
            set ;
        }

		
        public int DocQty
        {
            get ;
            set ;
        }

		
        public int ActDocQty
        {
            get ;
            set ;
        }

		
        public string Description
        {
            get ;
            set ;
        }

		
        public string BarCode
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

		
        public bool IsDetails
        {
            get ;
            set ;
        }

		
        public bool IsSubmit
        {
            get ;
            set ;
        }

		
        public bool IsBatch
        {
            get ;
            set ;
        }

		
        public string ExpBusUser
        {
            get ;
            set ;
        }

		
        public string CostCtr
        {
            get ;
            set ;
        }

		
        public string ExpItemId
        {
            get ;
            set ;
        }

		
        public string ExpItemCode
        {
            get ;
            set ;
        }

		
        public string ResouItemCode
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

		
        public string RelationNo
        {
            get ;
            set ;
        }

		
        public string TransferAppNo
        {
            get ;
            set ;
        }

		
        public string ProfitCtr
        {
            get ;
            set ;
        }

		
        public System.Data.Linq.Binary TimeStamp
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

		
        public string SIncItemCode
        {
            get ;
            set ;
        }

		
        public string IncDepCode
        {
            get ;
            set ;
        }

		
        public string ContractId
        {
            get ;
            set ;
        }

		
        public string VendorCode
        {
            get ;
            set ;
        }

		
        public bool IsConfBill
        {
            get ;
            set ;
        }

		
        public string UseText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_ExpBus Create()
        {
            return EF.DataPortal.Create<FI_ExpBus>();
        }

		public static FI_ExpBus Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBus, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBus>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBus>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpBuss))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpBuss:ReadOnlyListBase<FI_ExpBuss,FI_ExpBus>
    {
        #region Factory Methods

        public static FI_ExpBuss Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpBuss>();
        }

		public static FI_ExpBuss Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBus, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBus>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBuss>(lambda);
		}

		public static FI_ExpBuss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpBuss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpBuss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpBus, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpBuss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpBus>(exp,values)});
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
