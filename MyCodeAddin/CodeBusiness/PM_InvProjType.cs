using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_InvProjType))]
#if Dev
    [RunLocal]
#endif

	public class PM_InvProjType:ReadOnlyBase<PM_InvProjType>
    {
        #region Business Methods

		
        public string InvProjTypeCode
        {
            get ;
            set ;
        }

		
        public string InvProjTypeName
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public string Memo
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

		public static PM_InvProjType Create()
        {
            return EF.DataPortal.Create<PM_InvProjType>();
        }

		public static PM_InvProjType Fetch(System.Linq.Expressions.Expression<Func<PM_InvProjType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_InvProjType>(exp,values);
            return EF.DataPortal.Fetch<PM_InvProjType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_InvProjTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_InvProjTypes:ReadOnlyListBase<PM_InvProjTypes,PM_InvProjType>
    {
        #region Factory Methods

        public static PM_InvProjTypes Fetch()
        {
            return EF.DataPortal.Fetch<PM_InvProjTypes>();
        }

		public static PM_InvProjTypes Fetch(System.Linq.Expressions.Expression<Func<PM_InvProjType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_InvProjType>(exp,values);
            return EF.DataPortal.Fetch<PM_InvProjTypes>(lambda);
		}

		public static PM_InvProjTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_InvProjTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_InvProjTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_InvProjType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_InvProjTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_InvProjType>(exp,values)});
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
