using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ModExpItemRes))]
#if Dev
    [RunLocal]
#endif

	public class PM_ModExpItemRes:ReadOnlyBase<PM_ModExpItemRes>
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

		public static PM_ModExpItemRes Create()
        {
            return EF.DataPortal.Create<PM_ModExpItemRes>();
        }

		public static PM_ModExpItemRes Fetch(System.Linq.Expressions.Expression<Func<PM_ModExpItemRes, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ModExpItemRes>(exp,values);
            return EF.DataPortal.Fetch<PM_ModExpItemRes>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ModExpItemRess))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ModExpItemRess:ReadOnlyListBase<PM_ModExpItemRess,PM_ModExpItemRes>
    {
        #region Factory Methods

        public static PM_ModExpItemRess Fetch()
        {
            return EF.DataPortal.Fetch<PM_ModExpItemRess>();
        }

		public static PM_ModExpItemRess Fetch(System.Linq.Expressions.Expression<Func<PM_ModExpItemRes, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ModExpItemRes>(exp,values);
            return EF.DataPortal.Fetch<PM_ModExpItemRess>(lambda);
		}

		public static PM_ModExpItemRess Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ModExpItemRess>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ModExpItemRess Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ModExpItemRes, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ModExpItemRess>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ModExpItemRes>(exp,values)});
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
