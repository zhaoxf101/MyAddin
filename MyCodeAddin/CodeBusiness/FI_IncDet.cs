using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_IncDet))]
#if Dev
    [RunLocal]
#endif

	public class FI_IncDet:ReadOnlyBase<FI_IncDet>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string IncDetCode
        {
            get ;
            set ;
        }

		
        public string IncDetName
        {
            get ;
            set ;
        }

		
        public string IncDetTypeCode
        {
            get ;
            set ;
        }

		
        public string SIncItemCode
        {
            get ;
            set ;
        }

		
        public string FundBudAreaCode
        {
            get ;
            set ;
        }

		
        public string AllotBusTypeCode
        {
            get ;
            set ;
        }

		
        public bool IsInternal
        {
            get ;
            set ;
        }

		
        public string AccCode
        {
            get ;
            set ;
        }

		
        public string BAccCode
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public bool IsDel
        {
            get ;
            set ;
        }

		
        public string Memo
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

		public static FI_IncDet Create()
        {
            return EF.DataPortal.Create<FI_IncDet>();
        }

		public static FI_IncDet Fetch(System.Linq.Expressions.Expression<Func<FI_IncDet, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_IncDet>(exp,values);
            return EF.DataPortal.Fetch<FI_IncDet>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_IncDets))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_IncDets:ReadOnlyListBase<FI_IncDets,FI_IncDet>
    {
        #region Factory Methods

        public static FI_IncDets Fetch()
        {
            return EF.DataPortal.Fetch<FI_IncDets>();
        }

		public static FI_IncDets Fetch(System.Linq.Expressions.Expression<Func<FI_IncDet, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_IncDet>(exp,values);
            return EF.DataPortal.Fetch<FI_IncDets>(lambda);
		}

		public static FI_IncDets Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_IncDets>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_IncDets Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_IncDet, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_IncDets>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_IncDet>(exp,values)});
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
