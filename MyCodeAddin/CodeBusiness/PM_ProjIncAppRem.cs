using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ProjIncAppRem))]
#if Dev
    [RunLocal]
#endif

	public class PM_ProjIncAppRem:ReadOnlyBase<PM_ProjIncAppRem>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ProjIncAppNo
        {
            get ;
            set ;
        }

		
        public string BName
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string VouchNo
        {
            get ;
            set ;
        }

		
        public string DeptCode
        {
            get ;
            set ;
        }

		
        public decimal? FDAmt
        {
            get ;
            set ;
        }

		
        public decimal? IncAppAmt
        {
            get ;
            set ;
        }

		
        public decimal? LExpFDAmt
        {
            get ;
            set ;
        }

		
        public decimal? LExpAppAmt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_ProjIncAppRem Create()
        {
            return EF.DataPortal.Create<PM_ProjIncAppRem>();
        }

		public static PM_ProjIncAppRem Fetch(System.Linq.Expressions.Expression<Func<PM_ProjIncAppRem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjIncAppRem>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjIncAppRem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ProjIncAppRems))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ProjIncAppRems:ReadOnlyListBase<PM_ProjIncAppRems,PM_ProjIncAppRem>
    {
        #region Factory Methods

        public static PM_ProjIncAppRems Fetch()
        {
            return EF.DataPortal.Fetch<PM_ProjIncAppRems>();
        }

		public static PM_ProjIncAppRems Fetch(System.Linq.Expressions.Expression<Func<PM_ProjIncAppRem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjIncAppRem>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjIncAppRems>(lambda);
		}

		public static PM_ProjIncAppRems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ProjIncAppRems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ProjIncAppRems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ProjIncAppRem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ProjIncAppRems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ProjIncAppRem>(exp,values)});
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
