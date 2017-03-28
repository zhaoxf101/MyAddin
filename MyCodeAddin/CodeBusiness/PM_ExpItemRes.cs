using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ExpItemRes))]
#if Dev
    [RunLocal]
#endif

	public class PM_ExpItemRes:ReadOnlyBase<PM_ExpItemRes>
    {
        #region Business Methods

		
        public string Client
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

		
        public string ExpItemRow
        {
            get ;
            set ;
        }

		
        public string ResouItemCode
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public bool IsAdd
        {
            get ;
            set ;
        }

		
        public bool IsCWCHK
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

		public static PM_ExpItemRes Create()
        {
            return EF.DataPortal.Create<PM_ExpItemRes>();
        }

		public static PM_ExpItemRes Fetch(System.Linq.Expressions.Expression<Func<PM_ExpItemRes, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ExpItemRes>(exp,values);
            return EF.DataPortal.Fetch<PM_ExpItemRes>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ExpItemRess))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ExpItemRess:ReadOnlyListBase<PM_ExpItemRess,PM_ExpItemRes>
    {
        #region Factory Methods

        public static PM_ExpItemRess Fetch()
        {
            return EF.DataPortal.Fetch<PM_ExpItemRess>();
        }

		public static PM_ExpItemRess Fetch(System.Linq.Expressions.Expression<Func<PM_ExpItemRes, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ExpItemRes>(exp,values);
            return EF.DataPortal.Fetch<PM_ExpItemRess>(lambda);
		}

		public static PM_ExpItemRess Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ExpItemRess>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ExpItemRess Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ExpItemRes, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ExpItemRess>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ExpItemRes>(exp,values)});
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
