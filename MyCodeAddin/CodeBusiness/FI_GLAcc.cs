using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_GLAcc))]
#if Dev
    [RunLocal]
#endif

	public class FI_GLAcc:ReadOnlyBase<FI_GLAcc>
    {
        #region Business Methods

		
        public string AccChart
        {
            get ;
            set ;
        }

		
        public string AccType
        {
            get ;
            set ;
        }

		
        public string GLMark
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

		
		#endregion

		#region Factory Methods

		public static FI_GLAcc Create()
        {
            return EF.DataPortal.Create<FI_GLAcc>();
        }

		public static FI_GLAcc Fetch(System.Linq.Expressions.Expression<Func<FI_GLAcc, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_GLAcc>(exp,values);
            return EF.DataPortal.Fetch<FI_GLAcc>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_GLAccs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_GLAccs:ReadOnlyListBase<FI_GLAccs,FI_GLAcc>
    {
        #region Factory Methods

        public static FI_GLAccs Fetch()
        {
            return EF.DataPortal.Fetch<FI_GLAccs>();
        }

		public static FI_GLAccs Fetch(System.Linq.Expressions.Expression<Func<FI_GLAcc, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_GLAcc>(exp,values);
            return EF.DataPortal.Fetch<FI_GLAccs>(lambda);
		}

		public static FI_GLAccs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_GLAccs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_GLAccs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_GLAcc, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_GLAccs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_GLAcc>(exp,values)});
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
