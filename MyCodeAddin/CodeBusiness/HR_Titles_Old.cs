using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_Titles_Old))]
#if Dev
    [RunLocal]
#endif

	public class HR_Titles_Old:ReadOnlyBase<HR_Titles_Old>
    {
        #region Business Methods

		
        public string TitlesCode
        {
            get ;
            set ;
        }

		
        public string TitlesName
        {
            get ;
            set ;
        }

		
        public string TitlesType
        {
            get ;
            set ;
        }

		
        public string TitlesLevelCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_Titles_Old Create()
        {
            return EF.DataPortal.Create<HR_Titles_Old>();
        }

		public static HR_Titles_Old Fetch(System.Linq.Expressions.Expression<Func<HR_Titles_Old, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_Titles_Old>(exp,values);
            return EF.DataPortal.Fetch<HR_Titles_Old>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_Titles_Olds))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_Titles_Olds:ReadOnlyListBase<HR_Titles_Olds,HR_Titles_Old>
    {
        #region Factory Methods

        public static HR_Titles_Olds Fetch()
        {
            return EF.DataPortal.Fetch<HR_Titles_Olds>();
        }

		public static HR_Titles_Olds Fetch(System.Linq.Expressions.Expression<Func<HR_Titles_Old, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_Titles_Old>(exp,values);
            return EF.DataPortal.Fetch<HR_Titles_Olds>(lambda);
		}

		public static HR_Titles_Olds Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_Titles_Olds>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_Titles_Olds Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_Titles_Old, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_Titles_Olds>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_Titles_Old>(exp,values)});
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
