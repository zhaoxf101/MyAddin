using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(MM_MatType))]
#if Dev
    [RunLocal]
#endif

	public class MM_MatType:ReadOnlyBase<MM_MatType>
    {
        #region Business Methods

		
        public string MatType
        {
            get ;
            set ;
        }

		
        public string NumRange
        {
            get ;
            set ;
        }

		
        public string LText
        {
            get ;
            set ;
        }

		
        public bool? IsGroup
        {
            get ;
            set ;
        }

		
        public string PCode
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

		public static MM_MatType Create()
        {
            return EF.DataPortal.Create<MM_MatType>();
        }

		public static MM_MatType Fetch(System.Linq.Expressions.Expression<Func<MM_MatType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<MM_MatType>(exp,values);
            return EF.DataPortal.Fetch<MM_MatType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(MM_MatTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class MM_MatTypes:ReadOnlyListBase<MM_MatTypes,MM_MatType>
    {
        #region Factory Methods

        public static MM_MatTypes Fetch()
        {
            return EF.DataPortal.Fetch<MM_MatTypes>();
        }

		public static MM_MatTypes Fetch(System.Linq.Expressions.Expression<Func<MM_MatType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<MM_MatType>(exp,values);
            return EF.DataPortal.Fetch<MM_MatTypes>(lambda);
		}

		public static MM_MatTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<MM_MatTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static MM_MatTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<MM_MatType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<MM_MatTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<MM_MatType>(exp,values)});
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
