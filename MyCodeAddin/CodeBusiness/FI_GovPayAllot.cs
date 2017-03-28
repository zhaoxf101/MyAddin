using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_GovPayAllot))]
#if Dev
    [RunLocal]
#endif

	public class FI_GovPayAllot:ReadOnlyBase<FI_GovPayAllot>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string GovAllotNo
        {
            get ;
            set ;
        }

		
        public string GovAppText
        {
            get ;
            set ;
        }

		
        public string BusType
        {
            get ;
            set ;
        }

		
        public string AllotBusTypeCode
        {
            get ;
            set ;
        }

		
        public string FundCode
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public bool IsSubmit
        {
            get ;
            set ;
        }

		
        public bool Appovel
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

		
        public string RefVouchNo
        {
            get ;
            set ;
        }

		
        public string VouchText
        {
            get ;
            set ;
        }

		
        public bool IsDis
        {
            get ;
            set ;
        }

		
        public string AccCode
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

		
		#endregion

		#region Factory Methods

		public static FI_GovPayAllot Create()
        {
            return EF.DataPortal.Create<FI_GovPayAllot>();
        }

		public static FI_GovPayAllot Fetch(System.Linq.Expressions.Expression<Func<FI_GovPayAllot, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_GovPayAllot>(exp,values);
            return EF.DataPortal.Fetch<FI_GovPayAllot>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_GovPayAllots))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_GovPayAllots:ReadOnlyListBase<FI_GovPayAllots,FI_GovPayAllot>
    {
        #region Factory Methods

        public static FI_GovPayAllots Fetch()
        {
            return EF.DataPortal.Fetch<FI_GovPayAllots>();
        }

		public static FI_GovPayAllots Fetch(System.Linq.Expressions.Expression<Func<FI_GovPayAllot, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_GovPayAllot>(exp,values);
            return EF.DataPortal.Fetch<FI_GovPayAllots>(lambda);
		}

		public static FI_GovPayAllots Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_GovPayAllots>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_GovPayAllots Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_GovPayAllot, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_GovPayAllots>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_GovPayAllot>(exp,values)});
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
