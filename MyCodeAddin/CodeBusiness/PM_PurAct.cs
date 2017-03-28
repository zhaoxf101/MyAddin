using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_PurAct))]
#if Dev
    [RunLocal]
#endif

	public class PM_PurAct:ReadOnlyBase<PM_PurAct>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string PurActCode
        {
            get ;
            set ;
        }

		
        public string PurActName
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public bool Active
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

		public static PM_PurAct Create()
        {
            return EF.DataPortal.Create<PM_PurAct>();
        }

		public static PM_PurAct Fetch(System.Linq.Expressions.Expression<Func<PM_PurAct, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_PurAct>(exp,values);
            return EF.DataPortal.Fetch<PM_PurAct>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_PurActs))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_PurActs:ReadOnlyListBase<PM_PurActs,PM_PurAct>
    {
        #region Factory Methods

        public static PM_PurActs Fetch()
        {
            return EF.DataPortal.Fetch<PM_PurActs>();
        }

		public static PM_PurActs Fetch(System.Linq.Expressions.Expression<Func<PM_PurAct, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_PurAct>(exp,values);
            return EF.DataPortal.Fetch<PM_PurActs>(lambda);
		}

		public static PM_PurActs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_PurActs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_PurActs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_PurAct, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_PurActs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_PurAct>(exp,values)});
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
