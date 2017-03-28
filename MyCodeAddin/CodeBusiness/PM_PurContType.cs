using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_PurContType))]
#if Dev
    [RunLocal]
#endif

	public class PM_PurContType:ReadOnlyBase<PM_PurContType>
    {
        #region Business Methods

		
        public string PurContTypeCode
        {
            get ;
            set ;
        }

		
        public string PurContTypeName
        {
            get ;
            set ;
        }

		
        public string SimName
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

		public static PM_PurContType Create()
        {
            return EF.DataPortal.Create<PM_PurContType>();
        }

		public static PM_PurContType Fetch(System.Linq.Expressions.Expression<Func<PM_PurContType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_PurContType>(exp,values);
            return EF.DataPortal.Fetch<PM_PurContType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_PurContTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_PurContTypes:ReadOnlyListBase<PM_PurContTypes,PM_PurContType>
    {
        #region Factory Methods

        public static PM_PurContTypes Fetch()
        {
            return EF.DataPortal.Fetch<PM_PurContTypes>();
        }

		public static PM_PurContTypes Fetch(System.Linq.Expressions.Expression<Func<PM_PurContType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_PurContType>(exp,values);
            return EF.DataPortal.Fetch<PM_PurContTypes>(lambda);
		}

		public static PM_PurContTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_PurContTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_PurContTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_PurContType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_PurContTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_PurContType>(exp,values)});
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
