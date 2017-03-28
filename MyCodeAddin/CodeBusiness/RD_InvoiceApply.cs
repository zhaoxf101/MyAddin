using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(RD_InvoiceApply))]
#if Dev
    [RunLocal]
#endif

	public class RD_InvoiceApply:ReadOnlyBase<RD_InvoiceApply>
    {
        #region Business Methods

		
        public string InvAppBillNo
        {
            get ;
            set ;
        }

		
        public DateTime? ApplyDate
        {
            get ;
            set ;
        }

		
        public string ProjectCode
        {
            get ;
            set ;
        }

		
        public string ProjectName
        {
            get ;
            set ;
        }

		
        public string ProjectManager
        {
            get ;
            set ;
        }

		
        public decimal? ProjectAmt
        {
            get ;
            set ;
        }

		
        public decimal? InvoicedAmt
        {
            get ;
            set ;
        }

		
        public decimal? InvoiceAmt
        {
            get ;
            set ;
        }

		
        public decimal? ReceivedAmt
        {
            get ;
            set ;
        }

		
        public string ProjectType
        {
            get ;
            set ;
        }

		
        public string OtherUnit
        {
            get ;
            set ;
        }

		
        public string InvoiceContent
        {
            get ;
            set ;
        }

		
        public string ContractNO
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

		
        public string RDAudit
        {
            get ;
            set ;
        }

		
        public string FIAudit
        {
            get ;
            set ;
        }

		
        public string InvoiceDrawer
        {
            get ;
            set ;
        }

		
        public bool? InvoiceYN
        {
            get ;
            set ;
        }

		
        public string InvoiceNo
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static RD_InvoiceApply Create()
        {
            return EF.DataPortal.Create<RD_InvoiceApply>();
        }

		public static RD_InvoiceApply Fetch(System.Linq.Expressions.Expression<Func<RD_InvoiceApply, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<RD_InvoiceApply>(exp,values);
            return EF.DataPortal.Fetch<RD_InvoiceApply>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(RD_InvoiceApplys))]
#if Dev
    [RunLocal]
#endif
	
	public class RD_InvoiceApplys:ReadOnlyListBase<RD_InvoiceApplys,RD_InvoiceApply>
    {
        #region Factory Methods

        public static RD_InvoiceApplys Fetch()
        {
            return EF.DataPortal.Fetch<RD_InvoiceApplys>();
        }

		public static RD_InvoiceApplys Fetch(System.Linq.Expressions.Expression<Func<RD_InvoiceApply, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<RD_InvoiceApply>(exp,values);
            return EF.DataPortal.Fetch<RD_InvoiceApplys>(lambda);
		}

		public static RD_InvoiceApplys Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<RD_InvoiceApplys>(new Paging { Page=page,RowCount=rowCount});
        }

        public static RD_InvoiceApplys Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<RD_InvoiceApply, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<RD_InvoiceApplys>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<RD_InvoiceApply>(exp,values)});
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
