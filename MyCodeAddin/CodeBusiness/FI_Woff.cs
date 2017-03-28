using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_Woff))]
#if Dev
    [RunLocal]
#endif

	public class FI_Woff:ReadOnlyBase<FI_Woff>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string WoffCode
        {
            get ;
            set ;
        }

		
        public string WoffName
        {
            get ;
            set ;
        }

		
        public string ProjCode
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

		
        public string BarCode
        {
            get ;
            set ;
        }

		
        public decimal WoffAmt
        {
            get ;
            set ;
        }

		
        public decimal WoffActAmt
        {
            get ;
            set ;
        }

		
        public decimal BankAmt
        {
            get ;
            set ;
        }

		
        public string WoffUser
        {
            get ;
            set ;
        }

		
        public string WorkFlowId
        {
            get ;
            set ;
        }

		
        public string Description
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

		
        public bool IsAccVou
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

		
        public bool IsSubmit
        {
            get ;
            set ;
        }

		
        public bool IsDetails
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

		
		#endregion

		#region Factory Methods

		public static FI_Woff Create()
        {
            return EF.DataPortal.Create<FI_Woff>();
        }

		public static FI_Woff Fetch(System.Linq.Expressions.Expression<Func<FI_Woff, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_Woff>(exp,values);
            return EF.DataPortal.Fetch<FI_Woff>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_Woffs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_Woffs:ReadOnlyListBase<FI_Woffs,FI_Woff>
    {
        #region Factory Methods

        public static FI_Woffs Fetch()
        {
            return EF.DataPortal.Fetch<FI_Woffs>();
        }

		public static FI_Woffs Fetch(System.Linq.Expressions.Expression<Func<FI_Woff, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_Woff>(exp,values);
            return EF.DataPortal.Fetch<FI_Woffs>(lambda);
		}

		public static FI_Woffs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_Woffs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_Woffs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_Woff, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_Woffs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_Woff>(exp,values)});
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
