using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_PurType))]
#if Dev
    [RunLocal]
#endif

	public class PM_PurType:ReadOnlyBase<PM_PurType>
    {
        #region Business Methods

		
        public string PurTypeCode
        {
            get ;
            set ;
        }

		
        public string PurTypeName
        {
            get ;
            set ;
        }

		
        public int SortOrder
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

		public static PM_PurType Create()
        {
            return EF.DataPortal.Create<PM_PurType>();
        }

		public static PM_PurType Fetch(System.Linq.Expressions.Expression<Func<PM_PurType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_PurType>(exp,values);
            return EF.DataPortal.Fetch<PM_PurType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_PurTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_PurTypes:ReadOnlyListBase<PM_PurTypes,PM_PurType>
    {
        #region Factory Methods

        public static PM_PurTypes Fetch()
        {
            return EF.DataPortal.Fetch<PM_PurTypes>();
        }

		public static PM_PurTypes Fetch(System.Linq.Expressions.Expression<Func<PM_PurType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_PurType>(exp,values);
            return EF.DataPortal.Fetch<PM_PurTypes>(lambda);
		}

		public static PM_PurTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_PurTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_PurTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_PurType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_PurTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_PurType>(exp,values)});
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
