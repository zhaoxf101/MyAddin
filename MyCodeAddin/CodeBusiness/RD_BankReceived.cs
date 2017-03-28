using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(RD_BankReceived))]
#if Dev
    [RunLocal]
#endif

	public class RD_BankReceived:ReadOnlyBase<RD_BankReceived>
    {
        #region Business Methods

		
        public string RecipName
        {
            get ;
            set ;
        }

		
        public string RecipAccNo
        {
            get ;
            set ;
        }

		
        public string RecipBkNo
        {
            get ;
            set ;
        }

		
        public decimal? TranAmt
        {
            get ;
            set ;
        }

		
        public DateTime? TranTime
        {
            get ;
            set ;
        }

		
        public string PostScript
        {
            get ;
            set ;
        }

		
        public string BankNote
        {
            get ;
            set ;
        }

		
        public string BusType
        {
            get ;
            set ;
        }

		
        public string BankTranNO
        {
            get ;
            set ;
        }

		
        public string BKName
        {
            get ;
            set ;
        }

		
        public string AccNo
        {
            get ;
            set ;
        }

		
        public string AccName
        {
            get ;
            set ;
        }

		
        public decimal? PreAllotAmt
        {
            get ;
            set ;
        }

		
        public string FIAudit
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

		
		#endregion

		#region Factory Methods

		public static RD_BankReceived Create()
        {
            return EF.DataPortal.Create<RD_BankReceived>();
        }

		public static RD_BankReceived Fetch(System.Linq.Expressions.Expression<Func<RD_BankReceived, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<RD_BankReceived>(exp,values);
            return EF.DataPortal.Fetch<RD_BankReceived>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(RD_BankReceiveds))]
#if Dev
    [RunLocal]
#endif
	
	public class RD_BankReceiveds:ReadOnlyListBase<RD_BankReceiveds,RD_BankReceived>
    {
        #region Factory Methods

        public static RD_BankReceiveds Fetch()
        {
            return EF.DataPortal.Fetch<RD_BankReceiveds>();
        }

		public static RD_BankReceiveds Fetch(System.Linq.Expressions.Expression<Func<RD_BankReceived, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<RD_BankReceived>(exp,values);
            return EF.DataPortal.Fetch<RD_BankReceiveds>(lambda);
		}

		public static RD_BankReceiveds Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<RD_BankReceiveds>(new Paging { Page=page,RowCount=rowCount});
        }

        public static RD_BankReceiveds Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<RD_BankReceived, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<RD_BankReceiveds>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<RD_BankReceived>(exp,values)});
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
