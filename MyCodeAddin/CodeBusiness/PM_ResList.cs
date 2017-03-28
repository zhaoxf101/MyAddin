using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ResList))]
#if Dev
    [RunLocal]
#endif

	public class PM_ResList:ReadOnlyBase<PM_ResList>
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

		
        public string ResRow
        {
            get ;
            set ;
        }

		
        public bool Freeze
        {
            get ;
            set ;
        }

		
        public string ResName
        {
            get ;
            set ;
        }

		
        public string SpecType
        {
            get ;
            set ;
        }

		
        public string UnitCode
        {
            get ;
            set ;
        }

		
        public string Mfrs
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public bool IsPBuy
        {
            get ;
            set ;
        }

		
        public string MaterialCode
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

		public static PM_ResList Create()
        {
            return EF.DataPortal.Create<PM_ResList>();
        }

		public static PM_ResList Fetch(System.Linq.Expressions.Expression<Func<PM_ResList, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ResList>(exp,values);
            return EF.DataPortal.Fetch<PM_ResList>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ResLists))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ResLists:ReadOnlyListBase<PM_ResLists,PM_ResList>
    {
        #region Factory Methods

        public static PM_ResLists Fetch()
        {
            return EF.DataPortal.Fetch<PM_ResLists>();
        }

		public static PM_ResLists Fetch(System.Linq.Expressions.Expression<Func<PM_ResList, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ResList>(exp,values);
            return EF.DataPortal.Fetch<PM_ResLists>(lambda);
		}

		public static PM_ResLists Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ResLists>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ResLists Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ResList, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ResLists>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ResList>(exp,values)});
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
