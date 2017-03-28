using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ResExpType))]
#if Dev
    [RunLocal]
#endif

	public class FI_ResExpType:ReadOnlyBase<FI_ResExpType>
    {
        #region Business Methods

		
        public string ResExpTypeCode
        {
            get ;
            set ;
        }

		
        public string ResExpTypeName
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

		public static FI_ResExpType Create()
        {
            return EF.DataPortal.Create<FI_ResExpType>();
        }

		public static FI_ResExpType Fetch(System.Linq.Expressions.Expression<Func<FI_ResExpType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ResExpType>(exp,values);
            return EF.DataPortal.Fetch<FI_ResExpType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ResExpTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ResExpTypes:ReadOnlyListBase<FI_ResExpTypes,FI_ResExpType>
    {
        #region Factory Methods

        public static FI_ResExpTypes Fetch()
        {
            return EF.DataPortal.Fetch<FI_ResExpTypes>();
        }

		public static FI_ResExpTypes Fetch(System.Linq.Expressions.Expression<Func<FI_ResExpType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ResExpType>(exp,values);
            return EF.DataPortal.Fetch<FI_ResExpTypes>(lambda);
		}

		public static FI_ResExpTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ResExpTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ResExpTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ResExpType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ResExpTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ResExpType>(exp,values)});
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
