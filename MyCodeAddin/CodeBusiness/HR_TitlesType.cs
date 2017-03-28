using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_TitlesType))]
#if Dev
    [RunLocal]
#endif

	public class HR_TitlesType:ReadOnlyBase<HR_TitlesType>
    {
        #region Business Methods

		
        public string TitlesTypeCode
        {
            get ;
            set ;
        }

		
        public string TitlesTypeName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_TitlesType Create()
        {
            return EF.DataPortal.Create<HR_TitlesType>();
        }

		public static HR_TitlesType Fetch(System.Linq.Expressions.Expression<Func<HR_TitlesType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_TitlesType>(exp,values);
            return EF.DataPortal.Fetch<HR_TitlesType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_TitlesTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_TitlesTypes:ReadOnlyListBase<HR_TitlesTypes,HR_TitlesType>
    {
        #region Factory Methods

        public static HR_TitlesTypes Fetch()
        {
            return EF.DataPortal.Fetch<HR_TitlesTypes>();
        }

		public static HR_TitlesTypes Fetch(System.Linq.Expressions.Expression<Func<HR_TitlesType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_TitlesType>(exp,values);
            return EF.DataPortal.Fetch<HR_TitlesTypes>(lambda);
		}

		public static HR_TitlesTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_TitlesTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_TitlesTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_TitlesType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_TitlesTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_TitlesType>(exp,values)});
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
