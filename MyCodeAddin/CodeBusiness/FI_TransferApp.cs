using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_TransferApp))]
#if Dev
    [RunLocal]
#endif

	public class FI_TransferApp:ReadOnlyBase<FI_TransferApp>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string TransferAppNo
        {
            get ;
            set ;
        }

		
        public string TransferAppText
        {
            get ;
            set ;
        }

		
        public string TransferTypeCode
        {
            get ;
            set ;
        }

		
        public string ProfitCtr
        {
            get ;
            set ;
        }

		
        public string InvItemCode
        {
            get ;
            set ;
        }

		
        public string SIncItemCode
        {
            get ;
            set ;
        }

		
        public string IncDetCode
        {
            get ;
            set ;
        }

		
        public bool IsSubmit
        {
            get ;
            set ;
        }

		
        public string ExpProjCode
        {
            get ;
            set ;
        }

		
        public string TransDepCode
        {
            get ;
            set ;
        }

		
        public decimal AppAmt
        {
            get ;
            set ;
        }

		
        public decimal OrdAmt
        {
            get ;
            set ;
        }

		
        public decimal TransAmt
        {
            get ;
            set ;
        }

		
        public bool Approved
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

		
        public string TaskCode
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string FundCode
        {
            get ;
            set ;
        }

		
        public bool IsAllot
        {
            get ;
            set ;
        }

		
        public bool IsCheck
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

		
        public string VendorCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_TransferApp Create()
        {
            return EF.DataPortal.Create<FI_TransferApp>();
        }

		public static FI_TransferApp Fetch(System.Linq.Expressions.Expression<Func<FI_TransferApp, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_TransferApp>(exp,values);
            return EF.DataPortal.Fetch<FI_TransferApp>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_TransferApps))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_TransferApps:ReadOnlyListBase<FI_TransferApps,FI_TransferApp>
    {
        #region Factory Methods

        public static FI_TransferApps Fetch()
        {
            return EF.DataPortal.Fetch<FI_TransferApps>();
        }

		public static FI_TransferApps Fetch(System.Linq.Expressions.Expression<Func<FI_TransferApp, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_TransferApp>(exp,values);
            return EF.DataPortal.Fetch<FI_TransferApps>(lambda);
		}

		public static FI_TransferApps Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_TransferApps>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_TransferApps Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_TransferApp, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_TransferApps>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_TransferApp>(exp,values)});
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
