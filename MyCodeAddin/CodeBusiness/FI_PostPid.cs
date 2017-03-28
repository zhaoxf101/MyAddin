using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PostPid))]
#if Dev
    [RunLocal]
#endif

	public class FI_PostPid:ReadOnlyBase<FI_PostPid>
    {
        #region Business Methods

		
        public string PostPidSet
        {
            get ;
            set ;
        }

		
        public string AccType
        {
            get ;
            set ;
        }

		
        public string FYear1
        {
            get ;
            set ;
        }

		
        public string FPid1
        {
            get ;
            set ;
        }

		
        public string TYear1
        {
            get ;
            set ;
        }

		
        public string TPid1
        {
            get ;
            set ;
        }

		
        public string FYear2
        {
            get ;
            set ;
        }

		
        public string FPid2
        {
            get ;
            set ;
        }

		
        public string TYear2
        {
            get ;
            set ;
        }

		
        public string TPid2
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

		public static FI_PostPid Create()
        {
            return EF.DataPortal.Create<FI_PostPid>();
        }

		public static FI_PostPid Fetch(System.Linq.Expressions.Expression<Func<FI_PostPid, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PostPid>(exp,values);
            return EF.DataPortal.Fetch<FI_PostPid>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PostPids))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PostPids:ReadOnlyListBase<FI_PostPids,FI_PostPid>
    {
        #region Factory Methods

        public static FI_PostPids Fetch()
        {
            return EF.DataPortal.Fetch<FI_PostPids>();
        }

		public static FI_PostPids Fetch(System.Linq.Expressions.Expression<Func<FI_PostPid, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PostPid>(exp,values);
            return EF.DataPortal.Fetch<FI_PostPids>(lambda);
		}

		public static FI_PostPids Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PostPids>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PostPids Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PostPid, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PostPids>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PostPid>(exp,values)});
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
