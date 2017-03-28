using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ProjType))]
#if Dev
    [RunLocal]
#endif

	public class PM_ProjType:ReadOnlyBase<PM_ProjType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ProjTypeCode
        {
            get ;
            set ;
        }

		
        public string ProjTypeName
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

		public static PM_ProjType Create()
        {
            return EF.DataPortal.Create<PM_ProjType>();
        }

		public static PM_ProjType Fetch(System.Linq.Expressions.Expression<Func<PM_ProjType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjType>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ProjTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ProjTypes:ReadOnlyListBase<PM_ProjTypes,PM_ProjType>
    {
        #region Factory Methods

        public static PM_ProjTypes Fetch()
        {
            return EF.DataPortal.Fetch<PM_ProjTypes>();
        }

		public static PM_ProjTypes Fetch(System.Linq.Expressions.Expression<Func<PM_ProjType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjType>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjTypes>(lambda);
		}

		public static PM_ProjTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ProjTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ProjTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ProjType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ProjTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ProjType>(exp,values)});
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
