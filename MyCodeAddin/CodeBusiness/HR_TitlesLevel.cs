using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_TitlesLevel))]
#if Dev
    [RunLocal]
#endif

	public class HR_TitlesLevel:ReadOnlyBase<HR_TitlesLevel>
    {
        #region Business Methods

		
        public string TitlesLevelCode
        {
            get ;
            set ;
        }

		
        public string TitlesLevelName
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_TitlesLevel Create()
        {
            return EF.DataPortal.Create<HR_TitlesLevel>();
        }

		public static HR_TitlesLevel Fetch(System.Linq.Expressions.Expression<Func<HR_TitlesLevel, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_TitlesLevel>(exp,values);
            return EF.DataPortal.Fetch<HR_TitlesLevel>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_TitlesLevels))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_TitlesLevels:ReadOnlyListBase<HR_TitlesLevels,HR_TitlesLevel>
    {
        #region Factory Methods

        public static HR_TitlesLevels Fetch()
        {
            return EF.DataPortal.Fetch<HR_TitlesLevels>();
        }

		public static HR_TitlesLevels Fetch(System.Linq.Expressions.Expression<Func<HR_TitlesLevel, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_TitlesLevel>(exp,values);
            return EF.DataPortal.Fetch<HR_TitlesLevels>(lambda);
		}

		public static HR_TitlesLevels Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_TitlesLevels>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_TitlesLevels Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_TitlesLevel, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_TitlesLevels>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_TitlesLevel>(exp,values)});
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
