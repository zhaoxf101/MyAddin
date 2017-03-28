using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PostKey))]
#if Dev
    [RunLocal]
#endif

	public class FI_PostKey:ReadOnlyBase<FI_PostKey>
    {
        #region Business Methods

		
        public string PostKey
        {
            get ;
            set ;
        }

		
        public bool DeCrX
        {
            get ;
            set ;
        }

		
        public string AccCls
        {
            get ;
            set ;
        }

		
        public string AccType
        {
            get ;
            set ;
        }

		
        public string OffsetKey
        {
            get ;
            set ;
        }

		
        public string BPostKey
        {
            get ;
            set ;
        }

		
        public string FundMark
        {
            get ;
            set ;
        }

		
        public string PostBus
        {
            get ;
            set ;
        }

		
        public bool GovPayX
        {
            get ;
            set ;
        }

		
        public string Status
        {
            get ;
            set ;
        }

		
        public string DText
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

		public static FI_PostKey Create()
        {
            return EF.DataPortal.Create<FI_PostKey>();
        }

		public static FI_PostKey Fetch(System.Linq.Expressions.Expression<Func<FI_PostKey, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PostKey>(exp,values);
            return EF.DataPortal.Fetch<FI_PostKey>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PostKeys))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PostKeys:ReadOnlyListBase<FI_PostKeys,FI_PostKey>
    {
        #region Factory Methods

        public static FI_PostKeys Fetch()
        {
            return EF.DataPortal.Fetch<FI_PostKeys>();
        }

		public static FI_PostKeys Fetch(System.Linq.Expressions.Expression<Func<FI_PostKey, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PostKey>(exp,values);
            return EF.DataPortal.Fetch<FI_PostKeys>(lambda);
		}

		public static FI_PostKeys Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PostKeys>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PostKeys Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PostKey, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PostKeys>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PostKey>(exp,values)});
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
