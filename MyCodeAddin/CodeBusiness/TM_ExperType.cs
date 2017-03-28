using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(TM_ExperType))]
#if Dev
    [RunLocal]
#endif

	public class TM_ExperType:ReadOnlyBase<TM_ExperType>
    {
        #region Business Methods

		
        public string ExperTypeCode
        {
            get ;
            set ;
        }

		
        public string ExperTypeName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static TM_ExperType Create()
        {
            return EF.DataPortal.Create<TM_ExperType>();
        }

		public static TM_ExperType Fetch(System.Linq.Expressions.Expression<Func<TM_ExperType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<TM_ExperType>(exp,values);
            return EF.DataPortal.Fetch<TM_ExperType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(TM_ExperTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class TM_ExperTypes:ReadOnlyListBase<TM_ExperTypes,TM_ExperType>
    {
        #region Factory Methods

        public static TM_ExperTypes Fetch()
        {
            return EF.DataPortal.Fetch<TM_ExperTypes>();
        }

		public static TM_ExperTypes Fetch(System.Linq.Expressions.Expression<Func<TM_ExperType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<TM_ExperType>(exp,values);
            return EF.DataPortal.Fetch<TM_ExperTypes>(lambda);
		}

		public static TM_ExperTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<TM_ExperTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static TM_ExperTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<TM_ExperType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<TM_ExperTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<TM_ExperType>(exp,values)});
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
