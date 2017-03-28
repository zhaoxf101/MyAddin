using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ProjIncApp))]
#if Dev
    [RunLocal]
#endif

	public class PM_ProjIncApp:ReadOnlyBase<PM_ProjIncApp>
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

		
        public bool IsAppr
        {
            get ;
            set ;
        }

		
        public string SFWF
        {
            get ;
            set ;
        }

		
        public bool Cancelled
        {
            get ;
            set ;
        }

		
        public bool Approved
        {
            get ;
            set ;
        }

		
        public string ObjectId
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

		public static PM_ProjIncApp Create()
        {
            return EF.DataPortal.Create<PM_ProjIncApp>();
        }

		public static PM_ProjIncApp Fetch(System.Linq.Expressions.Expression<Func<PM_ProjIncApp, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjIncApp>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjIncApp>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ProjIncApps))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ProjIncApps:ReadOnlyListBase<PM_ProjIncApps,PM_ProjIncApp>
    {
        #region Factory Methods

        public static PM_ProjIncApps Fetch()
        {
            return EF.DataPortal.Fetch<PM_ProjIncApps>();
        }

		public static PM_ProjIncApps Fetch(System.Linq.Expressions.Expression<Func<PM_ProjIncApp, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjIncApp>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjIncApps>(lambda);
		}

		public static PM_ProjIncApps Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ProjIncApps>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ProjIncApps Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ProjIncApp, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ProjIncApps>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ProjIncApp>(exp,values)});
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
