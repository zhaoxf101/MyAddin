using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(UP_ISBType))]
#if Dev
    [RunLocal]
#endif

	public class UP_ISBType:ReadOnlyBase<UP_ISBType>
    {
        #region Business Methods

		
        public string ISBType
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static UP_ISBType Create()
        {
            return EF.DataPortal.Create<UP_ISBType>();
        }

		public static UP_ISBType Fetch(System.Linq.Expressions.Expression<Func<UP_ISBType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<UP_ISBType>(exp,values);
            return EF.DataPortal.Fetch<UP_ISBType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(UP_ISBTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class UP_ISBTypes:ReadOnlyListBase<UP_ISBTypes,UP_ISBType>
    {
        #region Factory Methods

        public static UP_ISBTypes Fetch()
        {
            return EF.DataPortal.Fetch<UP_ISBTypes>();
        }

		public static UP_ISBTypes Fetch(System.Linq.Expressions.Expression<Func<UP_ISBType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<UP_ISBType>(exp,values);
            return EF.DataPortal.Fetch<UP_ISBTypes>(lambda);
		}

		public static UP_ISBTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<UP_ISBTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static UP_ISBTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<UP_ISBType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<UP_ISBTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<UP_ISBType>(exp,values)});
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
