using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ResouType))]
#if Dev
    [RunLocal]
#endif

	public class PM_ResouType:ReadOnlyBase<PM_ResouType>
    {
        #region Business Methods

		
        public string ResouTypeCode
        {
            get ;
            set ;
        }

		
        public string ResouTypeName
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

		public static PM_ResouType Create()
        {
            return EF.DataPortal.Create<PM_ResouType>();
        }

		public static PM_ResouType Fetch(System.Linq.Expressions.Expression<Func<PM_ResouType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ResouType>(exp,values);
            return EF.DataPortal.Fetch<PM_ResouType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ResouTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ResouTypes:ReadOnlyListBase<PM_ResouTypes,PM_ResouType>
    {
        #region Factory Methods

        public static PM_ResouTypes Fetch()
        {
            return EF.DataPortal.Fetch<PM_ResouTypes>();
        }

		public static PM_ResouTypes Fetch(System.Linq.Expressions.Expression<Func<PM_ResouType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ResouType>(exp,values);
            return EF.DataPortal.Fetch<PM_ResouTypes>(lambda);
		}

		public static PM_ResouTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ResouTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ResouTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ResouType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ResouTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ResouType>(exp,values)});
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
