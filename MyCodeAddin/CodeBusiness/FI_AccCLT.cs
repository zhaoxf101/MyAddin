using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_AccCLT))]
#if Dev
    [RunLocal]
#endif

	public class FI_AccCLT:ReadOnlyBase<FI_AccCLT>
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

		
        public string AuthGrp
        {
            get ;
            set ;
        }

		
        public string FieldGrp
        {
            get ;
            set ;
        }

		
        public string RateDiffCode
        {
            get ;
            set ;
        }

		
        public string AccType
        {
            get ;
            set ;
        }

		
        public string TaxType
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

		
        public bool FundRelX
        {
            get ;
            set ;
        }

		
        public bool AutoPostX
        {
            get ;
            set ;
        }

		
        public bool NoTaxPostX
        {
            get ;
            set ;
        }

		
        public bool FrozenX
        {
            get ;
            set ;
        }

		
        public bool WDelX
        {
            get ;
            set ;
        }

		
        public string BookType
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

		public static FI_AccCLT Create()
        {
            return EF.DataPortal.Create<FI_AccCLT>();
        }

		public static FI_AccCLT Fetch(System.Linq.Expressions.Expression<Func<FI_AccCLT, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_AccCLT>(exp,values);
            return EF.DataPortal.Fetch<FI_AccCLT>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_AccCLTs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_AccCLTs:ReadOnlyListBase<FI_AccCLTs,FI_AccCLT>
    {
        #region Factory Methods

        public static FI_AccCLTs Fetch()
        {
            return EF.DataPortal.Fetch<FI_AccCLTs>();
        }

		public static FI_AccCLTs Fetch(System.Linq.Expressions.Expression<Func<FI_AccCLT, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_AccCLT>(exp,values);
            return EF.DataPortal.Fetch<FI_AccCLTs>(lambda);
		}

		public static FI_AccCLTs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_AccCLTs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_AccCLTs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_AccCLT, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_AccCLTs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_AccCLT>(exp,values)});
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
