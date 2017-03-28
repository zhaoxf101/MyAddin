using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CG_Tran))]
#if Dev
    [RunLocal]
#endif

	public class CG_Tran:ReadOnlyBase<CG_Tran>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public Guid Id
        {
            get ;
            set ;
        }

		
        public string TranNo
        {
            get ;
            set ;
        }

		
        public string PayWayCode
        {
            get ;
            set ;
        }

		
        public string TranText
        {
            get ;
            set ;
        }

		
        public string TranMemo
        {
            get ;
            set ;
        }

		
        public string TranDate
        {
            get ;
            set ;
        }

		
        public DateTime? TranDateTime
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string ClientIP
        {
            get ;
            set ;
        }

		
        public string ClientNo
        {
            get ;
            set ;
        }

		
        public string OutTranNo
        {
            get ;
            set ;
        }

		
        public string OutDate
        {
            get ;
            set ;
        }

		
        public string OutSign
        {
            get ;
            set ;
        }

		
        public string FeeType
        {
            get ;
            set ;
        }

		
        public string UnitedBankId
        {
            get ;
            set ;
        }

		
        public Guid TranOrderId
        {
            get ;
            set ;
        }

		
        public string TranOrderNo
        {
            get ;
            set ;
        }

		
        public string TranOrderDate
        {
            get ;
            set ;
        }

		
        public Guid? FeeOrderId
        {
            get ;
            set ;
        }

		
        public string FeeOrderNo
        {
            get ;
            set ;
        }

		
        public decimal TranAmt
        {
            get ;
            set ;
        }

		
        public string CreateUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreateDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static CG_Tran Create()
        {
            return EF.DataPortal.Create<CG_Tran>();
        }

		public static CG_Tran Fetch(System.Linq.Expressions.Expression<Func<CG_Tran, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CG_Tran>(exp,values);
            return EF.DataPortal.Fetch<CG_Tran>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CG_Trans))]
#if Dev
    [RunLocal]
#endif
	
	public class CG_Trans:ReadOnlyListBase<CG_Trans,CG_Tran>
    {
        #region Factory Methods

        public static CG_Trans Fetch()
        {
            return EF.DataPortal.Fetch<CG_Trans>();
        }

		public static CG_Trans Fetch(System.Linq.Expressions.Expression<Func<CG_Tran, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CG_Tran>(exp,values);
            return EF.DataPortal.Fetch<CG_Trans>(lambda);
		}

		public static CG_Trans Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CG_Trans>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CG_Trans Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CG_Tran, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CG_Trans>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CG_Tran>(exp,values)});
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
