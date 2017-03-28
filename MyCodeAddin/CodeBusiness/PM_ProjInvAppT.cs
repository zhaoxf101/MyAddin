using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ProjInvAppT))]
#if Dev
    [RunLocal]
#endif

	public class PM_ProjInvAppT:ReadOnlyBase<PM_ProjInvAppT>
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

		
        public string TaskCode
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

		
        public string DptCode
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

		public static PM_ProjInvAppT Create()
        {
            return EF.DataPortal.Create<PM_ProjInvAppT>();
        }

		public static PM_ProjInvAppT Fetch(System.Linq.Expressions.Expression<Func<PM_ProjInvAppT, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjInvAppT>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjInvAppT>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ProjInvAppTs))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ProjInvAppTs:ReadOnlyListBase<PM_ProjInvAppTs,PM_ProjInvAppT>
    {
        #region Factory Methods

        public static PM_ProjInvAppTs Fetch()
        {
            return EF.DataPortal.Fetch<PM_ProjInvAppTs>();
        }

		public static PM_ProjInvAppTs Fetch(System.Linq.Expressions.Expression<Func<PM_ProjInvAppT, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjInvAppT>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjInvAppTs>(lambda);
		}

		public static PM_ProjInvAppTs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ProjInvAppTs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ProjInvAppTs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ProjInvAppT, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ProjInvAppTs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ProjInvAppT>(exp,values)});
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
