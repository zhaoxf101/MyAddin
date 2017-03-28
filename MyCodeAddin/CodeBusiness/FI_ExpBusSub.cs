using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpBusSub))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpBusSub:ReadOnlyBase<FI_ExpBusSub>
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

		
        public string ExpItemId
        {
            get ;
            set ;
        }

		
        public string ExpBusType
        {
            get ;
            set ;
        }

		
        public string ResouItemCode
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

		
        public string ExpItemCode
        {
            get ;
            set ;
        }

		
        public string PBudExpEcoCode
        {
            get ;
            set ;
        }

		
        public int ObjQty
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt
        {
            get ;
            set ;
        }

		
        public int ActObjQty
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

		
        public string EquCode
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

		public static FI_ExpBusSub Create()
        {
            return EF.DataPortal.Create<FI_ExpBusSub>();
        }

		public static FI_ExpBusSub Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusSub>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpBusSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpBusSubs:ReadOnlyListBase<FI_ExpBusSubs,FI_ExpBusSub>
    {
        #region Factory Methods

        public static FI_ExpBusSubs Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpBusSubs>();
        }

		public static FI_ExpBusSubs Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusSub>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusSubs>(lambda);
		}

		public static FI_ExpBusSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpBusSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpBusSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpBusSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpBusSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpBusSub>(exp,values)});
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
